using BasicRepository.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepository.Context
{
    public class ProductsContext:DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options):base(options)
        {

        }
        DbSet<Products> Products { get; set; }
        DbSet<Categories> Categories { get; set; }
    }
}
