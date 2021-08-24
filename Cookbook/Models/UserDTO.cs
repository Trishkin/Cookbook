using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.Models
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public List<Recipe> Recipes { get; set; }
    }
}
