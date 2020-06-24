﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MordyGolf.DataContracts;

namespace MordyGolf.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;

        /// <summary>
        /// User Controller with dependencies
        /// </summary>
        /// <param name="logger">ILogger dependency</param>
        public UserController(ILogger<UserController> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public IActionResult GetUserByUsername(string username)
        {
            return Ok();
        }
    }
}
