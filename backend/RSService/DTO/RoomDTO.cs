﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSService.DTO
{
    public class RoomDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public bool? IsActive { get; set; }
    }
}
