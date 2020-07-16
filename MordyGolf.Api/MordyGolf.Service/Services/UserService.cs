using Microsoft.Extensions.Logging;
using MordyGolf.DataContracts;
using MordyGolf.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MordyGolf.Service.Services
{
    /// <inheritdoc />
    public class UserService : IUserService
    {
        private ILogger<UserService> _logger;
        private readonly IUserRepository _userRepository;

        /// <summary>
        /// Constructor for UserService with dependencies
        /// </summary>
        /// <param name="logger">Logger dependency</param>
        /// <param name="userRepository">User Repository dependency</param>
        public UserService(ILogger<UserService> logger, IUserRepository userRepository)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }

        /// <inheritdoc />
        public async Task<User> CreateUser(CreateUserContract createUserContract)
        {
            var user = await _userRepository.CreateUser(createUserContract);
        }
    }
}
