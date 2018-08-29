using EventTicket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventTicket.Services
{
    public class SeatService : ISeatService
    {
        private List<Seat> _seats;
        public SeatService() {
            _seats = new List<Seat>() {
                new Seat { available = true, aisle = false, type = SeatType.adult },
                new Seat { available = true, aisle = false, type = SeatType.child },
                new Seat { available = true, aisle = true, type = SeatType.child },
                new Seat { available = true, aisle = false, type = SeatType.adult },
                new Seat { available = false, aisle = true, type = SeatType.adult },
                new Seat { available = false, aisle = false, type = SeatType.adult },
                new Seat { available = true, aisle = false, type = SeatType.adult },
                new Seat { available = true, aisle = false, type = SeatType.adult }
            };
        }
        public int GetSeatCount(bool aisle, SeatType type) {
            return _seats.Where(seat => seat.aisle == aisle && seat.type == type).Count();
        }
        public int GetAvailableSeatCount()
        {
            return _seats.Where(seat => seat.available).Count();
        }
    }
}