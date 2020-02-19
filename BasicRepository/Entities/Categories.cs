using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepository.Entities
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        public string  CategoryName { get; set; }
        public  ICollection<Products> Products { get; set; }
    }
}
