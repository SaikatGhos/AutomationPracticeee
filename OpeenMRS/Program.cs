using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLib;
namespace OpeenMRS
{
    internal class Program:BaseMethods
    {
        static void Main(string[] args)
        {
            driverInitializer(driversType.chrome);
            wait(2000);
            loginLogoutReg.loginLogoutRunner();
            wait(3000);
            findPatient.findPatientRunner();
            wait(5000);
            close();
            quit();
        }
    }
}
