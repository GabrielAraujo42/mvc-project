using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Category
    {
        public int id { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "The description must be filled.")]
        public string description { get; set; }
    }
}
