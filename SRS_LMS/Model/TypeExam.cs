using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SRS_LMS.Model
{
    public class TypeExam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TypeExamId { get; set; }
        public int TypeName { get; set; }
        public List<Exam> Exam { get; set; }
    }
}
