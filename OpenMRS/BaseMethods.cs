using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationPracticeee
{
    class BaseMethods:BaseProperties
    {
        public static void driverInitializer(driversType type)
        {
            if (type == driversType.chrome)
                driver = new ChromeDriver();            
        }
        public static void GoToURL(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public static void MaxWindow()
        {
            driver.Manage().Window.Maximize();
        }
        public static void wait(int time)
        {
            Thread.Sleep(time);
        }
        public static void close()
        {
            driver.Close();
        }
        public static void quit()
        {
            driver.Quit();
        }
        
        public static void CombineScroll(int xPixel, int yPixel)
        {
            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                var VS = String.Format("window.scrollTo({0}, {1})", xPixel, yPixel);
                js.ExecuteScript(VS);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void Scroll(scrollType type,int pixel)
        {
            if (type == scrollType.H)
            {
                try
                {
                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    var VS = String.Format("window.scrollTo({0}, 0)", pixel);
                    js.ExecuteScript(VS);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            if (type == scrollType.V)
            {
                try
                {
                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    var VS = String.Format("window.scrollTo(0, {0})", pixel);
                    js.ExecuteScript(VS);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
        
        public static void SendKeys(propertype elementType, string element, string value)
        {
            if (elementType == propertype.Id)
                driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementType == propertype.Name)
                driver.FindElement(By.Name(element)).SendKeys(value);
            if (elementType == propertype.Class)
                driver.FindElement(By.ClassName(element)).SendKeys(value);
            if (elementType == propertype.Xpath)
                driver.FindElement(By.XPath(element)).SendKeys(value);
        }
        public static void Click(propertype elementType, string element)
        {
            if (elementType == propertype.Id)
                driver.FindElement(By.Id(element)).Click();
            if (elementType == propertype.Name)
                driver.FindElement(By.Name(element)).Click();
            if (elementType == propertype.Class)
                driver.FindElement(By.ClassName(element)).Click();
            if (elementType == propertype.Xpath)
                driver.FindElement(By.XPath(element)).Click();
            if (elementType == propertype.LinkText)
                driver.FindElement(By.LinkText(element)).Click();
        }
        public static void Clear(propertype elementType, string element)
        {
            if (elementType == propertype.Id)
                driver.FindElement(By.Id(element)).Clear();
            if (elementType == propertype.Name)
                driver.FindElement(By.Name(element)).Clear();
            if (elementType == propertype.Class)
                driver.FindElement(By.ClassName(element)).Clear();
            if (elementType == propertype.Xpath)
                driver.FindElement(By.XPath(element)).Clear();
        }
    }
}
