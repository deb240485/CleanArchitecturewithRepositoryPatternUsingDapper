using CleanArchitecture.Application.Contracts;
using CleanArchitecture.Domain;
using CleanArchitecture.Infrastructure.Context;
using CleanArchitecture.Infrastructure.Queries;
using Dapper;

namespace CleanArchitecture.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DapperContext _dapperContext;        
        public UserRepository(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }
        public async Task<bool> CreateUserAsync(User? user)
        {
            using (var connection = _dapperContext.CreateConnection())
            {
                connection.Open();
                var result = await connection.ExecuteAsync(UserQueries.AddUser, user);
                return result >= 0 ? true : false;
            }
        }

        public async Task<User?> GetUsersByNameAsync(string userName)
        {
            using (var connection = _dapperContext.CreateConnection())
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<User>(UserQueries.GetUsersByName, new { userName });
                return result;
            }
        }

        public async Task<bool> UserAlreadyExistsAsync(string userName)
        {
            using (var connection = _dapperContext.CreateConnection())
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<int>(UserQueries.UserNameAlreadyExists, new { userName });
                return result > 0 ? true : false;
            }
        }
    }
}
