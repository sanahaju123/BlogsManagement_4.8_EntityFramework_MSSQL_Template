using BlogsManagementApp.DAL.Interrfaces;
using BlogsManagementApp.DAL.Services.Repository;
using BlogsManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BlogsManagementApp.DAL.Services
{
    public class BlogsService : IBlogsService
    {
        private readonly IBlogsRepository _repository;

        public BlogsService(IBlogsRepository repository)
        {
            _repository = repository;
        }

        public Task<Blogs> CreateBlogs(Blogs expense)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<bool> DeleteBlogsById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Blogs> GetAllBlogss()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Blogs> GetBlogsById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Blogs> UpdateBlogs(Blogs model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}