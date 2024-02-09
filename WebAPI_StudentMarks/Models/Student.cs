using System;
using System.Collections.Generic;

namespace WebAPI_StudentMarks.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; }
        public int? Marks { get; set; }
    }
}
