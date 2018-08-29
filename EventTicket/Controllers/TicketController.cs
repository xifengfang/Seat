using EventTicket.Models;
using EventTicket.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace EventTicket.Controllers
{
    public class TicketController : ApiController
    {
        private SeatService _seatService;
        public TicketController() {
            _seatService = new SeatService();
        }

        [Route("ticket/availablecount")]
        [HttpGet]
        public IHttpActionResult GetAvailableAcount()
        {
            return Ok(_seatService.GetAvailableSeatCount());
        }

        [Route("ticket/count")]
        [HttpGet]
        public IHttpActionResult GetCount(bool aisle, SeatType type)
        {
            return Ok(_seatService.GetSeatCount(aisle, type));
        }
    }
}
