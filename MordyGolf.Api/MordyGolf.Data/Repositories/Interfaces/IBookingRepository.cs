using MordyGolf.DataContracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MordyGolf.Data.Repositories.Interfaces
{
    public interface IBookingRepository
    {
        /// <summary>
        /// Gets all active bookings for the given course id.
        /// </summary>
        /// <param name="courseId">The course id that the active bookings are being requested for</param>
        /// <returns>List of active bookings</returns>
        Task<List<Booking>> GetActiveBookingsForCourseId(int courseId);

        /// <summary>
        /// Adds a booking
        /// </summary>
        /// <param name="bookingContract">The booking contract to add</param>
        /// <returns>Guid - confirmation number of the newly added booking</returns>
        Task<Guid> AddBooking(BookingContract bookingContract);
    }
}
