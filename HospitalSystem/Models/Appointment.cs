using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalSystem.Models
{
    [PrimaryKey(nameof(PatientName),nameof(DoctorId),nameof(Day))]
    public class Appointment
    {
        public string PatientName { get; set; }
        public int DoctorId { get; set; }
        [ForeignKey(nameof(DoctorId))]
        public Doctor doctor { get; set; }
        public DateOnly Day { get; set; }
        public TimeOnly Time { get; set; }
    }
}
