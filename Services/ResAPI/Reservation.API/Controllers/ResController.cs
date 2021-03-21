using Microsoft.AspNetCore.Mvc;
using Reservation.API.Infrastructure;
using Reservation.API.Models;

namespace Reservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResController : ControllerBase
    {
        private readonly IReservationService reservationService;

        public ResController(IReservationService reservationService)
        {
            this.reservationService = reservationService;
        }

        [HttpGet("{bookingNumber}")]
        public ReservationDTO Reservation(int bookingNumber)
        {
            return reservationService.GetReservation(bookingNumber);
        }
    }
}
