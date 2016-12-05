using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTS.Controllers
{
    public class IncidentEditForm
    {
        public int Id { get; set; }
        public DateTime dateReported { get; set; }
        public string description { get; set; }
        public string status { get; set; }

        public ICollection<int> StudentIds { get; set; }
        public int InstructorId { get; set; }
    }

    public class IncidentEdit
    {
        public int Id { get; set; }
        public DateTime dateReported { get; set; }
        public string description { get; set; }
        public string status { get; set; }

        public ICollection<int> StudentIds { get; set; }
        public int InstructorId { get; set; }
    }

    public class IncidentWithDetails : IncidentEdit
    {

    }
}