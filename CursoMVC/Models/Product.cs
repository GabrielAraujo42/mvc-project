using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
