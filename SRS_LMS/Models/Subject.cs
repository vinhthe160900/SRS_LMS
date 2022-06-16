﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SRS_LMS.Models
{
    public class Subject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public int NumberOfPeriod { get; set; }      
        public List<Class> Class { get; set; }
        public List<Question> Questions { get; set; }
        public List<Schedule> Schedules { get; set; }
        public List<Document> Documents { get; set; }

    }
}
