using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLib;
namespace AutomationPracticeee
{
    class ContactUs:BaseMethods
    {
        private static void ClickOnContactUsButton(propertype type, string path)
        {
            Click(type, path);
        }
        private static void ClickOnSubjectHandelling(propertype type,string path)
        {
            Click(type, path);
            

        }
        public static void ContactUsRunner()
        {
            ClickOnContactUsButton(propertype.Xpath, "//*[text()='Contact us']");
            //Scroll(scrollType.V,300);
            ClickOnSubjectHandelling(propertype.Xpath, "//*[@id='id_contact']");
        }
    }
}
