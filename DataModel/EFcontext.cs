using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    public class EFcontext :  DbContext
    {
        public EFcontext() { }
        public EFcontext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<todoentity> todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = (localdb)\\mssqllocaldb; Database = ShobTestDB; Trusted_Connection = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<todoentity>(todoentity => {
                todoentity.ToTable("ToDoList");
                todoentity.HasKey("TaskId");
                });
            base.OnModelCreating(modelBuilder);
        }

    }
}
