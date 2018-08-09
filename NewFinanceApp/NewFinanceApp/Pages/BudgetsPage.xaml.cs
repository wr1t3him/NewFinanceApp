using NewFinanceApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewFinanceApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BudgetsPage : ContentPage
	{
        ObservableCollection<Budget> MyBudgets = new ObservableCollection<Budget>();

        public BudgetsPage ()
		{
			InitializeComponent ();
            BudgetsView.ItemsSource = MyBudgets;

            getBudgetsBtn.Clicked += getBudgetsBtn_Clicked;
            btnFinanceApp.Clicked += btnFinanceApp_Clicked;
        }

        private async void getBudgetsBtn_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(houseIDEntry.Text))
            {
                var budgets = await Core.GetBudgets(Convert.ToInt32(houseIDEntry.Text));
                foreach (var bud in budgets)
                {
                    MyBudgets.Add(bud);
                }
            }
        }

        private async void btnFinanceApp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}