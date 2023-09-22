using Crud.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.EF
{
   public class StudentDBContext : DbContext
   {
      public DbSet<Student> Student { get; set; }

      public StudentDBContext()
      {
      }
      public StudentDBContext(DbContextOptions options) : base(options)
      {
      }
      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         modelBuilder.Entity<Student>().HasKey(e => e.id);
      }
   }
}
