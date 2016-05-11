using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using HockeyApp;

namespace HockeyAppSample.iOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{

        //Michelle's
        public const string API_KEY = "6052a295ea384e6bbbd30572d87504f7";

        //Dylan's
        public const string Dylan_API_KEY = "89ab15ddbfdb436e90f10e77383adcbb";

        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
            var manager = BITHockeyManager.SharedHockeyManager;
            manager.Configure(Dylan_API_KEY);
            manager.StartManager();

            global::Xamarin.Forms.Forms.Init ();
			LoadApplication (new HockeyAppSample.App ());

			return base.FinishedLaunching (app, options);
		}
	}
}
