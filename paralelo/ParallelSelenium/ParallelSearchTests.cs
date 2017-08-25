using System;
using System.Net;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using ParallelSelenium.PageObjects.Bing;
using ParallelSelenium.Utils;

namespace ParallelSelenium
{
    [TestFixture("chrome", "46", "Windows 7", "", "")]
    [TestFixture("internet explorer", "11", "Windows 7", "", "")]
    [TestFixture("firefox", "41", "Windows 7", "", "")]
    [TestFixture("chrome", "30", "Windows 7", "", "")]
    [TestFixture("internet explorer", "9", "Windows 7", "", "")]
    [TestFixture("firefox", "30", "Windows 7", "", "")]
    [TestFixture("chrome", "38", "Windows 7", "", "")]
    [TestFixture("internet explorer", "10", "Windows 7", "", "")]
    [TestFixture("firefox", "35", "Windows 7", "", "")]
    [Parallelizable(ParallelScope.Fixtures)]
    public class ParallelSearchTests
    {
        public IWebDriver driver;
        private String browser;
        private String version;
        private String os;
        private String deviceName;
        private String deviceOrientation;

        public ParallelSearchTests(String browser, String version, String os, String deviceName, String deviceOrientation)
        {
            this.browser = browser;
            this.version = version;
            this.os = os;
            this.deviceName = deviceName;
            this.deviceOrientation = deviceOrientation;
        }
      
        
        [SetUp]
        public void Init()
        {
            /* Web proxy setup to be used with the underlying Rest requests.
            **/
            /*
            WebProxy iProxy = new WebProxy("192.168.1.159:808", true);
            iProxy.UseDefaultCredentials = true;
            iProxy.Credentials = new NetworkCredential("test", "hello123");
            WebRequest.DefaultWebProxy = iProxy;
            */
            String seleniumUri = "http://claudiamarquez:03e669cf-8fe4-46b7-a1ac-59a63b96420a@ondemand.saucelabs.com:80/wd/hubs";
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(CapabilityType.BrowserName, browser);
            capabilities.SetCapability(CapabilityType.Version, version);
            capabilities.SetCapability(CapabilityType.Platform, os);
          
          
          
            capabilities.SetCapability("username", Constants.sauceUser);
            capabilities.SetCapability("accessKey", Constants.sauceKey);
        

           this.driver = new RemoteWebDriver(new Uri(seleniumUri), capabilities);
            this.driver.Navigate().GoToUrl("https://www.google.com.pe/");

        }

    
    }

    class Program
    {
  

        static void Main(string[] args)
        {
            
            ParallelSearchTests x = new ParallelSearchTests("chrome", "58", "WIN7","", "");
          


        }
    }

}
