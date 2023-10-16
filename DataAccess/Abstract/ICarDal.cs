using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
   public interface ICarDal
    {
        List<Car> GetAll(); //Arabalar listesinin hepsini çek
        void Add(Car car);
        void Update(Car car);
        void Remove(Car car);
        List<Car> GetById(int CarId);
    }
}
