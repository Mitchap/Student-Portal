namespace StudentPortal.Models
{
    public class AddStudentViewModel
    {
        required
        public string Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public bool Subscribed { get; set; }
    }
}
