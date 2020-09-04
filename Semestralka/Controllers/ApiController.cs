using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SemestralkaDataControl.EF;
using SemestralkaDataControl.Models;
using SemestralkaDataControl.Repo;
using Newtonsoft.Json;
using AutoMapper;

namespace Semestralka.Controllers
{
    [ApiController]
    [Produces("application/json")]
    public class ApiController : ControllerBase
    {
        private readonly RoomRepo _repo;

        public ApiController(RoomRepo repo)
        {
            _repo = repo;
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<RoomWithFreeTimes, RoomWithFreeTimes>();
            });
            
           
        }

        // GET: api/Rooms/31.03.2020
        [Route("api/Rooms/{date}")]
        [HttpGet("{date}")]
        public IEnumerable<RoomWithFreeTimes> GetRooms([FromRoute]string date)
        {
            string[] parsedString = date.Split('.');
            DateTime newDateTime = new DateTime(int.Parse(parsedString[2]), int.Parse(parsedString[1]), int.Parse(parsedString[0]));
            var something = _repo.GetAllForApi(newDateTime);
            return something;
        }

        // GET: api/Rooms/31.03.2020/0
        [Route("api/Rooms/{date}/{id}")]
        [HttpGet("{date}/{id}")]
        public RoomWithFreeTimes GetRoom([FromRoute]string date, int id)
        {
            string[] parsedString = date.Split('.');
            DateTime newDateTime = new DateTime(int.Parse(parsedString[2]), int.Parse(parsedString[1]), int.Parse(parsedString[0]));
            var something = _repo.GetRoomInfoForApi(newDateTime, id);
            return something;
        }
    }
}
