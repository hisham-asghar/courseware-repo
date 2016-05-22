using Entities;
namespace Utility
{
    using System.Data.Entity;

    public partial class Database : DbContext
    {
        public Database()
        {
            this.Configuration.ValidateOnSaveEnabled = false;
  //          this.Configuration.LazyLoadingEnabled = false;
        }
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Course_Material> Course_Material { get; set; }
        public virtual DbSet<Cours> Courses { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Magzine> Magzines { get; set; }
        public virtual DbSet<Magzines_Category> Magzines_Category { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<User_log> User_log { get; set; }
        
    }
}
