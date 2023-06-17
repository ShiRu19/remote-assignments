using Assignment_1.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Assignment_1.Data
{
	public class MvcDbContext : DbContext
	{
		public MvcDbContext(DbContextOptions options) : base(options)
		{
		}

        public DbSet<User> Users { get; set; }
    }
}
