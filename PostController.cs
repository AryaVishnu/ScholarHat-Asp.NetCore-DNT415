using Microsoft.AspNetCore.Mvc;
using Module1.Models;

namespace Module1.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Post()
        {
            PostViewModel pvModel = new PostViewModel()
            {
                Id = 1,
                Title = "What is ASP.NET Core",
                Author = "Shailendra Chauhan",
                Body = "ASP.NET Core is an open-source framework for building UI and API..."
            };

            return View(pvModel);
        }
    }
}
