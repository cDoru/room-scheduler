﻿using System;
using System.Collections.Generic;

namespace RSData.Models
{
    public partial class TimeSlot :  BaseEntity
    {
        //public int TimeSlotId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Status { get; set; }
        public int RoomId { get; set; }
        public int HostId { get; set; }

        public User Host { get; set; }
        public Room Room { get; set; }
    }

    public enum TimeSlotEnum
    {
        available = 0,
        booked = 1,
        blocked = 2
    }
}
