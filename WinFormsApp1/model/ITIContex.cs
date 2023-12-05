using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFD2.mymodels
{
    public class ITIContex:DbContext
    {
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Catalog> Catalogs { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        //public virtual DbSet<emp_proj> EmpProjs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=.;Database=my_project_of_EF;Integrated Security=True;TrustServerCertificate=True");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<department>().Property<string>("loc").IsRequired();
           // modelBuilder.Entity<emp_proj>().HasKey("emp_id", "proj_id");
        }
    }
}
