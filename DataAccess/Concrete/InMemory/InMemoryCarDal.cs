using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;//Veri varmış gibi davranıyoruz //global değişken _cars 
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car { CarId = 1, BrandId = 1,ColorId=1,DailyPrice=100,ModelYear=2004,Description="Beyaz Opel Astra"},
                new Car { CarId = 2, BrandId = 2,ColorId=3,DailyPrice=200,ModelYear=2016,Description="Citroen 3008"},
                new Car { CarId = 3, BrandId = 2,ColorId=2,DailyPrice=150,ModelYear=2015,Description="Citroen 2008"},
                new Car { CarId = 4, BrandId = 3,ColorId=4,DailyPrice=400,ModelYear=2019,Description="Audi A5"},
                new Car { CarId = 5, BrandId = 1,ColorId=1,DailyPrice=500,ModelYear=2021,Description="BMW 5.20"},

            };
            var res = _cars.Any(p => p.Description == "Audi A5");
            Console.WriteLine("Any linq sorgusu cevabı :" + res);
            Console.WriteLine("******************");

            var res1 = _cars.Find(p => p.CarId == 2);
            Console.WriteLine("Find linq sorgusu cevabı : " +res1.Description);
            Console.WriteLine("******************");

            var res2 = _cars.FindAll(p => p.Description.Contains("oen"));
            foreach (var car in res2)
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("******************");
            var res3 = from p in _cars
                       where p.DailyPrice > 200 &&p.ModelYear>2005  
                       select p;
            foreach (var cars in res3)
            {
                Console.WriteLine(cars.Description);
            }
            Console.WriteLine("-********************");
        }
        public void Add(Car car)
        {
            _cars.Add(car);

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

       

        public List<Car> GetById(Car car)
        {
            return _cars.Where(p => p.CarId == car.CarId).ToList();
        }

     

        public List<Car> GetById(int CarId)
        {
            throw new NotImplementedException();
        }

        public void Remove(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }



    }
}
