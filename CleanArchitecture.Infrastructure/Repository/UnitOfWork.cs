using CleanArchitecture.Application.Contracts;
using CleanArchitecture.Infrastructure.Context;

namespace CleanArchitecture.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DapperContext _dapperContext;
        public UnitOfWork(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }
        public IMovieRepository _movieRepository => new MovieRepository(_dapperContext);

        public IUserRepository _userRepository => new UserRepository(_dapperContext);
    }
}
