using System.Collections.Generic;
using Vudu.com_Back_End.Models;

namespace Vudu.com_Back_End.View_models
{
    public class HomeVM
    {
        public List<Setting> Settings { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<MainOption> MainOptions { get; set; }
        public List<SubOption> SubOptions { get; set; }
        public List<Filter> Filters { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Year> Years { get; set; }
        public List<Studio> Studios { get; set; }
        public List<Rating> Ratings { get; set; }
        public List<Tomatometer> Tomatometers { get; set; }
        public List<Movie> Movies { get; set; }
        public List<MovieSubOption> MovieSubOptions { get; set; }
        public List<MovieGenre> MovieGenres { get; set; }
        public List<Actor> Actors { get; set; }
        public List<ActorMovie> ActorMovies { get; set; }
        public List<IndexOption> IndexOptions { get; set; }
        public List<MovieIndexOption> MovieIndexOptions { get; set; }
        public List<Advertising> Advertisings { get; set; }
        public List<SubOptionTitle> SubOptionTitles { get; set; }
        public List<MovieSubOptionTitle> MovieSubOptionTitles { get; set; }
        public List<SubOptionSubTitle> SubOptionSubTitles { get; set; }
        public List<MovieSubOptionSubTitle> MovieSubOptionSubTitles { get; set; }
        public List<SubOptionImage> SubOptionImages { get; set; }
        public List<MovieSubOptionImage> MovieSubOptionImages { get; set; }
        public List<Trailer> Trailers { get; set; }
        public Movie Movie { get; set; }
        public AppUser AppUser { get; set; }
        public List<BasketItem> BasketItems { get; set; }
    }
}
