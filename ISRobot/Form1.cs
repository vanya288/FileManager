using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISRobot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            featuresList.Items.AddRange(this.getColumnNames().ToArray());
        }

        private List<String> getColumnNames()
        {
            List<String> ret = new List<String>();

            using (ISWebService.SWebServiceSoapClient client = new ISWebService.SWebServiceSoapClient())
            {
                ret = client.GetColumnNames();
            }

            return ret;
        }

        // Get a handle to an application window.
        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName,
            string lpWindowName);

        // Activate an application window.
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        private void runTestBtn_Click(object sender, EventArgs e)
        {
            var processDriver = Process.Start(@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");

            AppiumOptions appiumOptions = new AppiumOptions();

            appiumOptions.AddAdditionalCapability("deviceName", "WindowsPC");
            appiumOptions.AddAdditionalCapability("app", @"C:\Users\vanya\source\repos\Lab1\bin\Debug\Lab1.exe");

            WindowsDriver<WindowsElement> fileManagerApp;

            fileManagerApp = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appiumOptions);

            fileManagerApp.FindElementByName("Load from text file").Click();

            Thread.Sleep(1000);

            SendKeys.SendWait(@"C:\Users\vanya\source\repos\Lab1\Data.txt");

            SendKeys.SendWait("{ENTER}");

            Thread.Sleep(1000);

            foreach (Control c in this.Controls)
            {
                string[] skipCols = { "ID", "ManufacturerCountTxt" };

                if (c.GetType().Name == "TextBox" && !skipCols.Contains(c.Name) && c.Text != String.Empty)
                {
                    var cellName = $"{c.Name} Row {Int32.Parse(ID.Text) - 1}";

                    var cell = fileManagerApp.FindElementByName(cellName);

                    cell.Click();

                    cell.SendKeys(c.Text);
                }
            }

            if (ManufacturerCountTxt.Text != String.Empty)
            {
                fileManagerApp.FindElementByAccessibilityId("mfrTxt").SendKeys(ManufacturerCountTxt.Text);

                SendKeys.SendWait("{ENTER}");

                Thread.Sleep(500);

                fileManagerApp.GetScreenshot().SaveAsFile(@"C:\Users\vanya\source\repos\Lab1\Screenshots\Manufacturers count.png");
            }

            foreach (var item in featuresList.CheckedItems)
            {
                fileManagerApp.FindElementByName(item.ToString()).Click();
            }

            if (featuresList.CheckedItems.Count > 0)
            {
                fileManagerApp.FindElementByName("Export from grid to XML").Click();

                Thread.Sleep(1000);

                SendKeys.SendWait(@"C:\Users\vanya\source\repos\Lab1\RobotExportedXML.xml");

                Thread.Sleep(1000);

                SendKeys.SendWait("{ENTER}");
                SendKeys.SendWait("{ENTER}");
            }

            Thread.Sleep(1000);

            fileManagerApp.GetScreenshot().SaveAsFile(@"C:\Users\vanya\source\repos\Lab1\Screenshots\Export.png");

            Process.Start("notepad++.exe", @"C:\Users\vanya\source\repos\Lab1\RobotExportedXML.xml");

            //Thread.Sleep(1000);

            //SendKeys.SendWait("{ENTER}");

            Thread.Sleep(2000);

            Process.Start(@"C:\Users\vanya\source\repos\Lab1\Screenshots\Manufacturers count.png");
            Thread.Sleep(1000);
            SendKeys.SendWait("{ENTER}");

            Thread.Sleep(3000);

            Process.Start(@"C:\Users\vanya\source\repos\Lab1\Screenshots\Export.png");
            Thread.Sleep(1000);
            SendKeys.SendWait("{ENTER}");
        }
    }
}
