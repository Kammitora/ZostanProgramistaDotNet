using Diary.Models.Configurations;
using Diary.Models.Domains;
using System;
using System.Data.Entity;
using System.Linq;

namespace Diary
{
    public class ApplicationDBContext : DbContext
    {
        
        private static string _cnn = $@"Server={Properties.Settings.Default.ServerAddress}\"+
                                     $@"{Properties.Settings.Default.ServerName};"+
                                     $@"Database={Properties.Settings.Default.DatabaseName};"+
                                     $@"User Id={Properties.Settings.Default.User};"+
                                     $@"Password={Properties.Settings.Default.Password};";
        public ApplicationDBContext() : base(nameOrConnectionString: _cnn)
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentConfiguration());
            modelBuilder.Configurations.Add(new GroupConfiguration());
            modelBuilder.Configurations.Add(new RatingConfiguration());
        }
    }
}