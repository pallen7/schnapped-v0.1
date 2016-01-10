using Schnap.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

        public ActionResult List()
        {
            return View(picture_repository.pictures);
        }
    }
}