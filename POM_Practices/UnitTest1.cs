using System;
using NUnit.Framework;
using POM_Practices.PageObjectModel;
using POM_Practices.Settings;
using POM_Practices.BaseClass;
using System.Threading;

namespace POM_Practices
{
    [TestFixture]
    class UnitTest1 : BaseClass.BaseClass
    {
        [Test]
        public void TestMethod1()
        {
            HomePage home = new HomePage(ObjectInitialization.driver);
            home.ClickOnButtons("Prashant");
            Thread.Sleep(1000);
            
        }
    }
}
