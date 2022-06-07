﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SRS_LMS.Model
{
    public class Schedule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ScheduleId { get; set; }
        public DateTime Time { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public int SubjectId{ get; set; }
        public Subject Subject { get; set; }
    }
}
