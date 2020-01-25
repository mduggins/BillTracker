using System;
using System.ComponentModel.DataAnnotations;

namespace BillTracker.Models {
    public class Bill {
        public string Name { get; set; }
        public string Amount { get; set; }

        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }
    }
}