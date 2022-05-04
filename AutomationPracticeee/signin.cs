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
            
            SendKeys(propertype.Xpath, "//*[@class='form-group form-error']//child::input[@id='email_create']",key);
        }

        public static void SignInRunner()
        {
            ClickOnSignInButton(propertype.Xpath,"//*[@class='login']");
            wait(1000);
            VScroll(500);
            wait(1000);
            SendEmailToCreateAcc("vewej88274@eoscast.com");
            
        }
    }
}
