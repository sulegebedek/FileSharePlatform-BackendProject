using Core.Entities.Concrete;
using Core.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IResult Add(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetByMail(string email);
    }
}
