using NewFinanceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewFinanceApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FinanceAppPage : ContentPage
	{
		public FinanceAppPage ()
		{
			InitializeComponent ();

            btnHouseholds.Clicked += btnHouseholds_Clicked;
            btnAccounts.Clicked += btnAccounts_Clicked;
            btnTransactions.Clicked += btnTransactions_Clicked;
            btnBudgets.Clicked += btnBudgets_Clicked;

        }

        private async void btnBudgets_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BudgetsPage());
        }

        private async void btnTransactions_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TransactionsPage());
        }

        private async void btnAccounts_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccountsPage());
        }

        private async void btnHouseholds_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Households());
        }
   }
}