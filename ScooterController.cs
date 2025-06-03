g System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ScooterRent.Models;


namespace ScooterRent.Controllers
{
    public class ScooterController : Controller
    {
        private static List<Scooter> Scooters = new List<Scooter>
        {
            new Scooter { Id = 1, Model = "Scooter A", PricePerHour = 5, IsAvailable = true },
            new Scooter { Id = 2, Model = "Scooter B", PricePerHour = 6, IsAvailable = true }
        };

        public IActionResult Index()
        {
            return View(Scooters.Where(s => s.IsAvailable));
        }
    }
}
