using NewFinanceApp.Models;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewFinanceApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AccountsPage : ContentPage
	{
        ObservableCollection<Account> MyAccounts = new ObservableCollection<Account>();

        public AccountsPage ()
		{
			InitializeComponent ();
            AccountsView.ItemsSource = MyAccounts;

            getAccountsBtn.Clicked += getAccountsBtn_Clicked;
            btnFinanceApp.Clicked += btnFinanceApp_Clicked;  
        }

        private async void getAccountsBtn_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(HouseIDEntry.Text))
            {
                var accounts = await Core.GetAccounts(Convert.ToInt32(HouseIDEntry.Text));
                foreach (var acct in accounts)
                {
                    MyAccounts.Add(acct);
                }                
            }
        }

        private async void btnFinanceApp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }
}