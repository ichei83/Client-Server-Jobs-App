using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandoLogicWebServer.Models
{
    /// <summary>
    /// Job model
    /// </summary>
    public class Job
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual ICollection<JobPrediction> JobPredictions { get; set; }
        public virtual ICollection<JobView> JobViews { get; set; }

    }
}
