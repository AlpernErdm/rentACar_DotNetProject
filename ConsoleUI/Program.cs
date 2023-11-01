using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
           // Test();
     
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car();


            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine("Araç ID: " + car.CarId + "  - Araç Açıklama: " + car.Description + "  - Günlük Fiyat:" + car.DailyPrice);
            }

            carManager.Add(new Car
            {
                BrandId = 8,
                CarId = 7,
                ColorId = 6,
                DailyPrice = 5000,
                ModelYear = 2015,
                Description = "Aciklama"
            });

            Console.WriteLine("\nAraçların Hepsinin Listesi \n");

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine("Araç ID: " + car.CarId + "  - Araç Açıklama: " + car.Description + "  - Günlük Fiyat:" + car.DailyPrice);
            }

            carManager.Delete(new Car { CarId = 7 });

            Console.WriteLine("Seçilen araç satışı kaldırıldı \n");

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine("Araç ID: " + car.CarId + "  - Araç Açıklama: " + car.Description + "  - Günlük Fiyat:" + car.DailyPrice);
            }
      
          


        }
        private static void Test()
        {
            CarManager carManager1 = new CarManager(new EfCarDal());
            var result=carManager1.GetCarsByBrandId(2);
            Console.WriteLine(result);


        }
       
    }
}
