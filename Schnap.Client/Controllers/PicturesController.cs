using Schnap.Client.Models;
using Schnap.Domain.Persistence.Abstract;
using System.Linq;
using System.Web.Mvc;

namespace Schnap.Client.Controllers
{
    public class PicturesController : Controller
    {
        private IPictureRepository picture_repository;

        public PicturesController(IPictureRepository picture_repository)
        {
            this.picture_repository = picture_repository;
        }

        public ActionResult List(int page=1)
        {
            int page_size = 3;

            // Move this out of the controller and into a 'Query' layer
            // Shouldn't have any notion of repositories in the controllers
            // Add tests to this kind of logic at the infrastructure layer with a combo of:
            // https://ludwigstuyck.wordpress.com/2013/03/05/a-reference-architecture-part-7/
            // https://msdn.microsoft.com/en-gb/data/dn314429.aspx
            // Need to also think about how/where to calculate the paging info/links. Straight from MVC book at the moment.
            // Love the idea of HTML Helpers though...
            var all_pictures = picture_repository.Get();

            var view_pictures = all_pictures
                            .OrderBy(p => p.id)
                            .Skip((page - 1) * page_size)
                            .Take(page_size)
                            ;

            var paging_info = new PagingInfo
            {
                current_page = page,
                items_per_page = page_size,
                total_items = all_pictures.Count()
            };

            var model = new PictureListViewModel
            {
                pictures = view_pictures,
                paging_info = paging_info
            };

            return View(model);
        }
    }
}