using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace week6_c.Models
{
    public class SampleFormViewModels
    {
    }

    public class FormOneViewModel {
        [Required]
        [StringLength(5)]
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
}