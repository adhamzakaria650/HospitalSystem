using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalSystem.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Phone { get; set; }
        public int SpecializationId { get; set; }
        [ForeignKey(nameof(SpecializationId))]
        public Specialization specialization { get; set; }
    }
}
