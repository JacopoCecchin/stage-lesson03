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
	public partial class StackLayoutPage : ContentPage
	{
		public StackLayoutPage ()
		{
			InitializeComponent ();
		}

        private async void Prova1_Clicked(object sender, EventArgs e)
        {
            //StackLayoutPage p = new StackLayoutPage();
            await this.Navigation.PopAsync();
        }

        private async void Prova2_Clicked(object sender, EventArgs e)
        {
            //StackLayoutPage p = new StackLayoutPage();
            await this.Navigation.PopAsync();
        }
    }
}