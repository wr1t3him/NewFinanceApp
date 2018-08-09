using System;
using System.Collections.Generic;
using System.Text;

namespace NewFinanceApp.Models
{
    public class Transaction
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string description { get; set; }
        public decimal Cost { get; set; }
        public bool verify { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public string UserID { get; set; }
        public int AccountID { get; set; }

        public Transaction()
        {
            Type = "";
            Name = "";
            description = "";
            Cost = 0.00m;
            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            Updated = null;
        }
    }
}
