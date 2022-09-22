using Blog_MVC.Models;
using Blog_MVC.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Blog_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //ViewData["Title"] = "Home Page from Index Action";
            //Post p = new Post();
            //p.Title = "First Post";
            //p.Content = "Description of First Post";
            //p.RegisterDate = DateTime.Now;
            //p.Id = 1;
            //var posts = new List<Post>()
            //{
            //    new Post
            //    {
            //        Title = "First Post",
            //        Content = "Description of First Post",
            //        RegisterDate = DateTime.Now,
            //        Id = 1
            //    },
            //    new Post
            //    {
            //        Title = "Second Post",
            //        Content = "Description of Second Post",
            //        RegisterDate = DateTime.Now,
            //        Id = 2
            //    }
            //};
            PostService pService = new PostService();
            return View(pService.GetAll());
        }

        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            if (ModelState.IsValid)
            {
                //return RedirectToAction("Index");
                return RedirectToAction("ContactResponse");
            }
            return View();
        }
        public IActionResult ContactResponse()
        {
            return Content("Successfull");
        }





    }
}