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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        IUserDal _userDal;
        public CustomerManager(ICustomerDal customerDal,IUserDal userdal)
        {
            _customerDal = customerDal;

        }
        public IResult AddCustomer(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.AddedCustomer);
        }

        public IResult DeleteCustomer(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.DeletedCustomer);
        }

        public IDataResult<List<Customer>> GetAllCustomers()
        {
            var customers = _customerDal.GetAll();
            return new SuccessDataResult<List<Customer>>(customers,Messages.ListedCustomers);
        }

        public IDataResult<Customer> GetCustomerById(int customerId)
        {
            var customer = _customerDal.Get(c => c.UserId == customerId);
            return new SuccessDataResult<Customer>(customer);
        }

        public IResult UpdateCustomer(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.UpdatedCustomer);
        }
    }
}
