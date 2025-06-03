using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ScooterRent.Models;

public class RentalController : Controller
{
    private static List<Rental> Rentals = new List<Rental>();

    public IActionResult Create(int scooterId)
    {
        var rental = new Rental
        {
            Id = Rentals.Count + 1,
            ScooterId = scooterId,
            UserId = "User123", // Example user, ideally from authentication
            StartTime = DateTime.Now,
            EndTime = DateTime.Now.AddHours(1) // 1-hour rental by default
        };

        Rentals.Add(rental);
        return RedirectToAction("Index", "Scooter");
    }
}