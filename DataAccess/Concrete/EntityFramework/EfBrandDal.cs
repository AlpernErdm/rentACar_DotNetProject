using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    class EfBrandDal : EfEntityRepositoryBase<Brand, ReCapProjectDbContext>, IBrandDal
    {
       
    }
}
