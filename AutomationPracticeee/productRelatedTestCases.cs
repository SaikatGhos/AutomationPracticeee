using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLib;
namespace AutomationPracticeee
{
    class productRelatedTestCases:BaseMethods
    {
        public static void testCase5()
        {
            //Click(propertype.Xpath, "(//*[@id='block_top_menu']//child::a)[1]");
            MouseHover("(//*[@id='block_top_menu']//child::a)[1]");
            wait(2000);
            driver.SwitchTo().ActiveElement();
            wait(2000);
            Click(propertype.Xpath, "(//*[@id='block_top_menu']//child::a)[3]");
            wait(2000);
            SendKeys(propertype.Xpath, "(//*[@id='searchbox']//child::input)[4]", "Faded Short Sleeve T-shirts");
            wait(2000);
            Click(propertype.Xpath, "(//*[@id='searchbox']//child::button)");
        }
        public static void testCase6()
        {
            MouseHover("(//*[@id='block_top_menu']//child::a)[1]");
            wait(2000);
            driver.SwitchTo().ActiveElement();
            wait(2000);
            Click(propertype.Xpath, "(//*[@id='block_top_menu']//child::a)[3]");
            wait(2000);
            Click(propertype.Xpath, "//li[@id='list']");
            wait(1000);
            Scroll(0, 500);
            wait(4000);
            Click(propertype.Xpath, "//a[@title='View']");
            wait(3000);
            Scroll(0, 300);
            Click(propertype.Xpath, "//*[@id='quantity_wanted_p']//a[2]");
            wait(2000);
            Click(propertype.Xpath, "//*[@id='group_1']//option[3]");
            wait(2000);
            Click(propertype.Xpath, "//a[@title='Blue']");
            wait(2000);
            Click(propertype.Xpath, "//button[@name='Submit']");
            wait(4000);
            //driver.SwitchTo().Frame(1);
            //wait(2000);
            Click(propertype.Xpath, "//a[@title='Proceed to checkout']");
            wait(2000);
            Scroll(0, 500);
            wait(2000);
            Click(propertype.Xpath, "//a[@title='Proceed to checkout']");
        }
        public static void testCase7()
        {
            MouseHover("(//*[@id='block_top_menu']//child::a)[1]");
            wait(2000);
            driver.SwitchTo().ActiveElement();
            wait(2000);
            Click(propertype.Xpath, "(//*[@id='block_top_menu']//child::a)[3]");
            wait(2000);
            Click(propertype.Xpath, "//li[@id='list']");
            wait(1000);
            Scroll(0, 500);            
            Click(propertype.Xpath, "//*[@class='wishlist']//child::a");
            wait(3000);

        }
    }
}
