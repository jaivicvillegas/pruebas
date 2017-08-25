using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelSelenium
{
    public static class Constants
    {
        internal static string sauceUser = Environment.GetEnvironmentVariable("claudiamarquez");
        internal static string sauceKey = Environment.GetEnvironmentVariable("03e669cf-8fe4-46b7-a1ac-59a63b96420a");
        internal static string tunnelId = Environment.GetEnvironmentVariable("");
        internal static string seleniumRelayPort = Environment.GetEnvironmentVariable("80");
        internal static string buildTag = Environment.GetEnvironmentVariable("28");
        internal static string seleniumRelayHost = Environment.GetEnvironmentVariable("03e669cf-8fe4-46b7-a1ac-59a63b96420a.ondemand.saucelabs.com");

    }
}