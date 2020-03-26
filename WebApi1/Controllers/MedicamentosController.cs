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
    public class MedicamentosController : ControllerBase
    {
        private readonly MedicamentoContexto _context;
        public MedicamentosController(MedicamentoContexto contexto)
        {
            _context = contexto;
        }

        //Peticion tipo Get
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Medicamento>>> GetMedicamentoItems() 
        {

            return await _context.MedicamentoItem.ToListAsync();
        }



        [HttpGet("{id}")]
            public async Task<ActionResult<Medicamento>> GetMedicamentoItems(int id) 
        {
            var MedicamentoItem = await _context.MedicamentoItem.FindAsync(id);

            if(MedicamentoItem == null) 
            {

                return NotFound();
            }
            return MedicamentoItem;


        }

        //Peticion tipo Post
        [HttpPost]

        public async Task<ActionResult<Medicamento>> PostMedicamentoItems(Medicamento item) 
        
        {
            _context.MedicamentoItem.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMedicamentoItems), new { id = item.ID }, item);
        }

        [HttpPut("{id}")]

        public async Task<ActionResult> PutMedicamentoItem(int id, Medicamento item) 
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

        public async Task<ActionResult> DeleteMedicamentoItem(int id) 
        {
            var medicamentoitem = await _context.MedicamentoItem.FindAsync(id);

            if(medicamentoitem == null) 
            {
                return NotFound();
            }

            _context.MedicamentoItem.Remove(medicamentoitem);
            await _context.SaveChangesAsync();
            return NoContent();
        
        }

    }

}