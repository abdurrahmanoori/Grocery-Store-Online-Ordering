using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Grocery_Stroe_Online.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage ="Name is not allowed to be empty")]
        public string Name { get; set; }
        
        public string Password { get; set; }
    }
}
