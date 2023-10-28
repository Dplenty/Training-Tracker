namespace Training_Tracker.Models
{
    public class Employee
    {
        public int Id { get; set; } 
        public string LastName { get; set; }
        public string FirstName { get; set; }   
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
