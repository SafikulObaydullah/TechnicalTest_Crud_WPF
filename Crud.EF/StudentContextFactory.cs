using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.EF
{
   public class StudentContextFactory : IDesignTimeDbContextFactory<StudentDBContext>
   {
      public StudentDBContext CreateDbContext(string[] args = null)
      {
         var options = new DbContextOptionsBuilder<StudentDBContext>();
         options.UseSqlServer("Server=DESKTOP-HJ8UUA1\\SQLEXPRESS01; Database=studentcrud; Trusted_Connection=True;TrustServerCertificate=True;");
         return new StudentDBContext(options.Options);
      }
   }
}
