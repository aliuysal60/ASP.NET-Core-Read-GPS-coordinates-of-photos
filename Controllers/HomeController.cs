using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ExifLib;
using Microsoft.AspNetCore.Mvc;
using ReadGPSData.Models;

namespace ReadGPSData.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new PhotoCoordinatesModel();
            try
            {
                using (var reader = new ExifReader("20190111_172310.jpg"))
                {
                    model.Lat = reader.GetLatitude();
                    model.Lon = reader.GetLongitude();
                    ViewBag.Lat = model.Lat;
                    ViewBag.Lon = model.Lon;
                }
            }
            catch (ExifLibException exifex)
            {
                model.Error = exifex.Message;
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
