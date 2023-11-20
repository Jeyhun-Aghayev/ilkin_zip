

namespace ilkin_zip.Controllers
{    
    public class HomeController : Controller
    {
        AppDbContext _context;
        public HomeController(AppDbContext context)
        {
             _context = context;
        }
        public IActionResult Index()
        {
            List<Food> foods;
            foods = _context.foods.ToList();
            List<Image> images;
            images=_context.images.ToList();
            HomeVM vm = new HomeVM()
            {
                Foods=foods,
                Images=images,
            };

            return View(vm);
        }
    }
}
