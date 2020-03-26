using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi1.Data;
using WebApi1.Modelos;

namespace WebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacientesController : ControllerBase
    {
        private readonly PacienteContexto _context;
        public PacientesController(PacienteContexto contexto)
        {
            _context = contexto;
        }

        //Peticion tipo Get
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Paciente>>> GetPacienteItems()
        {

            return await _context.PacienteItem.ToListAsync();
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<Paciente>> GetPacienteItems(int id)
        {
            var pacienteItem = await _context.PacienteItem.FindAsync(id);

            if (pacienteItem == null)
            {

                return NotFound();
            }
            return pacienteItem;


        }

        //Peticion tipo Post
        [HttpPost]

        public async Task<ActionResult<Paciente>> PostMedicamentoItems(Paciente item)

        {
            _context.PacienteItem.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPacienteItems), new { id = item.ID }, item);
        }

        [HttpPut("{id}")]

        public async Task<ActionResult> PutPacienteItem(int id, Paciente item)
        {
            if (id != item.ID)
            {
                return BadRequest();
            }
            _context.Entry(item).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();

        }


        [HttpDelete("{id}")]

        public async Task<ActionResult> DeletePacienteItem(int id)
        {
            var pacienteitem = await _context.PacienteItem.FindAsync(id);

            if (pacienteitem == null)
            {
                return NotFound();
            }

            _context.PacienteItem.Remove(pacienteitem);
            await _context.SaveChangesAsync();
            return NoContent();

        }



    }
}