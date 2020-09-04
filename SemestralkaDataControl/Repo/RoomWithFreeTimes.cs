using System;
using System.Collections.Generic;
using System.Text;

namespace SemestralkaDataControl.Repo
{
    public class RoomWithFreeTimes
    {
        public string Name { get; set; }
        public int OpenedFrom { get; set; }
        public int OpenedTo { get; set; }
        public List<int> freeTimes { get; set; }
    }
}
