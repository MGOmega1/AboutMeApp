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
    }
}