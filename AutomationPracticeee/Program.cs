using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPracticeee
{
    internal class Program:BaseMethods
    {
        static void Main(string[] args)
        {
            //driverInitializer(driversType.chrome);
            driver = new ChromeDriver();

            GoToURL("http://automationpractice.com");
            MaxWindow();

            //
            signin.SignInRunner();

            wait(5000);
            close();
            quit();
        }
    }
}
