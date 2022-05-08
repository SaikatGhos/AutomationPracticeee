using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLib;
namespace letsCodeIt
{
    class testCases:BaseMethods
    {
        private static void radioButton()
        {
            Click(propertype.Xpath, "(//*[@id='radio-btn-example']//child::input)[1]");
            wait(2000);
            Click(propertype.Xpath, "(//*[@id='radio-btn-example']//child::input)[2]");            
            wait(2000);
            Click(propertype.Xpath, "(//*[@id='radio-btn-example']//child::input)[3]");
        }
        private static void selectClassExample()
        {
            Click(propertype.Xpath, "//*[@id='select-class-example']//child::select//option[1]");            
            wait(2000);
            Click(propertype.Xpath, "//*[@id='select-class-example']//child::select//option[2]");
            wait(2000);
            Click(propertype.Xpath, "//*[@id='select-class-example']//child::select//option[3]");
            wait(2000);
        }
        private static void mselectClassExample()
        {
            Click(propertype.Xpath, "(//*[@id='multiple-select-example']//child::option)[1]");
            wait(2000);
            Click(propertype.Xpath, "(//*[@id='multiple-select-example']//child::option)[2]");
            wait(2000);
            Click(propertype.Xpath, "(//*[@id='multiple-select-example']//child::option)[3]");
            wait(2000);
        }
        private static void CheckBox()
        {
            Click(propertype.Xpath, "(//*[@id='checkbox-example-div']//child::input)[1]");
            wait(2000);
            Click(propertype.Xpath, "(//*[@id='checkbox-example-div']//child::input)[2]");
            wait(2000);
            Click(propertype.Xpath, "(//*[@id='checkbox-example-div']//child::input)[3]");
            wait(2000);
        }
        private static void mouseHover()
        {
            MouseHover("//*[@id='mousehover']");
        }
        public static void testCaseRunner()
        {
            radioButton();
            wait(2000);
            selectClassExample();
            wait(2000);
            mselectClassExample();
            wait(2000);
            CheckBox();
            wait(2000);
            mouseHover();
        }

    }
}
