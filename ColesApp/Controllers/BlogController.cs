using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ColesApp.Data.DTOs;
using ColesApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ColesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly BlogService _service;

        public BlogController(BlogService service)
        {
            _service = service;
        }

        [HttpPost]
        public CreateBlogResponse CreateBlog(CreateBlogRequest request)
        {
          return  _service.CreateBlog(request);
        }
    }
}
