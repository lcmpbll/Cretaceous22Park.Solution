using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CretaceousPark.Models;

namespace CretaceousPark.Solution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private readonly CretaceousParkContext _context;

        public AnimalsController(CretaceousParkContext context)
        {
            _context = context;
        }
        
  /// <summary>
  /// Get Operation
  /// </summary>
  /// <remarks>
  /// Sample value of message
  /// 
  ///   Returns all current animals
  ///     
  /// </remarks>
  
        // [HttpGet]
        // public async Task<ActionResult<IEnumerable<Animal>>> GetAnimals()
        // {
        //     return await _context.Animals.ToListAsync();
        // }

        // GET: api/Animals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Animal>> GetAnimal(int id)
        {
            var animal = await _context.Animals.FindAsync(id);

            if (animal == null)
            {
                return NotFound();
            }
            return CreatedAtAction(nameof(GetAnimal), new { id = animal.AnimalId }, animal);
        }
        
        [HttpGet]
        public async Task<List<Animal>> Get(string species, string gender, string name, int minimumAge)
        {
            IQueryable<Animal> query = _context.Animals.AsQueryable();
            
            if (species != null)
            {
                query = query.Where(entry => entry.Species == species);
            }
            if (gender != null)
            {
                query = query.Where(entry => entry.Gender == gender);
            }
            if (name != null)
            {
                query = query.Where(entry => entry.Name == name);
            }
            if ( minimumAge > 0)
            {
                query = query.Where(entry => entry.Age >= minimumAge);
            }
            
            return await query.ToListAsync();
        }

        // PUT: api/Animals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnimal(int id, Animal animal)
        {
            if (id != animal.AnimalId)
            {
                return BadRequest();
            }

            _context.Entry(animal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnimalExists(id))
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

        // POST: api/Animals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Animal>> PostAnimal(Animal animal)
        {
            _context.Animals.Add(animal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAnimal", new { id = animal.AnimalId }, animal);
        }

        // DELETE: api/Animals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnimal(int id)
        {
            var animal = await _context.Animals.FindAsync(id);
            if (animal == null)
            {
                return NotFound();
            }

            _context.Animals.Remove(animal);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AnimalExists(int id)
        {
            return _context.Animals.Any(e => e.AnimalId == id);
        }
    }
}
