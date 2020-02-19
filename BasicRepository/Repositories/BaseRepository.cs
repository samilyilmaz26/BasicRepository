using BasicRepository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepository.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        ProductsContext _db;

        public BaseRepository(ProductsContext db)
        {
            _db = db;
        }

        public async Task<T> Bul(int id)
        {
            return await Set().FindAsync(id);
        }

        public async Task<T> Ekle(T entity)
        {
            _db.Entry(entity).State = EntityState.Added;
            await _db.SaveChangesAsync();
            return entity;

        }

        public async Task<T> Guncel(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<ICollection<T>> Liste()
        {
            return await Set().ToListAsync();
        }

        public DbSet<T> Set()
        {
            return _db.Set<T>();
        }

        public async Task<bool> Sil(int id)
        {
            T entity = await Bul(id);
            _db.Entry(entity).State = EntityState.Deleted;
            return await _db.SaveChangesAsync() > 0;
            //try
            //{
            //    _db.Entry(entity).State = EntityState.Deleted;
            //    await _db.SaveChangesAsync();
            //    return true;
            //}
            //catch (Exception)
            //{

            //    return false;
            //}


        }


    }
}
