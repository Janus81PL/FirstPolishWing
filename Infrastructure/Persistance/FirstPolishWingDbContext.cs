using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FirstPolishWing.Infrastructure.Persistance
{
    public class FirstPolishWingDbContext : IdentityDbContext
    {
        public FirstPolishWingDbContext(DbContextOptions<FirstPolishWingDbContext> options) : base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
