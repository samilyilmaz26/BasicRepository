using BasicRepository.Context;
using BasicRepository.DTOs;
using BasicRepository.Entities;
using BasicRepository.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepository.Business
{
    public interface IProductRep
    {
       ICollection<ProductsDTO>   GetAll();
    }

    public class ProductsRepository:BaseRepository<Products>,IProductRep
    {
        private readonly ProductsContext _db;
        public ProductsRepository(ProductsContext db) : base(db)
        {
            _db = db;

        }
        public ICollection<ProductsDTO> GetAll()
        {
            //return    _db.Set<Products>().Include(x => x.Categories).Select(x=> new ProductsDTO { 

            //     ProductId =x.ProductId,
            //      ProductName = x.ProductName,
            //      CategoryName = x.Categories.CategoryName
            //   }).ToList();
            //var lst = _db.Set<Products>().Include(x => x.Categories).Select(x => new ProductsDTO
            //{

            //    ProductId = x.ProductId,
            //    ProductName = x.ProductName,
            //    CategoryName = x.Categories.CategoryName
            //}).ToList();

            return (from p in _db.Set<Products>()
                        join c in _db.Set<Categories>() on p.CategoryId equals c.CategoryId
                        select new ProductsDTO
                        {
                            CategoryName = c.CategoryName,
                            ProductId = p.ProductId,
                            ProductName = p.ProductName
                        }).ToList();

        }
    }
}
