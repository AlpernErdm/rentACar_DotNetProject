using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

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

            Console.WriteLine("\n Araçların Hepsinin Listesi \n");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araç ID: " + car.CarId + "  - Araç Açıklama: " + car.Description + "  - Günlük Fiyat:" + car.DailyPrice);
            }

            carManager.Remove(new Car { CarId = 7 });

            Console.WriteLine("Seçilen araç satışı kaldırıldı \n");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araç ID: " + car.CarId + "  - Araç Açıklama: " + car.Description + "  - Günlük Fiyat:" + car.DailyPrice);
            }

        }
    }
}
