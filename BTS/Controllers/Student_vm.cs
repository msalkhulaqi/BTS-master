using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTS.Controllers
{
    public class StudentBase
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string emailAdress { get; set; }
        public string year { get; set; }
        public ICollection<int> IncidentsId { get; set; }
        public ICollection<int> CoursesId { get; set; }
    }

    public class StudentWithDetail : StudentBase
    {

    }
}