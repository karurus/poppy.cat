using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using poppy.cat.Models;

namespace poppy.cat.Controllers
{

    public class CafeController : Controller
    {
        public ActionResult Cafe()
        {
            return View();
        }
        public ActionResult Book()
        {
            return View();
        }
        [Authorize]
        public ActionResult CatcareThailand()
        {
            return View();
        }
        [Authorize]
        public ActionResult CatStation()
        {
            return View();
        }
        [Authorize]
        public ActionResult CatHoteru()
        {
            return View();
        }
        [Authorize]
        public ActionResult SkyPetShop()
        {
            return View();
        }
        [Authorize]
        public ActionResult JoyuCatHotel()
        {
            return View();
        }
        [Authorize]
        public ActionResult CasadeCat()
        {
            return View();
        }
        [Authorize]
        public ActionResult CataholicCafe()
        {
            return View();
        }
        [Authorize]
        public ActionResult CaturdayCatCafe()
        {
            return View();
        }
        [Authorize]
        public ActionResult NeverlandTrueLoveCafe()
        {
            return View();
        }
        [Authorize]
        public ActionResult PurrCatCafeClub()
        {
            return View();
        }
        [Authorize]
        public ActionResult CatCafebyDome()
        {
            return View();
        }
        [Authorize]
        public ActionResult KittyCatCafe()
        {
            return View();
        }
        [Authorize]
        public ActionResult CarameowCatCafe()
        {
            return View();
        }
        [Authorize]
        public ActionResult ChicoDesignBangkok()
        {
            return View();
        }
        [Authorize]
        public ActionResult MakuraCatCafe()
        {
            return View();
        }
    }
}