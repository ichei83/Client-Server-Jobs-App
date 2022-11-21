using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandoLogicWebServer.DTOS
{
    /// <summary>
    /// DTO for graph data interface
    /// </summary>
    public class GraphData
    {
        public GraphData()
        {
            //Jobs = new Dictionary<string, List<double>>();
            //Views = new Dictionary<string, List<double>>();
            //Predictions = new Dictionary<string, List<double>>();
            data = new List<double[]>();
            SelectedDays = new List<string>();
        }

        public List<double[]> data { get; set; }
        public List<string> SelectedDays { get; set; }
        //public Dictionary<string, List<double>> Jobs { get; set; }
        //public Dictionary<string, List<double>> Predictions { get; set; }
        //public Dictionary<string, List<double>> Views { get; set; }
    }
}
