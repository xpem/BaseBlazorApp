using BlazorApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorApp.UnitofWork
{
    public class PaymentDetailRepos<T> : IPaymentDetailRepos<T> where T : PaymentDetail
    {
        #region property
        private readonly PaymentDetailContext _applicationDbContext;
        private DbSet<T> entities;
        #endregion

        #region Constructor
        public PaymentDetailRepos(PaymentDetailContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            entities = _applicationDbContext.Set<T>();
        }
        #endregion

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            _applicationDbContext.SaveChanges();
        }


        public List<T> GetAll()
        {
            return entities.ToList();
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            _applicationDbContext.SaveChanges();
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }

        public void SaveChanges()
        {
            _applicationDbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            _applicationDbContext.SaveChanges();
        }
    }
}
