using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fit_5032_ass.Models
{
    public class Mail
    {
        [Required(ErrorMessage = "Enter the correct receiver")]
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

    }
}