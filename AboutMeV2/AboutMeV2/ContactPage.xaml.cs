using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AboutMeV2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactPage : ContentPage
	{
		public ContactPage ()
		{
			InitializeComponent ();
		}

        private void Mail_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
            DisplayAlert ("Sent!","Thank you for sending your mail","Ok");
        }
    }
}