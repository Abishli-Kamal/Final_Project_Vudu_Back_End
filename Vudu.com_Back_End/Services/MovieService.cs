using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vudu.com_Back_End.DAL;
using Vudu.com_Back_End.Models;

namespace Vudu.com_Back_End.Services
{
    public class MovieService
    {
        private readonly AppDbContext _context;

        public MovieService(AppDbContext context)
        {
            _context=context;
        }
        public List<MovieGenre> MovieFilter(int? genreId)
        {
            IQueryable<MovieGenre> movies = _context.MovieGenres.AsQueryable();
            if (genreId.HasValue)
            {
                movies=movies.Where(m => m.GenreId==genreId);
              
            }
            return movies.ToList();
        }
        public List<Movie> MovieFilterYear(int? yearId)
        {
            IQueryable<Movie> movie = _context.Movies.AsQueryable();
            if (yearId.HasValue)
            {
                movie=movie.Where(m => m.YearId==yearId);

            }
            return movie.ToList();
        }
    }
}
