using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetReservation(int bookingNumber)
        {
            return new ReservationDTO()
            {
                BookingDate = DateTime.Now.AddDays(-2),
                BookingNumber = bookingNumber,
                Id = new Random().Next(100),
                Amount = new Random().Next(10000),
                CheckinDate = DateTime.Now,
                CheckoutDate = DateTime.Now.AddDays(2)
            };
        }
    }
}
