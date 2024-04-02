using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NZWalks.Data
{
    public class NZWalksAuthDbContext : IdentityDbContext
    {
        public NZWalksAuthDbContext(DbContextOptions<NZWalksAuthDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var readerRoleId = "0778c28f-dbc7-4c32-8db7-1f89296ec519";
            var writerRoleId = "07711c92-d3ac-4a77-ac09-950f199d0f25";

            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                     Id = readerRoleId,
                     ConcurrencyStamp = readerRoleId,
                     Name = "Reader",
                     NormalizedName = "Reader".ToUpper()
                },
                new IdentityRole
                {
                     Id = writerRoleId,
                     ConcurrencyStamp = writerRoleId,
                     Name = "Writer",
                     NormalizedName = "Writer".ToUpper()
                }
            };

            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
