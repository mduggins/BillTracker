using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BillTracker.Models {
    public class Bill {
        public string Name { get; set; }
        public string Amount { get; set; }
        public DateTime DueDate { get; set; }
    }
}