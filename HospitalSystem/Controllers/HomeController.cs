using HospitalSystem.Data;
using HospitalSystem.Models;
using HospitalSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace HospitalSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public ViewResult AddAppointment(DoctorsFilteration f)
        {
            var Doctors = _context.Doctors.AsQueryable();
            Doctors = Doctors.Include(d => d.specialization);
            if(f.Name != null)
            {
                Doctors = Doctors.Where(d => d.Name.Contains(f.Name));
            }
            if(f.Specialization != 0)
            {
                Doctors = Doctors.Where(d => d.specialization.Id == f.Specialization);
            }
            ViewBag.specializations = _context.Specializations.AsQueryable();
            ViewBag.pages =(int)Math.Ceiling(Doctors.Count() / 3.0);
            Doctors = Doctors.Skip((f.Page - 1) * 3).Take(3);
            ViewBag.page = f.Page;
            return View(Doctors.AsEnumerable());
        }
        [HttpGet]
        public IActionResult MakeAppointment(int doctorId)
        {
            var doctor = _context.Doctors
                .Include(d => d.specialization)
                .FirstOrDefault(d => d.Id == doctorId);

            if (doctor == null)
            {
                return NotFound();
            }

            return View(doctor);
        }

        [HttpPost]
        public IActionResult MakeAppointment(AppointmentDetails ad)
        {
            var Doctor = _context.Doctors
                .Include(d => d.specialization)
                .FirstOrDefault(d => d.Id == ad.doctorId);

            var appointment = _context.Appointments
                .FirstOrDefault(a => a.DoctorId == ad.doctorId && a.Day == ad.Date && a.PatientName == ad.PatientName);

            if (appointment != null)
            {
                ViewBag.Error = "This time is already booked";
                return View(Doctor);
            }
            else
            {
                var app = new Appointment()
                {
                    DoctorId = ad.doctorId,
                    Day = ad.Date,
                    Time = ad.Time,
                    PatientName = ad.PatientName
                };

                _context.Appointments.Add(app);
                _context.SaveChanges();

                return RedirectToAction("ListAppointments");
            }
        }
        public ViewResult ListAppointments()
        {
            var appointments = _context.Appointments.Include(a=>a.doctor).ThenInclude(d=>d.specialization).AsQueryable();
            return View(appointments.AsEnumerable());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
