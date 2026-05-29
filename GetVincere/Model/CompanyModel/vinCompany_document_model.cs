using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetVincere.Model.CompanyModel
{
    public class vinCompany_document_model
    {
        public int? document_type_id { get; set; }
        public string file_name { get; set; }
        public int id { get; set; }
        public string  url { get; set; }
        public DateTime? uploaded_date { get; set; }
        public int company_id{ get; set; }
}
}
