using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
//core katmanı başka katmanı referans almaz!!!
namespace Core.DataAccess
{
    //generic constraint - generic kısıtlama T'yi
    //class - referans tip
    //IEntity - IEntity veya onu implement eden bir nesne 
    //new() - new'lenebilir olmalı (artık T IEntity'nin kendisi olamaz)
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
