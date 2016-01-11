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
            int page_size = 4;

            // Move this out of the controller and into a 'Query' layer
            // Shouldn't have any notion of repositories in the controllers
            // Add tests to this kind of logic at the infrastructure layer with a combo of:
            // https://ludwigstuyck.wordpress.com/2013/03/05/a-reference-architecture-part-7/
            // https://msdn.microsoft.com/en-gb/data/dn314429.aspx
            var all_pictures = picture_repository.Get();

            var view_pictures = all_pictures
                            .OrderBy(p => p.id)
                            .Skip((page - 1) * page_size)
                            .Take(page_size)
                            ;

            return View(picture_repository.Get());
        }
    }
}