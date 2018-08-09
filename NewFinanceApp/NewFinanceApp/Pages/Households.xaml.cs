using NewFinanceApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewFinanceApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Households : ContentPage
	{
		public Households()
		{
			InitializeComponent ();
            getHouseholdsBtn.Clicked += getHouseholdsBtn_Clicked;
            btnFinanceApp.Clicked += btnFinanceApp_Clicked;
            this.BindingContext = new Household();

        }

        private async void getHouseholdsBtn_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(householdIdEntry.Text))
            {
                
                var house = await Core.GetHouseholdData(Convert.ToInt32(householdIdEntry.Text));
                this.BindingContext = house;
            }
        }

        private async void btnFinanceApp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }
}