using System;
using System.Collections.Generic;

namespace backend.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? CurrentGradeId { get; set; }

        public Grade CurrentGrade { get; set; }
    }
}
