using Core.Results.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISharedFileService
    {
        IDataResult<List<SharedFile>> GetAll();
        IDataResult<SharedFile> GetById(int id);
        IResult Add(IFormFile file, SharedFile sharedFile);
        IResult Update(IFormFile file, SharedFile sharedFile);
        IResult Delete(SharedFile sharedFile);
    }
}
