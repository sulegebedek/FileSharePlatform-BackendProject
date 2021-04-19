using Business.Abstract;
using Business.Constants;
using Core.Results.Abstract;
using Core.Results.Concrete;
using Core.Utilities.Business;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SharedFileManager : ISharedFileService
    {
        ISharedFileDal _sharedFileDal;

        public SharedFileManager(ISharedFileDal sharedFileDal)
        {
            _sharedFileDal = sharedFileDal;
        }

        public IResult Add(IFormFile file, SharedFile sharedFile)
        {
            
            _sharedFileDal.Add(sharedFile);
            return new SuccessResult(Messages.AddFile);
        }

        public IResult Delete(SharedFile sharedFile)
        {
            _sharedFileDal.Delete(sharedFile);
            return new SuccessResult(Messages.DeleteFile);
        }

        public IDataResult<List<SharedFile>> GetAll()
        {
            return new SuccessDataResult<List<SharedFile>>(_sharedFileDal.GetAll());
        }

        public IDataResult<SharedFile> GetById(int id)
        {
            return new SuccessDataResult<SharedFile>(_sharedFileDal.Get(f => f.Id == id));
        }

        public IResult Update(IFormFile file, SharedFile sharedFile)
        {
            _sharedFileDal.Update(sharedFile);
            return new SuccessResult(Messages.DeleteFile);
        }
    }
}
