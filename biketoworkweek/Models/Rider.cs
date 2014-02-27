using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace biketoworkweeklogger.Models
{
    public class Rider
    {
        public int RiderID { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public int TeamID { get; set; }
        public Guid UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}