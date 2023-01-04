using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using MySQL.EntityFrameworkCore.Extensions;


namespace ManageCategoriesApp
{
    public class Category
    {
        public Category()
        {

        }
        [Key, DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }

    public class MyStock : DbContext
    {
        public MyStock() { }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=library;user=user;password=password", ServerVersion);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategoryID);
                entity.Property(e => e.CategoryName)
                .IsRequired()
                .HasMaxLength(40);
            });

            using (var context = new MyStock())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();
                context.Categories.Add(new Category
                {
                    CategoryName = "Cate1"
                });
                context.Categories.Add(new Category
                {
                    CategoryName = "Cate2"
                });
            }

        }

    }
}
