using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MordyGolf.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ILogger<CourseController> _logger;

        /// <summary>
        /// Course Controller constructor with dependencies.
        /// </summary>
        /// <param name="logger">ILogger dependency</param>
        public CourseController(ILogger<CourseController> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public IActionResult GetCourses()
        {
            return Ok();
        }
    }
}