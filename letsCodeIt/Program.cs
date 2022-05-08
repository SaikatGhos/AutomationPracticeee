using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLib;
namespace letsCodeIt
{
    internal class Program:BaseMethods
    {
        static void Main(string[] args)
        {
            driverInitializer(driversType.chrome);
            GoToURL("https://courses.letskodeit.com/practice");
            wait(2000);
            testCases.testCaseRunner();
            close();
            quit();
        }
    }
}
