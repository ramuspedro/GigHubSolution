using System.Linq;
using System.Web.Mvc;
using GigHubProject.Models;
using GigHubProject.ViewModels;

namespace GigHubProject.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;
        
        public GigsController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Create()
        {
            var ViewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };
            
            return View(ViewModel);
        }
    }
}