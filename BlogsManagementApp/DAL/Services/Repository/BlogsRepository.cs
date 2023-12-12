using BlogsManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BlogsManagementApp.DAL.Services.Repository
{
    public class BlogsRepository : IBlogsRepository
    {
        private readonly DatabaseContext _dbContext;
        public BlogsRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Blogs> CreateBlogs(Blogs expense)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteBlogsById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Blogs> GetAllBlogss()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Blogs> GetBlogsById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

      
        

        public async Task<Blogs> UpdateBlogs(Blogs model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}