﻿using MordyGolf.DataContracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MordyGolf.Service.Interfaces
{
    /// <summary>
    /// Provides Access to Booking methods.
    /// </summary>
    public interface IBookingService
    {
        /// <summary>
        /// Gets all active bookings for the given course id.
        /// </summary>
        /// <param name="courseId">The course id to request active bookings for.</param>
        /// <returns>List of Active Bookings</returns>
        Task<List<Booking>> GetActiveBookingsForCourseId(int courseId);

        /// <summary>
        /// Adds a booking
        /// </summary>
        /// <param name="bookingContract">The booking contract to add</param>
        /// <returns>Guid - confirmation number of the booking</returns>
        Task<Guid> AddBooking(BookingContract bookingContract);
    }
}
