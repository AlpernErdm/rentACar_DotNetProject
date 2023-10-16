using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal; //soyut sınıfla bağlantı kuracağız

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
        public void Add(Car car)
        {
            _carDal.Add(car);
        }
        public void Remove(Car car)
        {
            _carDal.Remove(car);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
