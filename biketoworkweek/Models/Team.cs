using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace biketoworkweeklogger.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}