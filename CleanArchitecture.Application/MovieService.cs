using CleanArchitecture.Application.Contracts;
using CleanArchitecture.Domain;

namespace CleanArchitecture.Application
{
    public class MovieService : IMovieService
    {
        private readonly IUnitOfWork _unitOfWork;
        public MovieService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<bool> CreateMovie(Movie movie)
        {
            return await _unitOfWork._movieRepository.CreateMovieAsync(movie);
        }

        public async Task<List<Movie>> GetAllMovies()
        {
            return await _unitOfWork._movieRepository.GetAllMoviesAsync();
        }
    }
}
