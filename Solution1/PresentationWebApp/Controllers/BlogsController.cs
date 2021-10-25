using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Services;
using Application.Interfaces;

namespace PresentationWebApp.Controllers
{
    public class BlogsController : Controller
    {
        private IBlogservice service;

        public BlogsController(IBlogservice _service)
            {
            service = _service;
            }


        public IActionResult Index()
        {
            var list = service.GetBlogs();
            return View();
        }
    }
}
