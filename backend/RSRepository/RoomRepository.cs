﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using RSData.Models;
using System.Linq;

namespace RSRepository
{
    public class RoomRepository : IRoomRepository
    {
        private RoomPlannerDevContext context;
        private DbSet<Room> rooms;

        public RoomRepository(RoomPlannerDevContext context)
        {
            this.context = context;
            rooms = context.Set<Room>();
        }

        public List<Room> GetRooms()
        {
            return rooms.ToList();
        }

        public List<Room> GetRoomsByStatus(bool isActive)
        {
            return rooms.Where(r => r.IsActive == isActive)
                        .ToList();
        }

        public Room GetRoomById(int id)
        {
            return rooms.FirstOrDefault(s => s.Id == id);
        }

        public Room GetRoomByNameAndLocation(String name,String location)
        {
            return rooms.FirstOrDefault(s => (s.Name == name && s.Location == location));
        }

        public void AddRoom(Room room)
        {
            if (room == null)
            {
                throw new ArgumentNullException("Add a null room");
            }
            rooms.Add(room);
            context.SaveChanges();
        }

        public void UpdateRoom(Room room)
        {
            if (room == null)
            {
                throw new ArgumentNullException("Update a null room");
            }
            context.SaveChanges();
        }

        public void DeleteRoom(Room room)
        {
            if (room == null)
            {
                throw new ArgumentNullException("Cannot delete a null room");
            }
            rooms.Remove(room);
            context.SaveChanges();
        }

       

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        
    }
}
