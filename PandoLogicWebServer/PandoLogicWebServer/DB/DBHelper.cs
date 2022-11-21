using PandoLogicWebServer.DBContext;
using PandoLogicWebServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandoLogicWebServer.DB
{
    /// <summary>
    /// Helper for DB actions like initialize, fill data and more
    /// </summary>
    public class DBHelper
    {
        public static void Initialize(JobContext context)
        {
            context.Database.EnsureCreated();
        }

        public static void FillJobs(JobContext context)
        {
            if(context.Jobs.Count() == 0)
            {
                Random rnd = new Random();

                int number = rnd.Next(50, 100);  
                for (int i = 0; i < number; i++)
                {
                    var job = new Job
                    {
                        Description = "Description: " + i,
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now.AddDays(i)
                        
                    };
                    context.Jobs.Add(job);
                }
                context.SaveChanges();
                DBHelper.FillViews(context);
                DBHelper.FillJobPredictions(context);
            }


            context.Database.EnsureCreated();
        }

        public static void FillJobPredictions(JobContext context)
        {

            foreach (var j in context.Jobs)
            {

                 Random rnd = new Random();

                var number = (j.EndDate - j.StartDate).TotalDays;
                for (int i = 0; i < number; i++)
                {
                    int predNum = rnd.Next(20, 100);

                    var jp = new JobPrediction
                    {
                        JobPredictionTime = j.StartDate.AddDays(i),
                        JobId = j.Id,
                        PredictNumber = predNum
                    };
                    context.Predictions.Add(jp);
                }


            }
            context.SaveChanges();
        }

        public static void FillViews(JobContext context)
        {
            foreach (var j in context.Jobs)
            {
                Random rnd = new Random();
                
                var number = Convert.ToInt32((j.EndDate - j.StartDate).TotalDays);

                for (int i = 0; i < number; i++)
                {
                    int viewNum = rnd.Next(20, 100);
                    //int number1 = rnd.Next(0, number);

                    var jv = new JobView
                    {
                        JobViewTime = j.StartDate.AddDays(i),
                        JobId = j.Id,
                        ViewNumber = viewNum
                    };
                    context.Views.Add(jv);
                }

            }
            context.SaveChanges();
        }

    }
}
