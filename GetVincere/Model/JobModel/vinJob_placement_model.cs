using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetVincere.Model.JobModel
{
    public class vinJob_placement_model
    {
        public int? placement_id { get; set; }
        public int ?candidate_id { get; set; }
        public DateTime? placed_date { get; set; }
        public string placed_by { get; set; }
        public DateTime? offer_date { get; set; }
        public DateTime? placement_date { get; set; }
        public DateTime? start_date { get; set; }
        public DateTime? end_date { get; set; }
        public string status { get; set; }
        public int? application_id { get; set; }
    }
}
