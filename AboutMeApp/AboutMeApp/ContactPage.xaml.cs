using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AboutMeApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactPage : ContentPage
	{
		public ContactPage ()
		{
			InitializeComponent ();
		}

        private void phoneButton_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel:8168137117"));
        }

        private void mailButton_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("mailto:mgriff15@me.com"));
        }

        private void linkedInButton_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.linkedin.com/in/michael-griffin-b65063b6/"));
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameEntry.Text))
            {
                DisplayAlert("Error", "Please Enter a Name", "Ok");
                return;
            }
            if (string.IsNullOrEmpty(emailEntry.Text))
            {
                DisplayAlert("Error", "Please Enter your Email", "Ok");
                return;
            }
            if (string.IsNullOrEmpty(messageEditor.Text))
            {
                DisplayAlert("Error", "Please Enter a Message", "Ok");
                return;
            }

            DisplayAlert("Alert", "Message has been Submitted", "Ok");
        }
    }
}