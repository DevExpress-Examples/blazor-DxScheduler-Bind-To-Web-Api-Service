using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataSourceWebApi.Models;

namespace DataSourceWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalAppointmentsController : ControllerBase
    {
        private readonly MedicsSchedulingContext _context;

        public MedicalAppointmentsController(MedicsSchedulingContext context)
        {
            _context = context;
        }

        // GET: api/MedicalAppointments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MedicalAppointments>>> GetMedicalAppointments()
        {
            return await _context.MedicalAppointments.ToListAsync();
        }

        // GET: api/MedicalAppointments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MedicalAppointments>> GetMedicalAppointments(int id)
        {
            var medicalAppointments = await _context.MedicalAppointments.FindAsync(id);

            if (medicalAppointments == null)
            {
                return NotFound();
            }

            return medicalAppointments;
        }

        // PUT: api/MedicalAppointments/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedicalAppointments(int id, MedicalAppointments medicalAppointments)
        {
            if (id != medicalAppointments.Id)
            {
                return BadRequest();
            }

            _context.Entry(medicalAppointments).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedicalAppointmentsExists(id))
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

        // POST: api/MedicalAppointments
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<MedicalAppointments>> PostMedicalAppointments(MedicalAppointments medicalAppointments)
        {
            _context.MedicalAppointments.Add(medicalAppointments);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMedicalAppointments", new { id = medicalAppointments.Id }, medicalAppointments);
        }

        // DELETE: api/MedicalAppointments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MedicalAppointments>> DeleteMedicalAppointments(int id)
        {
            var medicalAppointments = await _context.MedicalAppointments.FindAsync(id);
            if (medicalAppointments == null)
            {
                return NotFound();
            }

            _context.MedicalAppointments.Remove(medicalAppointments);
            await _context.SaveChangesAsync();

            return medicalAppointments;
        }

        private bool MedicalAppointmentsExists(int id)
        {
            return _context.MedicalAppointments.Any(e => e.Id == id);
        }
    }
}
