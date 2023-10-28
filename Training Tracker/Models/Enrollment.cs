using System.ComponentModel.DataAnnotations;

namespace Training_Tracker.Models
{
    public enum Feedback
    {
        Poor, Ok, Good,VeryGood
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int TrainingID { get; set;}
        public int EmployeeID { get; set; }
        
        [DisplayFormat(NullDisplayText ="No feedback")]
        public Feedback Feedback { get; set; }

        public Training Training { get; set; }
        public Employee Employee { get; set; }  
    }
}
