using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMRS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            driver = new ChromeDriver();

            GoToURL("http://automationpractice.com");
            MaxWindow();

            //
            signin.SignInRunner();
            //ContactUs.ContactUsRunner();
            //HomePage.HomePageRunner();

            wait(5000);
            close();
            quit();
        }
    }
}
