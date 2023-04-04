using CleanArchitecture.Domain;

namespace CleanArchitecture.Application.Contracts
{
    public interface IUserRepository
    {
        Task<User?> GetUsersByNameAsync(string userName);
        Task<bool> UserAlreadyExistsAsync(string userName);
        Task<bool> CreateUserAsync(User? user);
    }
}
