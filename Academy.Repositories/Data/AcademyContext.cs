using Academy.Core.Entities;
using Academy.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Academy.Repositories.Data
{
    public class AcademyContext : DbContext
    {
      public AcademyContext() : base(){}
      public AcademyContext(DbContextOptions<AcademyContext> options) 
      : base(options)
      {
        
      }  
      public DbSet<Institution> Institutions {set; get;}
      public DbSet<Faculty> Faculties {set; get;}
      public DbSet<Department> Departments {set; get;}
      public DbSet<Program> Programs {set; get;}
      public DbSet<Core.Entities.Course> Courses {set; get;}
      
    }
}