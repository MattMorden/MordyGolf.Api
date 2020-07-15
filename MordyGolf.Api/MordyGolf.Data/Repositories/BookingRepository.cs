using Microsoft.Extensions.Logging;
using MordyGolf.Data.DbContexts;
using MordyGolf.Data.Repositories.Interfaces;
using MordyGolf.DataContracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MordyGolf.Data.Repositories
{
    /// <inheritdoc />
    public class BookingRepository : IBookingRepository
    {
        private readonly ILogger<BookingRepository> _logger;
        private readonly MordyGolfContext _dbContext;

        /// <summary>
        /// Booking Repository constructor with dependencies.
        /// </summary>
        /// <param name="logger"></param>
        public BookingRepository(ILogger<BookingRepository> logger, MordyGolfContext dbContext)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        /// <inheritdoc />
        public async Task<Guid> AddBooking(BookingContract bookingContract)
        {
            // Temporary return
            return GetDummyGuid();

            // Todo: make repo call
        }
        private Guid GetDummyGuid() { return Guid.NewGuid(); }

        /// <inheritdoc />
        public async Task<List<Booking>> GetActiveBookingsForCourseId(int courseId)
        {
            // Temporary return
            return GetDummyBookings();

            // Todo: Make repo call
        }


        private List<Booking> GetDummyBookings()
        {
            return new List<Booking>
            {
                new Booking
                {
                    BookingDate = new DateTime{ },
                    BookingId = 1,
                    CourseId = 1,
                    Identifier = Guid.NewGuid(),
                    NumberOfCarts = 2,
                    NumberOfPlayers = 4,
                    UserId = 1
                }
            };
        }
    }
}
