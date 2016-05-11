using System;
using Xamarin.Forms;

namespace HockeyAppSample
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
        }

        public void OnForceException_Clicked(object sender, EventArgs args)
        {
            throw new MulticastNotSupportedException();
            //throw new Exception("You just forced and exception. Hopefully this makes it the hockeyapp dashboard.");
        }
    }
}