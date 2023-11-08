using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car> (_carDal.Get(p => p.CarId == id));
        }
        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime); //Bakım=maintenance
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarListed);
        }
        public IResult Add(Car car)
        {
            if (car.Description.Length < 2)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);                            //Result olsaydı eğer hem success hem message parametrelerini döndürmemiz gerekecekti
            return new SuccessResult(Messages.CarUpdated); //SuccessResult olduğu için baseden direk true geliyo ve sadece mesaj yazmamızı istiyo
        }

        public IDataResult<Car>GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.BrandId ==brandId),"Başarıyla listelendi");
        }

        public IDataResult<Car> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.ColorId == colorId),"Başarıyla listelendi");
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new Result(true, "Başarıyla silindi");
        }
    }
}
