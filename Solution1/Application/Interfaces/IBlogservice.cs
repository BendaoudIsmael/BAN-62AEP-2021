using Application.ViewModels;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Interfaces
{
    public interface IBlogservice
    {
        public IQueryable<BlogViewModel> GetBlogs();

        public void AddBlog(BlogCreationModel b);
    }
}
