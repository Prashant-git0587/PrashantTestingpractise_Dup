using PrashantTestingpractise.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrashantTestingpractise.Interfaces
{
    public interface Iconfig
    {
        BrowserType GetBrowserName();
        string GetUserName();
        string GetPassword();
        string GetWebaddress();
    }
}
