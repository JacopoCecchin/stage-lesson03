using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lezione3
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void StackLayout_Clicked(object sender, EventArgs e)
        {
            StackLayoutPage s = new StackLayoutPage();
            await this.Navigation.PushAsync(s);
        }

        private async void Grid_Clicked(object sender, EventArgs e)
        {
            GridPage g = new GridPage();
            await this.Navigation.PushAsync(g);
        }

        private async void FlexLayout_Clicked(object sender, EventArgs e)
        {
            FlexLayoutPage f = new FlexLayoutPage();
            await this.Navigation.PushAsync(f);
        }
    }
}
