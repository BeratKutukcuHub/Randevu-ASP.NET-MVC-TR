using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.DbConfigEfCore
{
    public class IdentityRoleConfig : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole(){Name = "Admin", NormalizedName = "ADMIN"},
                new IdentityRole(){Name = "Personal", NormalizedName = "PERSONAL"},
                new IdentityRole(){Name = "User", NormalizedName = "USER"}
            );
        }
    }
}