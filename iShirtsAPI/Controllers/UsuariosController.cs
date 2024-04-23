using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using iShirtsAPI.Data;
using iShirtsAPI.Models;

namespace iShirtsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly iShirtsAPIContext _context;

        public UsuariosController(iShirtsAPIContext context)
        {
            _context = context;
        }

        // GET: api/Usuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<USUARIO>>> GetUsuario()
        {
          if (_context.USUARIO == null)
          {
              return NotFound();
          }
            return await _context.USUARIO.ToListAsync();
        }

        // GET: api/Usuarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<USUARIO>> GetUsuario(int id)
        {
          if (_context.USUARIO == null)
          {
              return NotFound();
          }
            var usuario = await _context.USUARIO.FindAsync(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;
        }

        // PUT: api/Usuarios/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuario(int id, USUARIO usuario)
        {
            if (id != usuario.ID_USUARIO)
            {
                return BadRequest();
            }

            _context.Entry(usuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(id))
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

        // POST: api/Usuarios
        [HttpPost]
        public async Task<ActionResult<USUARIO>> PostUsuario(USUARIO usuario)
        {
          if (_context.USUARIO == null)
          {
              return Problem("Entity set 'iShirtsAPIContext.Usuario'  is null.");
          }
            _context.USUARIO.Add(usuario);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UsuarioExists(usuario.ID_USUARIO))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUsuario", new { id = usuario.ID_USUARIO }, usuario);
        }

        // DELETE: api/Usuarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            if (_context.USUARIO == null)
            {
                return NotFound();
            }
            var usuario = await _context.USUARIO.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }

            _context.USUARIO.Remove(usuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UsuarioExists(int id)
        {
            return (_context.USUARIO?.Any(e => e.ID_USUARIO == id)).GetValueOrDefault();
        }
    }
}
