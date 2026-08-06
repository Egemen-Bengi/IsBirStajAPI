using IsBirStajAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace IsBirStajAPI.Data
{
    public class EnvanterContext : DbContext
    {
        public EnvanterContext(DbContextOptions<EnvanterContext> options) : base(options) 
        { 
        }

        public DbSet<DonanımCihazı> Donanimlar { get; set; }
    }
}