using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ecommerce.Models;

namespace ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainpagesController : ControllerBase
    {
        private readonly Mainpagecontext _context;

        public MainpagesController(Mainpagecontext context)
        {
            _context = context;
        }

        // GET: api/Mainpages
        [HttpGet]
        public IEnumerable<Mainpage> GetMainpages()
        {
            return _context.Mainpages;
        }

        // GET: api/Mainpages/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMainpage([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mainpage = await _context.Mainpages.FindAsync(id);

            if (mainpage == null)
            {
                return NotFound();
            }

            return Ok(mainpage);
        }

        // PUT: api/Mainpages/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMainpage([FromRoute] int id, [FromBody] Mainpage mainpage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mainpage.id)
            {
                return BadRequest();
            }

            _context.Entry(mainpage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MainpageExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Mainpages
        [HttpPost]
        public async Task<IActionResult> PostMainpage([FromBody] Mainpage mainpage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Mainpages.Add(mainpage);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMainpage", new { id = mainpage.id }, mainpage);
        }

        // DELETE: api/Mainpages/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMainpage([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mainpage = await _context.Mainpages.FindAsync(id);
            if (mainpage == null)
            {
                return NotFound();
            }

            _context.Mainpages.Remove(mainpage);
            await _context.SaveChangesAsync();

            return Ok(mainpage);
        }

        private bool MainpageExists(int id)
        {
            return _context.Mainpages.Any(e => e.id == id);
        }
    }
}