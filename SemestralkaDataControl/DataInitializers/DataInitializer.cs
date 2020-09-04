using Microsoft.EntityFrameworkCore;
using SemestralkaDataControl.EF;
using SemestralkaDataControl.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SemestralkaDataControl.DataInitializers
{
    public static class DataInitializer
    {
        public static void InitializeData(ApplicationContext context)
        {
            var rooms = new List<Room>
            {
                new Room { Name = "Agent's 007 room", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec molestie molestie quam quis convallis. Nulla eu nulla vitae tortor egestas tempor at eu dui. Vestibulum cursus arcu id eros condimentum condimentum.", OpenedFrom=10, OpenedTo=20},
                new Room {Name="Magic room", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec molestie molestie quam quis convallis. Nulla eu nulla vitae tortor egestas tempor at eu dui. Vestibulum cursus arcu id eros condimentum condimentum. Sed ut nisl finibus, sollicitudin lectus sit amet, blandit nibh. Pellentesque interdum metus at tincidunt tristique. Fusce mollis placerat blandit. Donec pretium venenatis justo, eu aliquam justo ornare nec. Phasellus lobortis nisl sapien, ac rhoncus libero ornare sed.", OpenedFrom=8, OpenedTo=14},
                new Room{Name="Wash your hands room", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit.", OpenedFrom=0, OpenedTo=23}
            };
            context.Rooms.AddRange(rooms);

            var reservations = new List<Reservation>
            {
                new Reservation{ClientName="Vasek", ClientSurname="Novak", ClientPhone="+420 007 775 421", ClientEmail="vasek.novak@gmail.com", DateAndTime=new DateTime(2020,3,31,14,0,0), Room=rooms[0] },
                new Reservation{ClientName="Josef", ClientSurname="Starak", ClientPhone="+420 774 241 543", ClientEmail="tajnymail@example.com", DateAndTime=new DateTime(2020,3,31,16,0,0), Room=rooms[0], Description="Nulla eu nulla vitae tortor egestas tempor at eu dui."}
            };
            context.Reservations.AddRange(reservations);

            context.SaveChanges();
        }

        public static void RecreateDatabase(ApplicationContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.Migrate();
        }
    }
}
