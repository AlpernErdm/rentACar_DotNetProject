using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.AddedBrand);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            var result = _brandDal.GetAll();
            if (result.Count>0)
            {
                return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
            }
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.NoDataInList);
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            var result = _brandDal.Get(p => p.BrandId == brandId);
            if (result !=null)
            {
                return new SuccessDataResult<Brand>(result);
            }
            return new SuccessDataResult<Brand>(result, Messages.NoDataOnFilter);
        }

        public IResult Remove(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult();
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult();
        }
    }
}
