using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetVincere.Model
{
    public class Candidate_model
    {
        public class CandidateData_model
        {
            public int Id { get; set; }
            public string Lastname { get; set; }
            public string Fistname { get; set; }
            public DateTime? DateCreated { get; set; }
            public DateTime? LastUpdated { get; set; }
        }

        //fl=id,first_name, last_name,company,owners
        public class Search_model
        {
            public int start { get; set; }
            public int total { get; set; }
            public Data_model result { get; set; }

            public Search_model()
            {                
                result = new Data_model();
            }

            public class Data_model
            {
                public int start { get; set; }
                public int total { get; set; }
                public List<item_model> items { get; set; }
                
            }

            public class item_model
            {
                public int id { get; set; }
                public string first_name { get; set; }
                public string last_name { get; set; }
                public DateTime created_date { get; set; }
                public DateTime last_update { get; set; }
            }
        }
    }
}
