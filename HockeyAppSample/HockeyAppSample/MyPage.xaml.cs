using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using HockeyApp;
using HockeyApp.Metrics;

namespace HockeyAppSample
{
	public partial class MyPage : ContentPage
	{
		public MyPage ()
		{
			InitializeComponent ();
		}

        public void OnForceException_Clicked(object sender, EventArgs args)
        {
            throw new NotSupportedException();
            //throw new Exception("You just forced and exception. Hopefully this makes it the hockeyapp dashboard.");
        }

    }
}
