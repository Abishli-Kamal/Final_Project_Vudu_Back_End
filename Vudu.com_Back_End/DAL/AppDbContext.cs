using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vudu.com_Back_End.Models;

namespace Vudu.com_Back_End.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {

        }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<MainOption> MainOptions { get; set; }
        public DbSet<SubOption> SubOptions { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Year> Years { get; set; }
        public DbSet<Studio> Studios { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Tomatometer> Tomatometers { get; set; }
        public DbSet<Filter> Filters { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieSubOption> MovieSubOptions { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<ActorMovie> ActorMovies { get; set; }
        public DbSet<MovieIndexOption> MovieIndexOptions { get; set; }
        public DbSet<IndexOption> IndexOptions { get; set; }
        public DbSet<Advertising> Advertisings { get; set; }
        public DbSet<SubOptionTitle> SubOptionTitles { get; set; }
        public DbSet<MovieSubOptionTitle> MovieSubOptionTitles { get; set; }
        public DbSet<MovieSubOptionSubTitle> MovieSubOptionSubTitles { get; set; }
        public DbSet<SubOptionSubTitle> SubOptionSubTitles { get; set; }
        public DbSet<SubOptionImage> SubOptionImages { get; set; }
        public DbSet<MovieSubOptionImage> MovieSubOptionImages { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
    }
}

