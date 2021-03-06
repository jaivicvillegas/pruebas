﻿using System;
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
            
            capability.SetCapability("version", "latest-1");
            capability.SetCapability("platform", "WIN7");
            capability.SetCapability("browserName", "chrome");
            capability.SetCapability("version", "58");
            capability.SetCapability("username", "claudiamarquez");
            capability.SetCapability("accessKey", "03e669cf-8fe4-46b7-a1ac-59a63b96420a");
            capability.SetCapability("build", System.Environment.GetEnvironmentVariable("JOB_NAME") + "__" + System.Environment.GetEnvironmentVariable("BUILD_NUMBER"));
            var driver = new RemoteWebDriver(
               new Uri("http://claudiamarquez:03e669cf-8fe4-46b7-a1ac-59a63b96420a@ondemand.saucelabs.com:80/wd/hub"), capability);                     
            driver.Navigate().GoToUrl("https://www.esika.com/pe/");
           
            driver.Quit();
            //IWebElement elem = driver.FindElementByName("text");
            //elem.SendKeys("corrector");
            //elem.SendKeys(" 1");
            //elem.Submit();   

        }
    }
}
