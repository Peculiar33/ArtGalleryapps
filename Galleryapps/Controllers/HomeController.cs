using Galleryapps.Models.DB_Modles;
using Galleryapps.Models.View_Models;
using System;
using System.Web.Mvc;
using ArtistDetail = Galleryapps.Models.DB_Modles.ArtistDetail;

namespace Galleryapps.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Artist newArtist)
        {
            try
            {
                var db = new ADetailsModel();
                var art = new ArtistDetail();
                art.Fristname = newArtist.Firstname;
                art.Lastname = newArtist.Lastname;
                art.Address = newArtist.Address;
                art.RegDate = DateTime.UtcNow.AddHours(1);
                db.ArtistDetails.Add(art);
                db.SaveChanges();
                return RedirectToAction("SuccessfulReg");
            }
            catch (Exception Ex)
            {

                ViewBag.ErrorMessage = "An Error Occurred during Registration";

                return View();
            }

        }


        public ActionResult SuccessfulReg()
        {
            ViewBag.Message = "Your Registration was Successful.";

            return View();
        }

    }
}