using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VikingKozos;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LottoController : ControllerBase
    {
        private readonly VikingContext _context;

        public LottoController(VikingContext context)
        {
            _context = context;
        }

        // GET: api/Lotto
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Huzas>>> GetHuzasok()
        {
            return await _context.Huzasok.ToListAsync();
        }

        // GET: api/Lotto/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Huzas>> GetHuzas(int id)
        {
            var huzas = await _context.Huzasok.FindAsync(id);

            if (huzas == null)
            {
                return NotFound();
            }

            return huzas;
        }

        // PUT: api/Lotto/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHuzas(int id, Huzas huzas)
        {
            if (id != huzas.Id)
            {
                return BadRequest();
            }

            _context.Entry(huzas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HuzasExists(id))
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

        // POST: api/Lotto
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Huzas>> PostHuzas(Huzas huzas)
        {
            _context.Huzasok.Add(huzas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHuzas", new { id = huzas.Id }, huzas);
        }

        // DELETE: api/Lotto/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHuzas(int id)
        {
            var huzas = await _context.Huzasok.FindAsync(id);
            if (huzas == null)
            {
                return NotFound();
            }

            _context.Huzasok.Remove(huzas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HuzasExists(int id)
        {
            return _context.Huzasok.Any(e => e.Id == id);
        }
    }
}
