using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Data.SqlClient;
using poppy.cat.Models;

namespace poppy.cat.Controllers
{

    public class CafeController : Controller
    {
        public ActionResult Cafe()
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
                cafe.Img = reader.GetString(reader.GetOrdinal("Img"));
                //cafe.Place = reader.GetString(reader.GetOrdinal("Place"));
                cafe.Page = reader.GetString(reader.GetOrdinal("Page"));
                catcafes.Add(cafe);
            }
            ViewBag.catcafes = catcafes;
            return View();
        }
    }
}