using System.ComponentModel.DataAnnotations;

namespace SRS_LMS.Models
{
    public class ClassAddRequest
    {
        [Required]
        public string ClassName { get; set; } = string.Empty;
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public int SubjectId { get; set; }
    }
}
