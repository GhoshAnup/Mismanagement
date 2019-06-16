using Microsoft.EntityFrameworkCore;
using Mismanagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mismanagement.Data.Context
{
    public class MismanagementDbContext : DbContext
    {
        public MismanagementDbContext(DbContextOptions<MismanagementDbContext> options)
          : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Task> Task { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Status> Status { get; set; }
    }
}
