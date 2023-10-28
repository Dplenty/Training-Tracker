using System.ComponentModel.DataAnnotations.Schema;

namespace Training_Tracker.Models
{
    public class Training
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TrainingID { get; set; }
        public string Title { get; set; }
        public int Hours { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
