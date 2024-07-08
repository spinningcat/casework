using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using exampleapp.Data;
using exampleapp.Models;

using exampleapp.util;
using Microsoft.AspNetCore.Cors.Infrastructure;
using exampleapp.Interface;

namespace exampleapp.Controllers
{
    public class CoachFieldsController : Controller
    {
        private readonly ConachFieldDBContext _context;
        private IEmailService _email;

        public CoachFieldsController(ConachFieldDBContext context, IEmailService email)
        {
            _context = context;
            _email = email;
        }

        // GET: CoachFields
        /*   public async Task<IActionResult> Index()
           {
               return View(await _context.CoachField.ToListAsync());
           }*/
        public async Task<IActionResult> Index()
        {
            var coachFields = await _context.CoachField
                                          .Select(cf => new CoachField
                                          {
                                              Id = cf.Id,
                                              Name = cf.Name,
                                              PhoneNumber = cf.PhoneNumber,
                                              Email = cf.Email,
                                              Experience = cf.Experience,
                                              WorkingDepartment = cf.WorkingDepartment,
                                              AcademicBackground = cf.AcademicBackground,   
                                              Status = cf.Status,
                                          })
                                          .ToListAsync();
            return View(coachFields);
        }

        // GET: CoachFields/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coachField = await _context.CoachField
                .FirstOrDefaultAsync(m => m.Id == id);
            if (coachField == null)
            {
                return NotFound();
            }

            return View(coachField);
        }

        // GET: CoachFields/Create
        public IActionResult Create()
        {
            return View();
        }

 
  

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CoachField coachField)
        {
            if (ModelState.IsValid)
            {
                _context.Add(coachField);
                await _context.SaveChangesAsync();
                await _email.SendEmailAsync("example", "example", "example");
                return RedirectToAction(nameof(Index));
            }
            else
            {
           
                return BadRequest(ModelState);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit([FromBody] ConfirmationData data)
        {
            try
            {
                // Check if data is null or not valid
              /*  if (data == null || !ModelState.IsValid || id != data.Id)
                {
                    return BadRequest("Invalid data or ID mismatch");
                }*/

                // Find the coachField by id
                var coachField = await _context.CoachField.FindAsync(data.Id);
                if (coachField == null)
                {
                    return NotFound("CoachField not found");
                }

                // Update the status (or any other property based on Confirm value)
                coachField.Status = data.Confirm;

                // Update entity in the context
                _context.Update(coachField);
                await _context.SaveChangesAsync();

                // Return success response
                return Ok(new { message = "Confirmation updated successfully" });
            }
            catch (Exception ex)
            {
                // Handle exceptions
                return StatusCode(500, $"Error updating confirmation: {ex.Message}");
            }
        }

  

        // GET: CoachFields/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coachField = await _context.CoachField
                .FirstOrDefaultAsync(m => m.Id == id);
            if (coachField == null)
            {
                return NotFound();
            }

            return View(coachField);
        }

        // POST: CoachFields/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var coachField = await _context.CoachField.FindAsync(id);
            if (coachField != null)
            {
                _context.CoachField.Remove(coachField);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CoachFieldExists(int id)
        {
            return _context.CoachField.Any(e => e.Id == id);
        }
    }
}
