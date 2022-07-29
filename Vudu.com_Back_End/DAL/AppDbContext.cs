using Microsoft.EntityFrameworkCore;
using Vudu.com_Back_End.Models;

namespace Vudu.com_Back_End.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {

        }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<MainOption> MainOptions { get; set; }
        public DbSet<SubOption> SubOptions { get; set; }
    }
}

