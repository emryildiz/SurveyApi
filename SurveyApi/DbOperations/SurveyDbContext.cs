using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SurveyApi.Common.Entities;

namespace SurveyApi.DbOperations
{
    public class SurveyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Survey> Surveys { get; set; }

        public DbSet<Question> Question { get; set; }

        public DbSet<Choise> Choises { get; set; }

        public DbSet<Response> Responses { get; set; }

        public DbSet<Image> Images { get; set; }

        public IConfiguration Configuration { get; set; }

        public SurveyDbContext(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("SurveyDb"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
