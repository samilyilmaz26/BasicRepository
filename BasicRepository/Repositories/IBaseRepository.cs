using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepository.Repositories
{
 
    public    interface IBaseRepository<T> where T:class ,new()
    {
       Task <T>  Guncel(T entity);
       Task  <T>  Ekle(T entity);
       Task  <bool>  Sil(int id);
       Task  <ICollection<T>> Liste();
       Task <T>  Bul(int id);
        DbSet<T> Set();
    }
}
