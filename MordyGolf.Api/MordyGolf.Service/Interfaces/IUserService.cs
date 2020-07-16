using MordyGolf.DataContracts;
using System.Threading.Tasks;

namespace MordyGolf.Service.Interfaces
{
    public interface IUserService
    {
        /// <summary>
        /// Creates a User for the given request contract
        /// </summary>
        /// <param name="createUserContract">The Create User Contract containing all of the data for the user to create</param>
        /// <returns>User</returns>
        Task<User> CreateUser(CreateUserContract createUserContract);
    }
}
