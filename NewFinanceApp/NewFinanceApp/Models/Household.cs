using System;
using System.Collections.Generic;
using System.Text;

namespace NewFinanceApp.Models
{
    public class Household
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Household()
        {
            Name = "";
        }
    }
}
