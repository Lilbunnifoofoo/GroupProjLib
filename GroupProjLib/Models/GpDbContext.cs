using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GroupProjLib.Models {
    public class GpDbContext : DbContext{

        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<Resources> Resources { get; set; } = null!;
        public virtual DbSet<Work> Works { get; set; } = null!;

        public GpDbContext () { }
        public GpDbContext (DbContextOptions<GpDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            if (!builder.IsConfigured) {
                var connStr = @"server=localhost\sqlexpress;"
                + "database=GpDb;"
                + "trustServerCertificate=true;"
                + "trusted_connection=true;";
                builder.UseSqlServer(connStr);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
    }
}
