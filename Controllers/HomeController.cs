using Microsoft.AspNetCore.Mvc;
using poppy.cat.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;

namespace poppy.cat.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index1()
        {
            SqlConnection conn = new SqlConnection("Server=tcp:poppycat.database.windows.net,1433;Initial Catalog=PoppyCat;Persist Security Info=False;User ID=chikarurus;Password=Karunarat1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM CatCafe", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<CatCafe> catcafes = new List<CatCafe>();
            while (reader.Read())
            {
                CatCafe cafe = new CatCafe();
                cafe.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                cafe.Name = reader.GetString(reader.GetOrdinal("Name"));
                cafe.Price = reader.GetInt32(reader.GetOrdinal("Price"));
                cafe.RateStar = reader.GetInt32(reader.GetOrdinal("RateStar"));
                cafe.RateNum = reader.GetInt32(reader.GetOrdinal("RateNum"));
                //cafe.Img = reader.GetString(reader.GetOrdinal("Img"));
                //cafe.Place = reader.GetString(reader.GetOrdinal("Place"));
                catcafes.Add(cafe);
            }
            ViewBag.catcafes = catcafes;
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
