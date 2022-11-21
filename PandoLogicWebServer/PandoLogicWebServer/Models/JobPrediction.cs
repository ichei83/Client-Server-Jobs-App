using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandoLogicWebServer.Models
{
    /// <summary>
    /// Job prediction model
    /// </summary>
    public class JobPrediction
    {
        public int Id { get; set; }
        public int JobId { get; set; }

        public Job Job { get; set; }

        public int PredictNumber { get; set; }
        public DateTime JobPredictionTime { get; set; }
    }
}
