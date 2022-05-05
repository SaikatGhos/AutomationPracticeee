using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPracticeee
{
    class signin:BaseMethods
    {
        private static void ClickOnSignInButton(propertype type,string path)
        {
            Click(type, path);
        }
        private static void SendEmailToCreateAcc(string key)
        {
            
            SendKeys(propertype.Xpath, "//input[@id='email_create']", key);
            wait(2000);
            Click(propertype.Xpath, "//button[@id='SubmitCreate']");
            wait(5000);
            
        }
        private static void userReg()
        {
            SendKeys(propertype.Xpath, "//input[@id='customer_firstname']", "abc");
            wait(2000);
        }

        public static void SignInRunner()
        {
            ClickOnSignInButton(propertype.Xpath,"//*[@class='login']");
            wait(1000);
            VScroll(500);
            wait(1000);
            SendEmailToCreateAcc("vewej88274@eoscast.com");
            wait(2000);
            userReg();
            
        }
    }
}
