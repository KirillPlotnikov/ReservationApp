using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SemestralkaDataControl.EF;
using SemestralkaDataControl.Models;
using SemestralkaDataControl.Repo;

namespace Semestralka.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly ReservationRepo _repo;

        public ReservationsController(ReservationRepo repo)
        {
            _repo = repo;
        }




        // GET: Reservations/Create
        public IActionResult Create(string date, int? timeFrom, int? id)
        {
            if (Regex.IsMatch(date, @"^\d{4}/\d{2}/\d{2}$") && timeFrom != null && id != null)
            {
                string[] splittedDate = date.Split('/');
                DateTime newDate = new DateTime(int.Parse(splittedDate[0]), int.Parse(splittedDate[1]), int.Parse(splittedDate[2]), (int)timeFrom, 0, 0);
                ViewBag.Id = id;
                ViewBag.Date = newDate;
                return View();
            }
            else
            {
                return BadRequest();
            }
        }

        // POST: Reservations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("DateAndTime,ClientName,ClientSurname,ClientEmail,ClientPhone,Description,RoomId")] Reservation reservation)
        {
            if (ModelState.IsValid)
            {       
                if (!_repo.CheckIfExists(reservation.DateAndTime))
                {
                    _repo.Add(reservation);
                }
                else
                {
                    return RedirectToAction("Details", "Rooms", new { id = reservation.RoomId, error = 1 });
                }
                return RedirectToAction("Index", "Rooms");
            }
            

            return View(reservation);
        }

     

    }
}
