using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sample_rms.Models;

namespace sample_rms.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public static List<Table> tables = new List<Table>{new Table
                {
                    Id = 1,
                    IsReserved = false,
                    Location = "Location 1",
                    NumberOfSittings = 3,
                },new Table
                {
                    Id = 2,
                    IsReserved = false,
                    Location = "Location 2",
                    NumberOfSittings = 3,
                },new Table
                {
                    Id = 3,
                    IsReserved = false,
                    Location = "Location 3",
                    NumberOfSittings = 2,
                 },new Table
                {
                    Id = 4,
                    IsReserved = false,
                    Location = "Location 4",
                    NumberOfSittings = 1,
                 },new Table
                {
                    Id = 5,
                    IsReserved = false,
                    Location = "Location 5",
                    NumberOfSittings = 4,
                 },new Table
                 {
                     Id = 6,
                     IsReserved = false,
                     Location = "Location 6",
                     NumberOfSittings = 1,
                  },new Table
                {
                    Id = 7,
                    IsReserved = false,
                    Location = "Location 7",
                    NumberOfSittings = 2,
                  },new Table
                {
                    Id = 8,
                    IsReserved = false,
                    Location = "Location 8",
                    NumberOfSittings = 4,
                },
            };
        public static List<ReservationViewModel> reservations = new List<ReservationViewModel>();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult DisplayReservations(int seating, string daterange)
        {
            var filteredResult = reservations.Join(tables, re => re.TableId, t => t.Id, (re, t) => new { re, t });
            if(seating > 0)
            {
                filteredResult = filteredResult.Where(x => x.t.NumberOfSittings == seating);
            }

            if (!string.IsNullOrEmpty(daterange))
            {
                List<string> dateRanges = daterange.Split('-').Select(x => x.Trim()).ToList();
                DateTime startDateTime = DateTime.ParseExact(dateRanges[0], "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture);
                DateTime endDateTime = DateTime.ParseExact(dateRanges[1], "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture);
                filteredResult = filteredResult.Where(x => x.re.Time <= endDateTime && x.re.Time >= startDateTime);
            }

            List<ReservationDataTableViewModel> viewModel = filteredResult.Select(x => 
            new ReservationDataTableViewModel
                {
                    ReservationId = x.re.ReservationId,
                    TableName = x.t.Location,
                    Size = x.t.NumberOfSittings,
                    Timing = x.re.Time.ToString()
                }
            ).ToList();


            return this.PartialView("_DisplayReservations", viewModel);
        }

        [HttpGet]
        public IActionResult Reservation()
        {
            ReservationViewModel viewModel = new ReservationViewModel
            {
                ReservationId = reservations.Count + 1,
                Time = DateTime.Now.Date
            };
            this.ViewBag.Tables = tables;
            return this.PartialView("_Reservation", viewModel);
        }

        [HttpPost]
        public IActionResult Reservation(ReservationViewModel model)
        {
            reservations.Add(model);
            return this.Json(new { Result = true });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

       
    }
}
