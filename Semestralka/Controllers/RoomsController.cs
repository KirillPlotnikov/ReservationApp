using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SemestralkaDataControl.EF;
using SemestralkaDataControl.Models;
using SemestralkaDataControl.Repo;

namespace Semestralka.Controllers
{
    public class RoomsController : Controller
    {
        private readonly RoomRepo _repo;

        public RoomsController(RoomRepo repo)
        {
            _repo = repo;
        }

        // GET: Rooms
        public ViewResult Index(int? error)
        {
           
            return View(_repo.GetAll());
        }
        [HttpPost]
        public ActionResult GetFreeReservationTimes(string date, int id)
        {
            List<int> freeTimes = null;
            if (ModelState.IsValid)
            {
                string[] dateSplitted = date.Split('-');
                
                freeTimes = _repo.GetAllFreeTimes(new DateTime(int.Parse(dateSplitted[0]), int.Parse(dateSplitted[1]), int.Parse(dateSplitted[2])), id);
            }
            return new JsonResult(freeTimes);
        }
        // GET: Rooms/Details/5
        public IActionResult Details(int? id, int? error)
        {
            if (id == null)
            {
                return NotFound();
            }
            var room = _repo.GetOne(id);
            if (room == null)
            {
                return NotFound();
            }
            if (error != null && error == 1)
            {
                ViewBag.Error = true;
            }
            return View(room);
        }


        private bool RoomExists(int id)
        {
            return _repo.GetOne(id) == null ? false : true;
        }
    }
}
