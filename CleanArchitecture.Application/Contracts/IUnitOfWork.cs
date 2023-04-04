using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts
{
    public interface IUnitOfWork
    {
        IMovieRepository _movieRepository { get; }
        IUserRepository _userRepository { get; }
    }
}
