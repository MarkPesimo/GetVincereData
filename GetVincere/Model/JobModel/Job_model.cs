using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetVincere.Model.JobModel
{
    public class JobApplication_model
    {
        public class Search_model
        {

        }
    }

    public class Job_model
    {
        public class JobApplicantion_model
        {
            public int slice_index { get; set; }
            public decimal num_of_elementsyProperty { get; set; }
            public bool last { get; set; }
        }

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
                public Company company { get; set; }
                public string job_title { get; set; }
                public DateTime? created_date { get; set; }
                public DateTime? last_update { get; set; }
            }


            public class Company
            {
                public int Id { get; set; }
                public string name { get; set; }
            }
        }
    }
}
