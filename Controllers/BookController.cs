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

    public class BookController : Controller
    {
        public ActionResult BookingSuccess()
        {
            return View();
        }
    }
}