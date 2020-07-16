using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MordyGolf.Data.DbContexts;
using MordyGolf.Data.Repositories.Interfaces;
using MordyGolf.DataContracts;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading.Tasks;

namespace MordyGolf.Data.Repositories
{
    ///<inheritdoc />
    public class UserRepository : IUserRepository
    {
        private readonly ILogger<UserRepository> _logger;
        private readonly MordyGolfContext _dbContext;
        private readonly DbConnection _dbConnection;

        /// <summary>
        /// User Repository Constructor with dependencies
        /// </summary>
        /// <param name="logger">Logger dependency</param>
        /// <param name="dbContext">dbContext dependency</param>
        public UserRepository(ILogger<UserRepository> logger, MordyGolfContext dbContext)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _dbConnection = _dbContext.Database.GetDbConnection();
        }

        ///<inheritdoc />
        public Task<User> CreateUser(CreateUserContract createUserContract)
        {
            throw new NotImplementedException();
        }
    }
}
