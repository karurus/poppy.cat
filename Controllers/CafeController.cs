using System; 
using System.Collections.Generic; 
using System.Diagnostics; 
using System.Linq; 
using System.Threading.Tasks; 
using Microsoft.AspNetCore.Mvc; 
using Microsoft.AspNetCore.Authorization; 
using poppy.cat.Models; 

namespace poppy.cat.Controllers {
    
    public class CafeController:Controller {
        public ActionResult Cafe() {
            return View(); 
        }
        [Authorize] 
        public ActionResult CataholicCafe() {
            return View(); 
        }
    }
}