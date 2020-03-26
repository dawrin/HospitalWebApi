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
    public class DoctoresController : ControllerBase
    {
        private readonly DoctorContexto _context;
        public DoctoresController(DoctorContexto contexto)
        {
            _context = contexto;
        }

        //Peticion tipo Get
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Doctor>>> GetDoctorItems()
        {

            return await _context.DoctorItem.ToListAsync();
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<Doctor>> GetDoctorItems(int id)
        {
            var DoctorItem = await _context.DoctorItem.FindAsync(id);

            if (DoctorItem == null)
            {

                return NotFound();
            }
            return DoctorItem;


        }

        //Peticion tipo Post
        [HttpPost]

        public async Task<ActionResult<Medicamento>> PostDoctorItems(Doctor item)

        {
            _context.DoctorItem.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDoctorItems), new { id = item.ID }, item);
        }

        [HttpPut("{id}")]

        public async Task<ActionResult> PutDoctorItem(int id, Doctor item)
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

        public async Task<ActionResult> DeleteDoctorItem(int id)
        {
            var doctoritem = await _context.DoctorItem.FindAsync(id);

            if (doctoritem == null)
            {
                return NotFound();
            }

            _context.DoctorItem.Remove(doctoritem);
            await _context.SaveChangesAsync();
            return NoContent();

        }




    }
}