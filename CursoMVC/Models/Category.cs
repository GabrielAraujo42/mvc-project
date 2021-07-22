using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Category
    {
        public int id { get; set; }
        public string description { get; set; }

        public List<Product> Products { get; set; }
    }
}
