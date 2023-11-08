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
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.AddedUser);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.RemovedUser);
        }

        public IDataResult<List<User>> GetAll()
        {
            var users = _userDal.GetAll();
            return new SuccessDataResult<List<User>>(users,Messages.ListedUsers);
        }

        public IDataResult<User> GetById(int userId)
        {
            var user = _userDal.Get(c => c.UserId == userId);
            return new SuccessDataResult<User>(user);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.UpdatedRental);
        }
    }
}
