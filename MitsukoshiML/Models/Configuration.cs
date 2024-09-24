using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitsukoshiML.Models
{
    public class Configuration
    {
        //WBOX
        public string ContractNo { get; set; }
        public string POSNo { get; set; }
        public string CompanyName { get; set; }
        public string XMLPath { get; set; }

        //MallLinking API
        public string PostAPI { get; set; }
        public string GetAPI { get; set; }
        public string APIKey { get; set; }
        public string SecretKey { get; set; }
    }
}
