using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MordyGolf.DataContracts;
using MordyGolf.Service.Interfaces;

namespace MordyGolf.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly ILogger<BookingController> _logger;
        private readonly IBookingService _bookingService;

        public BookingController(ILogger<BookingController> logger, IBookingService bookingService)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _bookingService = bookingService ?? throw new ArgumentNullException(nameof(bookingService));
        }

        [HttpGet]
        public async Task<IActionResult> GetActiveBookingsForCourse(int courseId)
        {
            if (courseId <= 0)
                return BadRequest("Invalid Course ID provided.");

            var bookings = await _bookingService.GetActiveBookingsForCourseId(courseId);

            if (bookings == null)
                return NotFound();

            return Ok(bookings);
        }
    }
}