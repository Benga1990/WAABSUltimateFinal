using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WAABSnew.Models
{
    public class JobModel
    {
        public int JobModelId { get; set;}
        public int BuyerModelID { get; set; }
        public int SellerModelID { get; set; }
        public int BankModelID { get; set; }
        public int EstateAgentModelID { get; set; }
        public int SolicitorModelID { get; set; }
    }
}