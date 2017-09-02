using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using poppy.cat.Models;
using System.Data.SqlClient;

namespace poppy.cat.Controllers
{

    public class BookController : Controller
    {
        [Authorize]
        public ActionResult BookingSuccess()
        {
            ViewBag.User = User.Identity.Name;
            return View();
        }
        [Authorize]
        public ActionResult BookingPage(int id)
        {
            SqlConnection conn = new SqlConnection("Server=tcp:poppycat.database.windows.net,1433;Initial Catalog=PoppyCat;Persist Security Info=False;User ID=chikarurus;Password=Karunarat1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM CatCafe WHERE id=" + id, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            CatCafe cafe = new CatCafe();
            reader.Read();
            cafe.ID = reader.GetInt32(reader.GetOrdinal("ID"));
            cafe.Name = reader.GetString(reader.GetOrdinal("Name"));
            cafe.Price = reader.GetInt32(reader.GetOrdinal("Price"));
            cafe.RateStar = reader.GetInt32(reader.GetOrdinal("RateStar"));
            cafe.RateNum = reader.GetInt32(reader.GetOrdinal("RateNum"));
            cafe.Img = reader.GetString(reader.GetOrdinal("Img"));
            cafe.Place = reader.GetString(reader.GetOrdinal("Place"));
            cafe.Page = reader.GetString(reader.GetOrdinal("Page"));

            ViewBag.cafe = cafe;

            return View();
        }
    }
}