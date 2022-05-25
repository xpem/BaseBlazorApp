using BlazorApp.Models;
using System.Collections.Generic;

namespace BlazorApp.UnitofWork
{
    public interface IPaymentDetailRepos<T> where T : PaymentDetail
    {
        List<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
