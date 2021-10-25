using Application.Interfaces;
using Application.ViewModels;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Services
{
    public class BlogService : IBlogservice
    {
        private IBlogRepository blogRepo;
        
        public BlogService(IBlogRepository _blogRepo)
        {
            blogRepo = _blogRepo;
        }


        public void AddBlog(BlogCreationModel b)
        {
            
        }

        public IQueryable<BlogViewModel> GetBlogs()
        {
            var list = blogRepo.GetBlogs();

            List<BlogViewModel> myResults = new List<BlogViewModel>();

            foreach(var b in list) //this foreach loop is covering from List<Blog> to List<BlogViewModel>
            {
                myResults.Add(new BlogViewModel()
                {
                    Id = b.Id,
                    Category = b.Category,
                    DateUptaed = b.DateUpdated,
                    LogoImagePath = b.LogoImagePath,
                    Name = b.Name
                });
            }

            return myResults.AsQueryable();
        }
    }
}
