using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLib;
namespace AutomationPracticeee
{
    class HomePage:BaseMethods
    {
        private static void ToggleOnPopulerAndBestSeller()
        {
            
            Click(propertype.Xpath, "//*[text()='Best Sellers']");
            wait(2000);
            Click(propertype.Xpath, "//*[text()='Popular']");
            
        }
        private static void QuickViewOfFirstProduct()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.XPath("//ul[@id='homefeatured']/li[position()=2]/div"))).Build().Perform();
            Click(propertype.Xpath, "//ul[@id='homefeatured']/li[position()=2]/descendant::a[@class='quick-view']");
            
        }
        private static void AddToWishList()
        {
            driver.SwitchTo().Frame(1);
            wait(2000);
            Click(propertype.Xpath, "//p[@id='quantity_wanted_p']//child::a[2]");
            wait(2000);
            Click(propertype.Xpath, "//*[@id='wishlist_button']");
        }
        private static void ModalOperations()
        {
            driver.SwitchTo().Frame(1);
            wait(2000);
            Click(propertype.Xpath, "//p[@id='quantity_wanted_p']//child::a[2]");
            wait(2000);
            Click(propertype.Xpath, "//select[@id='group_1']");
            wait(500);
            Click(propertype.Xpath, "//select[@id='group_1']//child::option[2]");
            wait(2000);
            Click(propertype.Xpath, "//ul[@id='color_to_pick_list']//child::li[2]//a");
            wait(2000);
            Click(propertype.Xpath, "(//ul[@id='thumbs_list_frame']//child::li//img[1])[2]");
            wait(2000);
            Click(propertype.Xpath, "(//ul[@id='thumbs_list_frame']//child::li//img[1])[3]");
            wait(2000);
            Click(propertype.Xpath, "//p[@id='add_to_cart']//child::button");
            wait(2000);
            //driver.SwitchTo().Frame(1);
            Click(propertype.Xpath, "//div[@class='button-container']//child::a");
        }
        public static void HomePageRunner()
        {
            //Scroll(scrollType.V, 600);
            wait(2000);
            //ToggleOnPopulerAndBestSeller();
            //VScroll(400);
            QuickViewOfFirstProduct();
            wait(3000);
            ModalOperations();
            //AddToWishList();
            wait(3000);
        }
    }
}
