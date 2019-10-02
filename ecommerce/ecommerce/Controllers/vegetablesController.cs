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
    public class vegetablesController : ControllerBase
    {
        private readonly Mainpagecontext _context;

        public vegetablesController(Mainpagecontext context)
        {
            _context = context;
        }

        // GET: api/vegetables
        [HttpGet]
        public IEnumerable<vegetables> Getvegetables()
        {
            return _context.vegetables;
        }

        // GET: api/vegetables/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Getvegetables([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var vegetables = await _context.vegetables.FindAsync(id);

            if (vegetables == null)
            {
                return NotFound();
            }

            return Ok(vegetables);
        }

        // PUT: api/vegetables/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Putvegetables([FromRoute] int id, [FromBody] vegetables vegetables)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vegetables.id)
            {
                return BadRequest();
            }

            _context.Entry(vegetables).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!vegetablesExists(id))
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

        // POST: api/vegetables
        [HttpPost]
        public async Task<IActionResult> Postvegetables([FromBody] vegetables vegetables)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.vegetables.Add(vegetables);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getvegetables", new { id = vegetables.id }, vegetables);
        }

        // DELETE: api/vegetables/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletevegetables([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var vegetables = await _context.vegetables.FindAsync(id);
            if (vegetables == null)
            {
                return NotFound();
            }

            _context.vegetables.Remove(vegetables);
            await _context.SaveChangesAsync();

            return Ok(vegetables);
        }

        private bool vegetablesExists(int id)
        {
            return _context.vegetables.Any(e => e.id == id);
        }
    }
}