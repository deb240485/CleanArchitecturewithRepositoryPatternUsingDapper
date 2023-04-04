using CleanArchitecture.Domain;

namespace CleanArchitecture.Application.Contracts
{
    public interface IMovieRepository
    {
        Task<List<Movie>> GetAllMoviesAsync();
        Task<bool> CreateMovieAsync(Movie movie);
    }
}
