using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Grocery_Stroe_Online.Models
{
    public class Category
    {
        [Key]
        
        public int Id { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage ="Name is Required!")]
        public string Name { get; set; }

    }
}
