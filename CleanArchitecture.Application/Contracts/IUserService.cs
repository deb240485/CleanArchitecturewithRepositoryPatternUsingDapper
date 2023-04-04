using CleanArchitecture.Application.Dto;

namespace CleanArchitecture.Application.Contracts
{
    public interface IUserService
    {
        Task<UserDto?> Authenticate(string userName, string passwordText);
        Task<bool> Register(string userName, string password);
        Task<bool> UserAlreadyExists(string userName);

    }
}
