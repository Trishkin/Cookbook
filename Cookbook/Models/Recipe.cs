using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Insraction { get; set; }
        public string Products { get; set; }
        public User Publisher { get; set; }
        public DateTime TimeOfCreation { get; set; }
    }
}
