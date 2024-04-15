using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniCoreApi1.Models;

namespace MiniCoreApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendedoresController : Controller
    {
        private readonly MiniCoreVentasContext _context;

        public VendedoresController(MiniCoreVentasContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vendedor>>> GetVendedor()
        {
            if (_context.Vendedores == null)
            {
                return NotFound();
            }
            return await _context.Vendedores.ToListAsync();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Vendedor>> GetVendedor(int id)
        {
            if (_context.Vendedores == null)
            {
                return NotFound();
            }
            var vendedor = await _context.Vendedores.FindAsync(id);

            if (vendedor == null)
            {
                return NotFound();
            }
            return vendedor;
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutVendedor(int id, Vendedor vendedor)
        {
            if (id != vendedor.IdVendedor)
            {
                return NotFound();
            }

            _context.Entry(vendedor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VendedorExists(id))
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



        [HttpPost]
        public async Task<ActionResult<Vendedor>> PostVendedor(Vendedor vendedor)
        {
            if (_context.Vendedores == null)
            {
                return Problem(" - ");
            }
            _context.Vendedores.Add(vendedor);

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVendedor", new { id = vendedor.IdVendedor }, vendedor);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVendedor(int id)
        {
            if (_context.Vendedores == null)
            {
                return NotFound();
            }
            var vendedor = await _context.Vendedores.FindAsync(id);

            if(vendedor == null)
            {
                return NotFound();
            }
            _context.Vendedores.Remove(vendedor);
            await _context.SaveChangesAsync();

            return NoContent();

        }

        private bool VendedorExists(int id)
        {
            return (_context.Vendedores?.Any(e => e.IdVendedor == id)).GetValueOrDefault();
        }

    }

}

