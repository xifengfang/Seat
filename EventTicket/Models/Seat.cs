using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventTicket.Models
{
    public class Seat
    {
        public bool available { get; set; }
        public bool aisle { get; set; }
        public SeatType type { get; set; }
    }
}