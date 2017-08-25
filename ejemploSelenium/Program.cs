using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace ejemploSelenium
{

    class Program
    {
        private ICapabilities capabilities;

      

        static void Main(string[] args)
        {
            DesiredCapabilities capability = DesiredCapabilities.Chrome();
            capability.SetCapability("username", "claudiamarquez");
            capability.SetCapability("accessKey", "03e669cf-8fe4-46b7-a1ac-59a63b96420a");
            capability.SetCapability("version", "latest-1");
            capability.SetCapability("platform", "WIN7");
            capability.SetCapability("browserName", "chrome");
            capability.SetCapability("version", "58");
            var driver = new RemoteWebDriver(new Uri("https://ondemand.saucelabs.com:443/wd/hub"), capability);

                      //element.SendKeys("");
            driver.Navigate().GoToUrl("https://www.esika.com/pe/");

            IWebElement elem = driver.FindElementByName("text");
            elem.SendKeys("corrector");
            elem.Submit();
            driver.Quit();
        }
    }
}
