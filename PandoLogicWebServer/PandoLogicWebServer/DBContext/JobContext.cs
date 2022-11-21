using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//using System.Threading.Tasks;
using PandoLogicWebServer.Models;

namespace PandoLogicWebServer.DBContext
{
    public class JobContext : DbContext
    {
        public JobContext(DbContextOptions<JobContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Job>().ToTable("Jobs");
            modelBuilder.Entity<JobView>().ToTable("JobView");
            modelBuilder.Entity<JobPrediction>().ToTable("JobPrediction");
        }


        public Microsoft.EntityFrameworkCore.DbSet<Job> Jobs { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<JobPrediction> Predictions { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<JobView> Views { get; set; }

    }

    //public class JobContext : Microsoft.EntityFrameworkCore.DbContext
    //{
    //    public JobContext(DbContextOptions options) : base(options)
    //    {

    //    }

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Entity<Job>().ToTable("Jobs");
    //        modelBuilder.Entity<JobView>().ToTable("JobViews");
    //        modelBuilder.Entity<JobPrediction>().ToTable("JobPredictions");
    //    }


    //    public Microsoft.EntityFrameworkCore.DbSet<Job> Jobs { get; set; }
    //    public Microsoft.EntityFrameworkCore.DbSet<JobPrediction> JobPredictions { get; set; }
    //    public Microsoft.EntityFrameworkCore.DbSet<JobView> JobViews { get; set; }

    //}
}
