using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepository.DTOs
{
    public class ProductsDTO
    {
        public int ProductId { get; set; }
        public string  ProductName { get; set; }
        public string  CategoryName { get; set; }
    }
}
