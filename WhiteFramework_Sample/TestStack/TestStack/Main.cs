using System;
using System.Diagnostics;
using TestStack;
using TestStack.White.UIItems.WindowItems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WPFUIItems;
using System.Threading;
using TestStack.White.UIItems.ListBoxItems;

namespace TestStack
{
    [TestClass]
    public class TestStackSample
    {

        [TestMethod]
        public void landingpage()
        {
            MainPage LandingPage = new MainPage();
            LandingPage.mainWindowTest();
            LandingPage.ListControlTestMainWindow();
            LandingPage.ComboControlTestMainWindow();
            LandingPage.CheckControlTestMainWindow();

        }

        [TestMethod]
        public void secondpage()
        {
            SecondPage Sec_Page = new SecondPage();
            Sec_Page.SecondWindowTestDatePicker();
            Sec_Page.SecondWindowTestCheckbox();
            Sec_Page.SecondWindowTestTextBox();
            Sec_Page.SecondWindowTestRadio();

        }

        [TestMethod]
        public void thirdpage()
        {
            ThirdPage third_page = new ThirdPage();
            third_page.ThirdWindowTBtnSlider();
            third_page.thirdwindowNode();
        }
    }
}
   
