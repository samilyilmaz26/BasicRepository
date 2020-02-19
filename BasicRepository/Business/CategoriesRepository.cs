using BasicRepository.Context;
using BasicRepository.DTOs;
using BasicRepository.Entities;
using BasicRepository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepository.Business
{
   
    
    public class CategoriesRepository: BaseRepository<Categories>
    {
        public CategoriesRepository(ProductsContext db ):base(db)
        {
            
        }
        public ICollection<CategoriesDTO> GetCategories()
        {
          
          return  Set().Select(x => new CategoriesDTO
            {
                 CategoryId = x.CategoryId, CategoryName =x.CategoryName
            }).ToList();
        }
    }
}
