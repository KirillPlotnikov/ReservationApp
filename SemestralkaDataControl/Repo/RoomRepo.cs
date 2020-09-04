using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SemestralkaDataControl.EF;
using SemestralkaDataControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SemestralkaDataControl.Repo
{
    public class RoomRepo : BaseRepo<Room>
    {
        public RoomRepo(ApplicationContext context) : base(context)
        {
            
        }
        public RoomWithFreeTimes GetRoomInfoForApi(DateTime date, int id)
        {
            Room room = Context.Rooms.Find(id);
            List<int> ft = GetAllFreeTimes(date, id);
            return new RoomWithFreeTimes() { Name = room.Name, OpenedFrom = room.OpenedFrom, OpenedTo = room.OpenedTo, freeTimes = ft };
        }
        public List<RoomWithFreeTimes> GetAllForApi(DateTime date)
        {

            var something = from r in Context.Rooms select r;
            List<RoomWithFreeTimes> list = new List<RoomWithFreeTimes>();
            foreach(Room room in something)
            {
                list.Add(new RoomWithFreeTimes() { Name = room.Name, OpenedFrom = room.OpenedFrom, OpenedTo = room.OpenedTo, freeTimes = GetAllFreeTimes(date, room) });
            }
            return list;
        }
        public List<int> GetAllFreeTimes(DateTime date, Room room)
        {
         
            DateTime now = DateTime.Now;

            if (room != null)
            {
                Context.Entry(room).Collection(r => r.Reservations).Load();
            }


            List<int> timesForReservation = Enumerable.Range(room.OpenedFrom, room.OpenedTo - room.OpenedFrom).Select(x => x).ToList<int>();
            var reservedTimes = (from res in room.Reservations where res.DateAndTime.Year == date.Year && res.DateAndTime.Month == date.Month && res.DateAndTime.Day == date.Day select res.DateAndTime.Hour).ToList();

            if (date.Year <= now.Year && date.Month <= now.Month && date.Day <= now.Day)
            {
                for (int i = room.OpenedFrom; i <= now.Hour && i <= room.OpenedTo; i++)
                {
                    reservedTimes.Add(i);
                }
            }

            List<int> freeTimes = timesForReservation.Except(reservedTimes).ToList();

            return freeTimes;

        }
        public List<int> GetAllFreeTimes(DateTime date, int roomId)
        {
           Room room = Context.Rooms.Find(roomId);
            
           DateTime now =  DateTime.Now;

           if(room != null)
            {
                Context.Entry(room).Collection(r => r.Reservations).Load();
            }

           
                

            List<int> timesForReservation = Enumerable.Range(room.OpenedFrom, room.OpenedTo - room.OpenedFrom).Select(x => x).ToList<int>();
            var reservedTimes = (from res in room.Reservations where res.DateAndTime.Year == date.Year && res.DateAndTime.Month == date.Month && res.DateAndTime.Day == date.Day select res.DateAndTime.Hour).ToList();

            if (date.Year <= now.Year && date.Month <= now.Month && date.Day <= now.Day)
            {
                for(int i = room.OpenedFrom; i <= now.Hour && i<=room.OpenedTo; i++)
                {
                    reservedTimes.Add(i);
                }
            }

            List<int> freeTimes = timesForReservation.Except(reservedTimes).ToList();

            return freeTimes;

        }
    }
}
