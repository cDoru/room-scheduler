﻿using RSData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSService.DTO
{
    public class EventDto
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int EventType { get; set; }
        public int RoomId { get; set; }
        public string Notes { get; set; }
        public int HostId { get; set; }
        public int AttendeeId { get; set; }
        public int EventStatus { get; set; }

        public string Host { get; set; }
        //public User Attendee { get; set; }
        //public Room Room { get; set; }
        //public ICollection<Penalty> Penalty { get; set; }
    }
}
