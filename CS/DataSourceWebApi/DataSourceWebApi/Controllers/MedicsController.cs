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
    public class MedicsController : ControllerBase
    {
        private readonly MedicsSchedulingContext _context;

        public MedicsController(MedicsSchedulingContext context)
        {
            _context = context;
        }

        // GET: api/Medics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Medics>>> GetMedics()
        {
            return await _context.Medics.ToListAsync();
        }

        // GET: api/Medics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Medics>> GetMedics(int id)
        {
            var medics = await _context.Medics.FindAsync(id);

            if (medics == null)
            {
                return NotFound();
            }

            return medics;
        }

        private bool MedicsExists(int id)
        {
            return _context.Medics.Any(e => e.Id == id);
        }
    }
}
