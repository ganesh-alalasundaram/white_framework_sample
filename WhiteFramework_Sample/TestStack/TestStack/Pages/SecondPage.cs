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
   public class SecondPage
    {
        private TestStack.White.Application application;
        public void setupapp()
        {
            string app_path = @"C:\Users\gasundar\Downloads\White-master\White-master\src\TestApplications\WpfTestApplication\bin\Debug\WpfTestApplication.exe";
            application = White.Application.Launch(app_path);
            Window mainWindow = application.GetWindow("MainWindow");
        }

        public void SecondWindowTestDatePicker()
        {
            setupapp();
            Window mainWindow = application.GetWindow("MainWindow");
            TestStack.White.UIItems.TabItems.TabPage tabInput = mainWindow.Get<White.UIItems.TabItems.TabPage>(SearchCriteria.ByText("Input Controls"));
            tabInput.Click();
            var dateTimePicker = mainWindow.Get<DateTimePicker>("DatePicker");
            var changedDate = DateTime.Today.AddDays(23);
            dateTimePicker.Date = changedDate;
            Assert.AreEqual(dateTimePicker.Date,changedDate);
        }

        public void SecondWindowTestCheckbox()
        {
            Window mainWindow = application.GetWindow("MainWindow");
            //TestStack.White.UIItems.TabItems.TabPage tabInput = mainWindow.Get<White.UIItems.TabItems.TabPage>(SearchCriteria.ByText("Input Controls"));
            //tabInput.Click();
            TestStack.White.UIItems.CheckBox chkSecond = mainWindow.Get<White.UIItems.CheckBox>(SearchCriteria.ByText("A checkbox"));
            chkSecond.Click();
            Thread.Sleep(2000);
            TestStack.White.UIItems.CheckBox tristateChkBox = mainWindow.Get<White.UIItems.CheckBox>(SearchCriteria.ByText("Tristate Checkbox"));
            tristateChkBox.Click();
            Thread.Sleep(2000);
            tristateChkBox.Click();
            Thread.Sleep(2000);
        }

        public void SecondWindowTestTextBox()
        {
            Window mainWindow = application.GetWindow("MainWindow");
            //TestStack.White.UIItems.TabItems.TabPage tabInput = mainWindow.Get<White.UIItems.TabItems.TabPage>(SearchCriteria.ByText("Input Controls"));
            //tabInput.Click();
            TestStack.White.UIItems.TextBox txtBox = mainWindow.Get<White.UIItems.TextBox>(SearchCriteria.ByAutomationId("TextBox"));
            txtBox.Text="Hi This is a Text Box";
            Thread.Sleep(2000);
            TestStack.White.UIItems.TextBox txtmultiline = mainWindow.Get<White.UIItems.TextBox>(SearchCriteria.ByAutomationId("MultiLineTextBox"));
            txtmultiline.Text = "Hi This is a Multi Line Text Box";
            Thread.Sleep(2000);
            //TestStack.White.UIItems.TextBox txtPassword = mainWindow.Get<White.UIItems.TextBox>(SearchCriteria.ByAutomationId("PasswordBox"));
            //txtBox.Text = "Password123";
            Thread.Sleep(2000);
        }

        public void SecondWindowTestRadio()
        {
            Window mainWindow = application.GetWindow("MainWindow");
            //TestStack.White.UIItems.TabItems.TabPage tabInput = mainWindow.Get<White.UIItems.TabItems.TabPage>(SearchCriteria.ByText("Input Controls"));
            //tabInput.Click();
            TestStack.White.UIItems.RadioButton rdoBtn1 = mainWindow.Get<White.UIItems.RadioButton>(SearchCriteria.ByAutomationId("RadioButton1"));
            rdoBtn1.Click();
            Thread.Sleep(2000);
            TestStack.White.UIItems.RadioButton rdoBtn2 = mainWindow.Get<White.UIItems.RadioButton>(SearchCriteria.ByAutomationId("RadioButton2"));
            rdoBtn2.Click();
            Thread.Sleep(2000);
            application.Close();
        }
    }
}
