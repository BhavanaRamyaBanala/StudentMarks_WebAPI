using System;
using System.Collections.Generic;

namespace WebAPI_StudentMarks.Models
{
    public partial class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; } = null!;
    }
}
