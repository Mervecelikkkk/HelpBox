﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HelpBox.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity:class
    {
        //Id'ye göre ürün çekme
        Task<TEntity> GetByIdAsync(int Id);
        //Tüm ürünleri çekme
        Task<IEnumerable<TEntity>> GetAllAsync();

        //Find(x=>x.Id=23) sorgusuyla aranan ürün
        //TEntity parametresini alan ve geriye bool dönen bir metot
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        //Category.SingleOrDefaultAsync(x=>x.name="kalem")
        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        //Entity ekleme
        Task AddAsync(TEntity entity);

        //Birden fazla kayıt(entity) ekleme
        Task AddRangeAsync(IEnumerable<TEntity> entities);

        //KayıtSilme
        void Remove(TEntity entity);

        //Birden fazla kayıt silme
        void RemoveRange(IEnumerable<TEntity> entity);

        //Güncelleme
        TEntity Update(TEntity entity); 









    }
}
