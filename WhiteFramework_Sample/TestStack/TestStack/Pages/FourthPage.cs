using System;
using System.Diagnostics;
using TestStack;
using TestStack.White.UIItems.WindowItems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WPFUIItems;
using System.Threading;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems;

namespace TestStack
{
   public class FourthPage
    {
        private TestStack.White.Application application;
        public void setupapp()
        {
            string app_path = "";//"Download WPFTestApplication from https://github.com/TestStack/White/tree/master/src/TestApplications/WpfTestApplication and paste the path to *exe* here"
            application = White.Application.Launch(app_path);
            Window mainWindow = application.GetWindow("MainWindow");
        }

        public void tstGrid()
        {
            setupapp();
            Window mainWindow = application.GetWindow("MainWindow");
            TestStack.White.UIItems.TabItems.TabPage tabInput = mainWindow.Get<White.UIItems.TabItems.TabPage>(SearchCriteria.ByText("Data Grid"));
            tabInput.Click();
            ListView dataGrid = mainWindow.Get<ListView>(SearchCriteria.ByClassName("DataGrid"));
            var row = dataGrid.Rows[2];
            row.Select();
            Thread.Sleep(3000);
        }


    }
}
