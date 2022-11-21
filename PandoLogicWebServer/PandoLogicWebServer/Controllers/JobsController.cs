using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PandoLogicWebServer.DBContext;
using PandoLogicWebServer.DTOS;
using PandoLogicWebServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandoLogicWebServer.Controllers
{
    /// <summary>
    /// Controller for jobs apis 
    /// </summary>
    public class JobsController : Controller
    {
        /// <summary>
        /// DBContext, use for DB actions
        /// </summary>
        private readonly JobContext _context;

        public JobsController(JobContext ctx)
        {
            _context = ctx;
        }

        /// <summary>
        /// Get Cumulative job views vs. prediction
        /// </summary>
        /// <param name="StartDate">the start date which get jobs data</param>
        /// <param name="EndDate">the end date which get the jobs data</param>
        /// <returns></returns>
        [HttpGet("api/Jobs/GetJobsStatistics2/{StartDate}/{EndDate}")]
        public /*async Task<ActionResult<IEnumerable<JobView>>>*/ ActionResult<GraphData> GetJobsStatistics2(string StartDate, string EndDate)
        {

            var gd = new GraphData();
            DateTime startDT = Convert.ToDateTime(StartDate);
            DateTime endDT = Convert.ToDateTime(EndDate);
            while (startDT <= endDT)
            {

                var firstDate = startDT; // new DateTime(currYear, 12, day);
                var secondDate = firstDate.AddDays(1);

                var total1 = (from x in this._context.Jobs
                              where
                              x.StartDate <= firstDate && x.EndDate >= secondDate

                              select x).Count();
                var total2 = (from x in this._context.Views
                              join j in this._context.Jobs on x.JobId equals j.Id
                              where
                             x.JobViewTime >= firstDate && x.JobViewTime < secondDate

                              select x).Sum(x=>x.ViewNumber);
                var total3 = (from x in this._context.Predictions
                              join j in this._context.Jobs on x.JobId equals j.Id
                              where
                             x.JobPredictionTime >= firstDate && x.JobPredictionTime < secondDate

                              select x).Sum(x=>x.PredictNumber);
                double[] data = new double[3];

                data[0] = total1;
                data[1] = total2;
                data[2] = total3;
                gd.data.Add(data);
                gd.SelectedDays.Add(firstDate.ToShortDateString());

                startDT = startDT.AddDays(1);
            }

            return gd;

        }

    }
}
