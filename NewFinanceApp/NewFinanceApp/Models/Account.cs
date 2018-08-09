using System;
using System.Collections.Generic;
using System.Text;

namespace NewFinanceApp.Models
{
    public class Account
    {
        public int ID { get; set; }
        public decimal Balance { get; set; }
        public string Type { get; set; }
        public int HouseholdID { get; set; }
        public int BankID { get; set; }
        public string UserID { get; set; }

        public Account()
        {
            Type = "";
            Balance = 0.00m;

        }
    }
}
