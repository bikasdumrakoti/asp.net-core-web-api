using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NZWalks.API.Data
{
    public class NZWalksAuthDbContext : IdentityDbContext
    {
        public NZWalksAuthDbContext(DbContextOptions<NZWalksAuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var readerRoleId = "a251d064-ee7b-4768-baee-bf64f9e6fb02";
            var writerRoleId = "0d2b2850-b86e-4628-9216-84e8d1c9b380";

            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id=readerRoleId,
                    ConcurrencyStamp=readerRoleId,
                    Name="Reader",
                    NormalizedName="Reader".ToUpper()
                },
                new IdentityRole
                {
                    Id=writerRoleId,
                    ConcurrencyStamp=writerRoleId,
                    Name="Writer",
                    NormalizedName="Writer".ToUpper()
                }
            };

            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
