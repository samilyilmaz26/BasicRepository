using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepository.Entities
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string  ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public bool Status { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Categories Categories{ get; set; }
    }
}
