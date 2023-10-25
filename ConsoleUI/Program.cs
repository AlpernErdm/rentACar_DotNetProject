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
            //CarTest();

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            Car car1 = new Car();


            foreach (var car in carManager.GetAll())
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

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araç ID: " + car.CarId + "  - Araç Açıklama: " + car.Description + "  - Günlük Fiyat:" + car.DailyPrice);
            }

            carManager.Delete(new Car { CarId = 7 });

            Console.WriteLine("Seçilen araç satışı kaldırıldı \n");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araç ID: " + car.CarId + "  - Araç Açıklama: " + car.Description + "  - Günlük Fiyat:" + car.DailyPrice);
            }
            CarManager carManager1 = new CarManager(new EfCarDal());
            foreach (var product in carManager1.GetCarsByBrandId(2)) //CategoryId'sı 2 olanları getirir
            {
                Console.WriteLine(product.Description);
            }

            Console.WriteLine("**********************");
            foreach (var product1 in carManager1.GetCarsByColorId(1)) //Hepsini getirir
            {
                Console.WriteLine(product1.Description);


            }
          


        }
    }
}
