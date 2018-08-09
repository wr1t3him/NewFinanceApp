using NewFinanceApp.Models;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewFinanceApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TransactionsPage : ContentPage
	{
        ObservableCollection<Transaction> MyTransactions = new ObservableCollection<Transaction>();

        public TransactionsPage ()
		{
			InitializeComponent ();
            TransactionsView.ItemsSource = MyTransactions;

            getTransactionsBtn.Clicked += getTransactionsBtn_Clicked;
            btnFinanceApp.Clicked += btnFinanceApp_ClickedAsync;
        }

        private async void getTransactionsBtn_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(accountIDEntry.Text))
            {
                var transaction = await Core.GetTransactions(Convert.ToInt32(accountIDEntry.Text));
                foreach (var trans in transaction)
                {
                    MyTransactions.Add(trans);
                }
            }
        }

        private async void btnFinanceApp_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }        
    }
}