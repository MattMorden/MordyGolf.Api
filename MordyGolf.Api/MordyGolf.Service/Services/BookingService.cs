using Microsoft.Extensions.Logging;
using MordyGolf.Data.Repositories.Interfaces;
using MordyGolf.DataContracts;
using MordyGolf.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MordyGolf.Service.Services
{
    /// <inheritdoc />
    public class BookingService : IBookingService
    {
        private readonly ILogger<BookingService> _logger;
        private readonly IBookingRepository _bookingRepository;
        
        /// <summary>
        /// Constructor for BookingService with dependencies.
        /// </summary>
        /// <param name="logger">Logger dependency</param>
        /// <param name="bookingRepository">Booking Repository dependency</param>
        public BookingService(ILogger<BookingService> logger, IBookingRepository bookingRepository)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _bookingRepository = bookingRepository ?? throw new ArgumentNullException(nameof(bookingRepository));
        }

        /// <inheritdoc />
        public async Task<List<Booking>> GetActiveBookingsForCourseId(int courseId)
        {
            var bookings = await _bookingRepository.GetActiveBookingsForCourseId(courseId);

            return bookings;
        }
    }
}
