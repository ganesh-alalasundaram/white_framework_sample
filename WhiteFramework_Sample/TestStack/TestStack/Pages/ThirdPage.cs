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
    public class ThirdPage
    {
        private TestStack.White.Application application;
        public void setupapp()
        {
            string app_path = @"C:\Users\gasundar\Downloads\White-master\White-master\src\TestApplications\WpfTestApplication\bin\Debug\WpfTestApplication.exe";
            application = White.Application.Launch(app_path);
            Window mainWindow = application.GetWindow("MainWindow");
        }

        public void ThirdWindowTBtnSlider()
        {
            setupapp();
            Window mainWindow = application.GetWindow("MainWindow");
            TestStack.White.UIItems.TabItems.TabPage tabInput = mainWindow.Get<White.UIItems.TabItems.TabPage>(SearchCriteria.ByText("Other Controls"));
            tabInput.Click();
            TestStack.White.UIItems.Hyperlink hlink = mainWindow.Get<White.UIItems.Hyperlink>(SearchCriteria.ByText("Link Text"));
            hlink.Click();
            TestStack.White.UIItems.Button btnaddtextbox= mainWindow.Get<White.UIItems.Button>(SearchCriteria.ByText("Add TextBox"));
            btnaddtextbox.Click();
            btnaddtextbox.Click();
            btnaddtextbox.Click();
            btnaddtextbox.Click();
            TestStack.White.UIItems.Slider sldrOne = mainWindow.Get<White.UIItems.Slider>(SearchCriteria.ByAutomationId("Slider"));
            sldrOne.LargeIncrementButton.Click();
            Thread.Sleep(4000);
            sldrOne.LargeDecrementButton.Click();
            Thread.Sleep(4000);
        }

        public void thirdwindowNode()
        {
            Window mainWindow = application.GetWindow("MainWindow");
            TestStack.White.UIItems.TreeItems.TreeNode nodeOne = mainWindow.Get<White.UIItems.TreeItems.TreeNode>(SearchCriteria.ByText("Root"));
            nodeOne.Select();
            nodeOne.Expand();
            Thread.Sleep(2000);
            TestStack.White.UIItems.TreeItems.TreeNode nodeTwo = mainWindow.Get<White.UIItems.TreeItems.TreeNode>(SearchCriteria.ByText("Child"));
            nodeTwo.Select();
            nodeTwo.Expand();
            Thread.Sleep(2000);
            TestStack.White.UIItems.TreeItems.TreeNode nodeThree = mainWindow.Get<White.UIItems.TreeItems.TreeNode>(SearchCriteria.ByText("Grand Child"));
            nodeThree.Select();
            Thread.Sleep(2000);
            TestStack.White.UIItems.TreeItems.TreeNode nodeFour= mainWindow.Get<White.UIItems.TreeItems.TreeNode>(SearchCriteria.ByText("Lots Of Children"));
            nodeFour.Select();
            nodeFour.Expand();
            Thread.Sleep(1000);
            TestStack.White.UIItems.TreeItems.TreeNode nodeFour_child1 = mainWindow.Get<White.UIItems.TreeItems.TreeNode>(SearchCriteria.ByText("Child1"));
            nodeFour_child1.Select();
            Thread.Sleep(1000);
            TestStack.White.UIItems.TreeItems.TreeNode nodeFour_child2 = mainWindow.Get<White.UIItems.TreeItems.TreeNode>(SearchCriteria.ByText("Child2"));
            nodeFour_child2.Select();
            Thread.Sleep(1000);
            TestStack.White.UIItems.TreeItems.TreeNode nodeFour_child3 = mainWindow.Get<White.UIItems.TreeItems.TreeNode>(SearchCriteria.ByText("Child3"));
            nodeFour_child3.Select();
            Thread.Sleep(1000);
            nodeFour.Collapse();
            Thread.Sleep(2000);
            TestStack.White.UIItems.Button btnAddNode = mainWindow.Get<White.UIItems.Button>(SearchCriteria.ByText("Add Node"));
            btnAddNode.Click();
            btnAddNode.Click();
            Thread.Sleep(2000);
            application.Close();
        }
    }
}
