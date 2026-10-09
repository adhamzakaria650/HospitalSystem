namespace HospitalSystem.ViewModels
{
    public class AppointmentDetails
    {
        public int doctorId { get; set; }
        public string PatientName { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
    }
}
