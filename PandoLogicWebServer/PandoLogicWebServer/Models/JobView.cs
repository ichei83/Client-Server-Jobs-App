using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandoLogicWebServer.Models
{
    /// <summary>
    /// Job view model
    /// </summary>
    public class JobView
    {
        public int Id { get; set; }
        public int JobId { get; set; }

        public Job Job { get; set; }

        public int ViewNumber { get; set; }
        public DateTime JobViewTime { get; set; }
    }
}
