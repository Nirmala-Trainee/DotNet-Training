using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApi_Assessment_1.Models
{
    public class Country
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string CountryName { get; set; }

        [Required]
        public string Capital { get; set; }
    }
}