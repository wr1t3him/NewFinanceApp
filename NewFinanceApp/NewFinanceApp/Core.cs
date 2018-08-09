using NewFinanceApp.Models;
using NewFinanceApp.Pages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace NewFinanceApp
{
    public class Core
    {
        public static async Task<List<Account>> GetAccounts(int houseID)
        {
            string queryString = string.Format("https://financeplannerapi.azurewebsites.net:443/api/Service/GetAccounts?houseID={0}", houseID);
            string json = await DataServices.getFinancePlannerAPI(queryString).ConfigureAwait(false);
            if (json != null)
            {
                return JsonConvert.DeserializeObject<List<Account>>(json);
            }
            else
            {
                return null;
            }
        }

        public static async Task<Household> GetHouseholdData(int houseID)
        {
            Debug.WriteLine("Inside GetHouseholdData with: " + houseID);
            string queryString = string.Format("https://financeplannerapi.azurewebsites.net:443/api/Service/GetHouse?houseID={0}", houseID);
            string json = await DataServices.getFinancePlannerAPI(queryString).ConfigureAwait(false);
            if (json != null)
            {
                return JsonConvert.DeserializeObject<Household>(json);
            }
            else
            {
                return null;
            }
        }

        public static async Task<List<Transaction>> GetTransactions(int accountID)
        {
            string queryString = string.Format("https://financeplannerapi.azurewebsites.net:443/api/Service/GetTransactions?accountID={0}", accountID);
            string json = await DataServices.getFinancePlannerAPI(queryString).ConfigureAwait(false);
            if (json != null)
            {
                return JsonConvert.DeserializeObject<List<Transaction>>(json);
            }
            else
            {
                return null;
            }
        }

        public static async Task<List<Budget>> GetBudgets(int houseID)
        {
            string queryString = string.Format("https://financeplannerapi.azurewebsites.net:443/api/Service/GetBudgets?houseID={0}", houseID);
            string json = await DataServices.getFinancePlannerAPI(queryString).ConfigureAwait(false);
            if (json != null)
            {
                return JsonConvert.DeserializeObject<List<Budget>>(json);
            }
            else
            {
                return null;
            }
        }
    }
}
