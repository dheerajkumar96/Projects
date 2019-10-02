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
    public class mobilesController : ControllerBase
    {
        private readonly Mainpagecontext _context;

        public mobilesController(Mainpagecontext context)
        {
            _context = context;
        }

        // GET: api/mobiles
        [HttpGet]
        public IEnumerable<mobiles> Getmobiles()
        {
            return _context.mobiles;
        }

        // GET: api/mobiles/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Getmobiles([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mobiles = await _context.mobiles.FindAsync(id);

            if (mobiles == null)
            {
                return NotFound();
            }

            return Ok(mobiles);
        }

        // PUT: api/mobiles/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Putmobiles([FromRoute] int id, [FromBody] mobiles mobiles)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mobiles.id)
            {
                return BadRequest();
            }

            _context.Entry(mobiles).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!mobilesExists(id))
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

        // POST: api/mobiles
        [HttpPost]
        public async Task<IActionResult> Postmobiles([FromBody] mobiles mobiles)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.mobiles.Add(mobiles);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getmobiles", new { id = mobiles.id }, mobiles);
        }

        // DELETE: api/mobiles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletemobiles([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mobiles = await _context.mobiles.FindAsync(id);
            if (mobiles == null)
            {
                return NotFound();
            }

            _context.mobiles.Remove(mobiles);
            await _context.SaveChangesAsync();

            return Ok(mobiles);
        }

        private bool mobilesExists(int id)
        {
            return _context.mobiles.Any(e => e.id == id);
        }
    }
}