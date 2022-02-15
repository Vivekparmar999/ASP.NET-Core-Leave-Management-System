using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(

                new Employee 
                {
                    Id= "67bi2cf3-2950-4ffe-b1f0-75f8705e2469",
                    Email="admin@localhost.com",
                    NormalizedEmail="ADMIN@LOCALHOST.COM",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    UserName= "admin@localhost.com",
                    FirstName ="System",
                    LastName="Admin",
                    PasswordHash= new PasswordHasher<Employee>().HashPassword(null,"P@ssword1"),
                    EmailConfirmed=true
                },
                                new Employee
                                {
                                    Id = "67bq2cb3-1955-4sfe-b1f7-73f8705e2469",
                                    Email = "user@localhost.com",
                                    NormalizedEmail = "USER@LOCALHOST.COM",
                                    NormalizedUserName = "USER@LOCALHOST.COM",
                                    UserName= "user@localhost.com",
                                    FirstName = "System",
                                    LastName = "User",
                                    PasswordHash = new PasswordHasher<Employee>().HashPassword(null,"P@ssword1"),
                                    EmailConfirmed=true
                                }

                );
        }
    }
}