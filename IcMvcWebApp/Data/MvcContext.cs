using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IcMvcWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace IcMvcWebApp.Data
{
    public class MvcContext : DbContext
    {
        public MvcContext(DbContextOptions<MvcContext> options) : base(options)
        {
        }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Role> Roles { get; set; }
        //public DbSet<RoleAssignment> RoleAssignments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Staff>().ToTable("Staff");
            modelBuilder.Entity<Role>().ToTable("Role");
            //modelBuilder.Entity<RoleAssignment>().ToTable("RoleAssignment");

            //modelBuilder.Entity<RoleAssignment>()
               //.HasKey(c => new { c.RoleName, c.StaffID });
        }
    }
}
