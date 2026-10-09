namespace HospitalSystem.ViewModels
{
    public class DoctorsFilteration
    {
        public string? Name { get; set; }
        public int Specialization { get; set; }
        public int Page { get; set; } = 1;
    }
}
