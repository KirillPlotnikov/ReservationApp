using SemestralkaDataControl.EF;
using SemestralkaDataControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SemestralkaDataControl.Repo
{
    public class ReservationRepo : BaseRepo<Reservation>
    {
        public ReservationRepo(ApplicationContext context) : base(context)
        {

        }

        public bool CheckIfExists(DateTime d)
        {
            bool exists = Context.Set<Reservation>().Local.Any(r => r.DateAndTime == d);
            return exists;
        }
    }
}
