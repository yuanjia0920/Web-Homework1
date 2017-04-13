using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Homework1.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please enter From")]
        public string FromName { get; set; }

        [Required(ErrorMessage = "Please enter To")]
        public string ToName { get; set; }

        [Required(ErrorMessage = "Please enter Message")]
        public string Message { get; set; }

    }
}