using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ContactApp_Client.Models
{
    public class Contact
    {
        [Display(Name = "ContactId")]
        public int ContactId { get; set; }

        [Display(Name = "FirstName")]
        public string FirstName { get; set; }
        

        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Status")]
        public Nullable<bool> Status { get; set; }
    }
}