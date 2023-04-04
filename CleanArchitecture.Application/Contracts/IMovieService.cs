using CleanArchitecture.Domain;

namespace CleanArchitecture.Application.Contracts
{
    public interface IMovieService
    {
        Task<List<Movie>> GetAllMovies();

        Task<bool> CreateMovie(Movie movie);

    }
}
