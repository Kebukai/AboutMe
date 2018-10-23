using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AboutMeV2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        private void AboutMeButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutPage());
        }

        private void SkillsButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SkillPage());
        }

        private void ContactButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactPage());
        }

        private void AboutTapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactPage());
        }

        private void SkillTapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactPage());
        }

        private void ContactTapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactPage());
        }
    }
}
