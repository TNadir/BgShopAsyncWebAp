using BgShop.Domen.Entities;
using Microsoft.EntityFrameworkCore;

namespace BgShop.Data.Model
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
        {

        }

        public DbSet<Games> Games { get; set; }
        public DbSet<Publishers> Publishers { get; set; }

    }
}