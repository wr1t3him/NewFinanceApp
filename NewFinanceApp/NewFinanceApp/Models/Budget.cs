using System;
using System.Collections.Generic;
using System.Text;

namespace NewFinanceApp.Models
{
    public class Budget
    {
        public int ID { get; set; }
        public decimal value { get; set; }
        public decimal balance { get; set; }
        public int HouseHoldID { get; set; }
        public string BudgetType { get; set; }

        public Budget()
        {
            value = 0.00m;
            balance = 0.00m;
            BudgetType = "";
        }
    }
}
