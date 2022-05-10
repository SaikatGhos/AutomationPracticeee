using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLib;
namespace OpeenMRS
{
    class findPatient:BaseMethods
    {
        private static void findPatients()
        {
            Click(propertype.Xpath, "//*[@class='float-left']//child::li[4]//a");
            wait(2000);
            SendKeys(propertype.Xpath, "//*[@id='patient-search-form']//child::input","Baban");
            wait(3000);
        }
        
        public static void findPatientRunner()
        {
            findPatients();
        }
    }
}
