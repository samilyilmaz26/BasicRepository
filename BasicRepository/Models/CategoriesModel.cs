using BasicRepository.DTOs;
using BasicRepository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepository.Models
{
    public class CategoriesModel
    {
        public ICollection<CategoriesDTO>  CatList { get; set; }
        public Categories Categories { get; set; }
    }
}
