using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HospitalManagementSystem.Data;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Pages.Appointments
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Appointment Appointment { get; set; }

        public SelectList PatientList { get; set; }
        public SelectList DoctorList { get; set; }

        public void OnGet()
        {
            PatientList = new SelectList(_context.Patients, "Id", "FullName");
            DoctorList = new SelectList(_context.Doctors, "Id", "FullName");
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Appointments.Add(Appointment);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}

