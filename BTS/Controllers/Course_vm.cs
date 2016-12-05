using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTS.Controllers
{
    public class CourseBase
    {
        public int sectionId { get; set; }
        public string courseCode { get; set; }
        public string courseName { get; set; }
        public string semester { get; set; }

        public Instructor Instructor { get; set; }
        public ICollection<int> StudentsId { get; set; }
    }

    public class CourseWithDetails : CourseBase
    {

    }
}