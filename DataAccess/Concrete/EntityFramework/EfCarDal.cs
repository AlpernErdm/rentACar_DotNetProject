using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : IEntityRepository<Car>
    {
        public void Add(Car entity)
        {
            using (ReCapProjectDbContext context =new ReCapProjectDbContext())
            {
                var addedCar = context.Entry(entity);
                addedCar.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (ReCapProjectDbContext context =new ReCapProjectDbContext())
            {
                return context.Set<Car>().SingleOrDefault();
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapProjectDbContext context =new ReCapProjectDbContext())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            }
        }

        public void Remove(Car entity)
        {
            using (ReCapProjectDbContext context=new ReCapProjectDbContext())
            {
                var removedCar = context.Entry(entity);
                removedCar.State = EntityState.Added;
                context.SaveChanges();
            }
            
        }

        public void Update(Car entity)
        {
            using (ReCapProjectDbContext context = new ReCapProjectDbContext())
            {
                var updatedCar = context.Entry(entity);
                updatedCar.State = EntityState.Added;
                context.SaveChanges();
            }
        }
    }
}
