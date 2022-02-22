using LeaveManagement.Web.Configuration.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Data
{
    public class ApplicationDbContext: IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
        }

        // Admin Will add NEW type of leave in db or CRUD
        public DbSet<LeaveType> LeaveTypes { get; set; }
        
        //Admin will set new LeaveType to all employee in LeaveManagement -> LeaveType ->Allocate Leave
        //After that only 
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }

        //Most of User will request for leave in ApplyForLeave
        public DbSet<LeaveRequest> LeaveRequests { get; set; }

    }
}
