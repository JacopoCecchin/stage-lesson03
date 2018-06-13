using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lezione3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GridPage : ContentPage
	{
		public GridPage ()
		{
			InitializeComponent ();
		}

        private async void Test1_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopAsync();
        }

        private async void Test2_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopAsync();
        }
    }
}