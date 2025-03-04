using Microsoft.EntityFrameworkCore;

namespace EmployCrud.Models
{
    public class EFCoreDbContext:DbContext
    {
        
            //Constructor calling the Base DbContext Class Constructor
            public EFCoreDbContext(DbContextOptions<EFCoreDbContext> options) : base(options)
            {
            }
            //OnConfiguring() method is used to select and configure the data source
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {

            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Employ>().ToTable("Employ");//map the db to frontend employee class and fields map to corresponding values

            }

            public DbSet<Employ> Employees { get; set; }

        
    }

}



//{
//    "empno": 8,
//  "name": "Isha",
//  "gender": "FEMALE",
//  "dept": "DotNet",
//  "desig": "SE",
//  "basic": 70000
//}