using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using HockeyApp;
using HockeyApp.Metrics;
using Xamarin.Forms.Internals;
using static Android.Media.Audiofx.BassBoost;

namespace HockeyAppSample.Droid
{
    [Activity(Label = "HockeyAppSample", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        //Michelle's
        public const string API_KEY = "6052a295ea384e6bbbd30572d87504f7";

        //Dylan's
        public const string Dylan_API_KEY = "89ab15ddbfdb436e90f10e77383adcbb";

        CrashListener listener = new CrashListener();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            string userid = listener.UserID;
            //Adding crash reporting
            CrashManager.Register(this, Dylan_API_KEY);


            //Adding user metrics accroding to https://github.com/bitstadium/HockeySDK-Xamarin#user-metrics
            MetricsManager.Register(this, Application, Dylan_API_KEY);
            //MetricsManager.TrackEvent($"This the userid: {userid}!!!!!!!!!!!!!!");
            //MetricsManager.EnableUserMetrics();


            global::Xamarin.Forms.Forms.Init (this, bundle);
			LoadApplication (new HockeyAppSample.App ());
		}

        public String getUserId()
        {
            return "dwegner@crinet.com";
        }
    }
}

