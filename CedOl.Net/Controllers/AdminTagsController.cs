using CedOl.Net.Data;
using CedOl.Net.Models.Domain;
using CedOl.Net.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CedOl.Net.Controllers
{
    public class AdminTagsController : Controller
    {
        private readonly CedOlDbContext cedOlDbContext;

        public AdminTagsController(CedOlDbContext cedOlDbContext) {
            this.cedOlDbContext = cedOlDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Add")]
        public IActionResult SubmitTag(AddTagRequest addTagRequest)
        {
            // Mapping AddTagRequest to Tag domain model
            var tag = new Tag
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName,
            };
            
            cedOlDbContext.Tags.Add(tag);
            cedOlDbContext.SaveChanges();
            return View("Add");
        }
    }
}
