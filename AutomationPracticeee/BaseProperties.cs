using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPracticeee
{
    enum driversType
    {
        chrome,
        firefox,
        IE
    }
    enum propertype
    {
        Id,
        Class,
        Name,
        Xpath,
        LinkText
    }
    class BaseProperties
    {
        public static IWebDriver driver { get;  set; }
        public static IJavaScriptExecutor js { get; private set; }
    }
}
