using HockeyApp;
using System;

namespace HockeyAppSample
{
    public class CrashListener : CrashManagerListener
    {
        public  const string EMAIL = "dwegner@crinet.com";

        public override String UserID
        {
            get
            {
                return EMAIL;
            }
        }

        public override String Contact
        {
            get
            {
                return EMAIL;
            }
        }

        public override String Description
        {
            get
            {
                return EMAIL;
            }
        }
    }
}
