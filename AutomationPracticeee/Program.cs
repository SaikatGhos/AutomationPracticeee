using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLib;

namespace AutomationPracticeee
{
    internal class Program:BaseMethods
    {
        static void Main(string[] args)
        {
            //driverInitializer(driversType.chrome);
            driver = new ChromeDriver();

            GoToURL("http://automationpractice.com");
            //GoToURL("https://demo.openmrs.org/openmrs/");
            //MaxWindow();

            //
            //signin.SignInRunner();
            //ContactUs.ContactUsRunner();
            HomePage.HomePageRunner();
            wait(2000);
            //productRelatedTestCases.testCase7();
            #region OMRS
            
            
            #endregion
            wait(5000);
            close();
            quit();
        }
    }
}
