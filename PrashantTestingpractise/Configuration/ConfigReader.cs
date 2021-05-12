using PrashantTestingpractise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using PrashantTestingpractise.Settings;

namespace PrashantTestingpractise.Configuration
{
    public class ConfigReader : Iconfig
    {
        public BrowserType GetBrowserName()
        {
            string browser = ConfigurationManager.AppSettings.Get(AppconfigKey.Browser);
            BrowserType b = (BrowserType)Enum.Parse(typeof(BrowserType), browser);
            return b;

        }

        public string GetPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppconfigKey.Password);
        }

        public string GetUserName()
        {
            return ConfigurationManager.AppSettings.Get(AppconfigKey.UserName);
        }

        public string GetWebaddress()
        {
            return ConfigurationManager.AppSettings.Get(AppconfigKey.WebAddress);
        }
    }
}
