using EventTicket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventTicket.Services
{
    public interface ISeatService
    {
        int GetSeatCount(bool aisle, SeatType type);
        int GetAvailableSeatCount();
    }
}