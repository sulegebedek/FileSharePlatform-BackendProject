using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SharedFilesController : ControllerBase
    {
        ISharedFileService _sharedFilesService;
        IWebHostEnvironment _webHostEnvironment;

        public SharedFilesController(ISharedFileService sharedFilesService, IWebHostEnvironment webHostEnvironment)
        {
            _sharedFilesService = sharedFilesService;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _sharedFilesService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _sharedFilesService.GetById(id);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = ("File"))] IFormFile file, [FromForm] SharedFile sharedFile)
        {
            var result = _sharedFilesService.Add(file, sharedFile);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult GetByCarId([FromForm(Name = ("File"))] IFormFile file, [FromForm] SharedFile sharedFile)
        {
            var result = _sharedFilesService.Update(file, sharedFile);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete([FromForm(Name = ("ImageId"))] int id)
        {
            var files = _sharedFilesService.GetById(id).Data;
            var result = _sharedFilesService.Delete(files);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
