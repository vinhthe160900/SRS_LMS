using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SRS_LMS.Model
{
    public class Exam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ExamId { get; set; }
        public string ExamName { get; set; }
        public string ContentExam { get; set; }
        public DateTime ExamDte { get; set; }
        public float Time { get; set; }
        public string Unit { get; set; }
        public bool Status { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int TypeExamId { get; set; }
        public TypeExam TypeExam { get; set; }

    }
}
