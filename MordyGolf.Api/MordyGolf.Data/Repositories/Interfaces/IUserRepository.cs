using MordyGolf.DataContracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MordyGolf.Data.Repositories.Interfaces
{
    /// <summary>
    /// Provides access to the UserMethods which interact with the database
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Creates a user for the given CreateUserContract
        /// </summary>
        /// <param name="createUserContract">The CreateUserContract to create the user for</param>
        /// <returns>User</returns>
        Task<User> CreateUser(CreateUserContract createUserContract);
    }
}
