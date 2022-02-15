using LeaveManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole {
                    Id= "67cb2cf7-7950-4ffe-b1f0-75f8705e6461",
                    Name=Roles.Administrator,
                    NormalizedName= Roles.Administrator.ToUpper()
                },
                new IdentityRole
                {
                    Id = "67aa2cf7-7951-4ffe-b1f0-76f8705e6461",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                });
        }
    }
}