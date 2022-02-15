using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Web.Configuration.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(

                new IdentityUserRole<string>()
                {
                    RoleId = "67cb2cf7-7950-4ffe-b1f0-75f8705e6461",
                    UserId = "67bi2cf3-2950-4ffe-b1f0-75f8705e2469"
                },
                                new IdentityUserRole<string>()
                                {
                                    RoleId = "67aa2cf7-7951-4ffe-b1f0-76f8705e6461",
                                    UserId = "67bq2cb3-1955-4sfe-b1f7-73f8705e2469"
                                }

                );
        }
    }
}