using CleanArchitecture.Application.Contracts;
using CleanArchitecture.Domain;
using CleanArchitecture.Infrastructure.Context;
using CleanArchitecture.Infrastructure.Queries;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CleanArchitecture.Infrastructure.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly DapperContext _dapperContext;

        public MovieRepository(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task<bool> CreateMovieAsync(Movie movie)
        {
            using (var connection = _dapperContext.CreateConnection())
            {
                connection.Open();
                var result = await connection.ExecuteAsync(MovieQueries.AddMovie, movie);
                return result >= 0;
            }
        }

        public async Task<List<Movie>> GetAllMoviesAsync()
        {
            using (var connection = _dapperContext.CreateConnection())
            {
                connection.Open();
                var result = await connection.QueryAsync<Movie>(MovieQueries.Allmovies);
                return result.ToList();
            }
        }
    }
}
