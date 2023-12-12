using BlogsManagement.Models;
using BlogsManagementApp.DAL.Interrfaces;
using BlogsManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace BlogsManagementApp.Controllers
{
    public class BlogsController : ApiController
    {
        private readonly IBlogsService _service;
        public BlogsController(IBlogsService service)
        {
            _service = service;
        }
        public BlogsController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Blogs/CreateBlogs")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateBlogs([FromBody] Blogs model)
        {
           //write your code here
           throw new NotImplementedException();
        }


        [HttpPut]
        [Route("api/Blogs/UpdateBlogs")]
        public async Task<IHttpActionResult> UpdateBlogs([FromBody] Blogs model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpDelete]
        [Route("api/Blogs/DeleteBlogs")]
        public async Task<IHttpActionResult> DeleteBlogs(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Blogs/GetBlogsById")]
        public async Task<IHttpActionResult> GetBlogsById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Blogs/GetAllBlogss")]
        public async Task<IEnumerable<Blogs>> GetAllBlogss()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
