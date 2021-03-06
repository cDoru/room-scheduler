﻿using RSData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RSRepository
{
    public interface IEventRepository
    {
        List<Event> GetEvents();

        List<Event> GetEvents(DateTime startDate, DateTime endDate, int[] roomId, int[] hostId);

        List<Event> GetEvents(DateTime startDate, DateTime endDate, int[] roomId);

        List<Event> GetPastEventsByUser(DateTime date, int attendeeId, int roomId);

        List<Event> GetFutureEvents(DateTime date, int attendeeId, int roomId);

        List<Event> GetEventsByRoom(DateTime startDate, DateTime endDate, int roomId);

        List<Event> GetEventsByDay(DateTime date, int userId);

        List<Event> GetEventForEdit(DateTime startDate, DateTime endDate, int roomId, int attendee);

        Event GetEventById(int id);

        void AddEvent(Event _event);

        //void UpdateEvent(Event _event);
        //void DeleteEvent(int id);
    }
}
