﻿using Business.Abstract;
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
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.AddedRental);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RemovedRental);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            var rentals = _rentalDal.GetAll();
            return new SuccessDataResult<List<Rental>>(rentals);
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
         
           
            var res = _rentalDal.Get(p => p.RentalId == rentalId);
            if (rentalId<0)
            {
                new ErrorResult(Messages.InvalıdRentalId);
            }
            return new SuccessDataResult<Rental>(res, Messages.FilteredRental);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.UpdatedRental);
        }
    }
}
