using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLib;

namespace AutomationPracticeee
{
    class SignInSignUpRelatedTestCases:BaseMethods
    {
        private static void ClickOnSignInButton()
        {
            Click(propertype.Xpath, "//*[@class='login']");
        }
        private static void SendEmailToCreateAcc(string key)
        {
            
            SendKeys(propertype.Xpath, "//input[@id='email_create']", key);//entering email
            wait(2000);
            Click(propertype.Xpath, "//button[@id='SubmitCreate']");//click on "Create an Account" button
            wait(7000);
            //userReg();//rest cases
            
        }
        private static void invalidEmailCheck(string key)
        {
            SendKeys(propertype.Xpath, "//input[@id='email_create']", key);
            wait(2000);
            Click(propertype.Xpath, "//button[@id='SubmitCreate']");
            wait(5000);
        }
        private static void userReg(string cfname,string clname,string pswd,string fname,string lname,
            string addrs,string city,string zip,string phone,string alias)
        {
            wait(2000);
           //Entering Personal Information
            SendKeys(propertype.Xpath, "//input[@id='customer_firstname']", cfname);
            wait(2000);
            SendKeys(propertype.Xpath, "//input[@id='customer_lastname']", clname);
            wait(2000);
            SendKeys(propertype.Xpath, "//input[@id='passwd']", pswd);
            wait(2000);
            SendKeys(propertype.Xpath, "//input[@id='firstname']", fname);
            wait(2000);
            SendKeys(propertype.Xpath, "//input[@id='lastname']", lname);
            wait(2000);
            SendKeys(propertype.Xpath, "//input[@id='address1']", addrs);
            wait(2000);
            SendKeys(propertype.Xpath, "//input[@id='city']", city);
            wait(2000);
            SendKeys(propertype.Xpath, "//input[@id='postcode']", zip);
            wait(2000);
            SendKeys(propertype.Xpath, "//input[@id='phone_mobile']", phone);
            wait(2000);
            SendKeys(propertype.Xpath, "//input[@id='alias']", alias);

            Click(propertype.Xpath, "//button[@id='submitAccount']");
            wait(2000);

        }
        private static void userRegErrorCheck()
        {
            wait(2000);
            //Entering Personal Information to check Error
            SendKeys(propertype.Xpath, "//input[@id='customer_firstname']", "abc");
            wait(2000);
            wait(2000);
            Click(propertype.Xpath, "//button[@id='submitAccount']");
            wait(2000);

        }
        public static void testCase2()
        {
            //2# Test Case - Verify invalid email address error.

            GoToURL("http://automationpractice.com/index.php");//Step 1            
            ClickOnSignInButton();//Step 2
            wait(2000);
            Scroll(0, 300);
            SendKeys(propertype.Xpath, "//input[@id='email']", "Saikat");//Step 3
            TabDown();//Step 4
        }
        public static void testCase3()
        {
            // 3# Test Case - Verify error messages for mandatory fields.
            GoToURL("http://automationpractice.com/index.php");//Step 1
            ClickOnSignInButton();//Step 2
            wait(2000);
            SendEmailToCreateAcc("vewej88274@eoscast.com");//Step3 Step4 Step 5
            Scroll(0, 500);

        }

        public static void SignInRunner()
        {

            testCase3();
           // wait(1000);
           //Scroll(scrollType.V, 500);
           // wait(1000);
           // //Test Case #2(Ckecking of invalid email)
           // invalidEmailCheck("abcd");
           // wait(5000);
           // //Test Case #1(Automate user registration process)
           // SendEmailToCreateAcc("vewej88274@eoscast.com");
           // wait(2000);

        }
    }
}
