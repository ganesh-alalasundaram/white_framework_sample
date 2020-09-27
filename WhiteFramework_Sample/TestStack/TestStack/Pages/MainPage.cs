using System;
using System.Diagnostics;
using TestStack;
using TestStack.White.UIItems.WindowItems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WPFUIItems;
using System.Threading;
using TestStack.White.UIItems.ListBoxItems;
using System.IO;
using System.Reflection;

namespace TestStack
{
    public class MainPage
    {
        private TestStack.White.Application application;
        public void setupapp()
        {
            string outputDir = new DirectoryInfo(Assembly.GetExecutingAssembly().Location).Parent.FullName;
            string app_path = outputDir+ @"\Microsoft.DAS.Client.Shell.exe";
            application = White.Application.Launch(app_path);
            Window mainWindow = application.GetWindow("MainWindow");
        }
        public void mainWindowTest()
        {
            setupapp();
            Window mainWindow = application.GetWindow("MainWindow");
            TestStack.White.UIItems.Button btnbuttonintoolbar = mainWindow.Get<White.UIItems.Button>(SearchCriteria.ByText("Button in toolbar"));
            btnbuttonintoolbar.Click();
            Thread.Sleep(2000);
            TestStack.White.UIItems.TabItems.TabPage tabList = mainWindow.Get<White.UIItems.TabItems.TabPage>(SearchCriteria.ByText("List Controls"));
            tabList.Click();
            Thread.Sleep(2000);
            TestStack.White.UIItems.TabItems.TabPage tabInput = mainWindow.Get<White.UIItems.TabItems.TabPage>(SearchCriteria.ByText("Input Controls"));
            tabInput.Click();
            Thread.Sleep(2000);
            TestStack.White.UIItems.TabItems.TabPage tabOther = mainWindow.Get<White.UIItems.TabItems.TabPage>(SearchCriteria.ByText("Other Controls"));
            tabOther.Click();
            Thread.Sleep(2000);
            TestStack.White.UIItems.TabItems.TabPage tabData = mainWindow.Get<White.UIItems.TabItems.TabPage>(SearchCriteria.ByText("Data Grid"));
            tabData.Click();
            Thread.Sleep(2000);
            tabList.Click();
            Thread.Sleep(2000);
        }

        public void ListControlTestMainWindow()
        {
            Window mainWindow = application.GetWindow("MainWindow");
            ListBox lnumber = mainWindow.Get<ListBox>("ListBoxWithVScrollBar");
            lnumber.Select(0);
            lnumber.Select(1);
            lnumber.Select(2);
            Thread.Sleep(2000);
            ListBox ltext = mainWindow.Get<ListBox>("ListBoxWpf");
            ltext.Select(0);
            ltext.Select(1);
            ltext.Select(2);
            ltext.Select("Hitchcock");
            Thread.Sleep(2000);
        }

        public void ComboControlTestMainWindow()
        {
            Window mainWindow = application.GetWindow("MainWindow");
            ComboBox cSelect = mainWindow.Get<ComboBox>("AComboBox");
            cSelect.Select(0);
            mainWindow.WaitWhileBusy();
            cSelect.Select("Test4");
            Thread.Sleep(2000);
            ComboBox cEditSelect = mainWindow.Get<ComboBox>("EditableComboBox");
            cEditSelect.Select(0);
            Thread.Sleep(2000);
            cEditSelect.Enter("Test3");
            Thread.Sleep(2000);
            cEditSelect.Select("Test4");
            Thread.Sleep(2000);
            ComboBox cDataSelect = mainWindow.Get<ComboBox>("DataBoundComboBox");
            cDataSelect.Select(0);
            Thread.Sleep(2000);
            cDataSelect.Select(2);
            Thread.Sleep(2000);
        }

        public void CheckControlTestMainWindow()
        {
            Window mainWindow = application.GetWindow("MainWindow");
            ListBox lCheck = mainWindow.Get<ListBox>("CheckedListBox");
            lCheck.Select(0);
            Thread.Sleep(2000);
            lCheck.Check("Item4");
            Thread.Sleep(2000);
            lCheck.UnCheck("Item4");
            Thread.Sleep(2000);
            application.Close();
        }
        
    }
}
