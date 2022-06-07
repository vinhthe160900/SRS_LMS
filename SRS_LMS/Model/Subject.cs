using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SRS_LMS.Model
{
    public class Subject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubjectId { get; set; }
        public String SubjectName { get; set; }
        public int NumberOfPeriod { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
        public List<Class> Class { get; set; }
        public List<Question> Question { get; set; }
        public List<Schedule> Schedules { get; set; }
        public List<Document> Documents { get; set; }
    }
}
