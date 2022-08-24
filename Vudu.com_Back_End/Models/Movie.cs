using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vudu.com_Back_End.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public int RottenTomatoes { get; set; }
        public string BackImage { get; set; }
        public string Name { get; set; }
        public string Length { get; set; }
        public string Age { get; set; }
        public string InfoMovie { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }
        public int? MainOptionId { get; set; }
        public MainOption MainOption { get; set; }
        public List<MovieGenre> MovieGenres { get; set; }
        public List<ActorMovie> ActorMovies { get; set; }
        public List<MovieIndexOption> MovieIndexOptions { get; set; }
        public List<Trailer> Trailers { get; set; }
        public int? YearId { get; set; }
        public Year Year { get; set; }
        public int? RatingId { get; set; }
        public Rating Rating { get; set; }
        public int? StudioId { get; set; }
        public Studio Studio { get; set; }
        public int? TomatometerId { get; set; }
        public Tomatometer Tomatometer { get; set; }
        public List<MovieSubOptionTitle> MovieSubOptionTitles { get; set; }
        public List<MovieSubOptionSubTitle> MovieSubOptionSubTitles { get; set; }
        public List<MovieSubOptionImage> MovieSubOptionImages { get; set; }

        [NotMapped]
        public List<int> ActorIds { get; set; }
        [NotMapped]
        public List<int> GenreIds { get; set; }
        [NotMapped]
        public List<int> SubOptionImageIds { get; set; }
        [NotMapped]
        public List<int> SubOptionTitleIds { get; set; }
        [NotMapped]
        public List<int> SubOptionSubTitleIds { get; set; }
        [NotMapped]
        public List<int> IndexOptionIds { get; set; }
        [NotMapped]
        public IFormFile MainImage { get; set; }
        [NotMapped]
        public IFormFile BackgroundImage { get; set; }  
    }
}
