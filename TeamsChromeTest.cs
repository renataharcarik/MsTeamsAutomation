using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace QA_Task{
    public class TeamsChromeTest : CommonTest
    {
        IWebDriver driver;
        WebDriverWait wait;


        [SetUp]
        public override void SetUp()
        {
            Logger.Log("Setting up Chrome test.");
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

        }

        [Test]
        public void ChromeLogin(){
            driver.Url = "https://teams.microsoft.com/";
            driver.Manage().Window.Size = new System.Drawing.Size(800, 600);
            
            //Email
            IWebElement emailInput = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("i0116")));
            emailInput.SendKeys("");
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("idSIButton9"))).Click();
            
            //Password
            IWebElement passwordInput = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("i0118")));
            passwordInput.SendKeys("");
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("idSIButton9"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("idBtn_Back"))).Click();
            
            //Find Automation chat
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(), 'Chat')]"))).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(), 'Automation')]"))).Click();

            // Send a message
            // [Error] cannot identify textbox
            IWebElement chatInput = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//p[@class='ck-placeholder']")));
            chatInput.SendKeys("Your message");
            chatInput.SendKeys(Keys.Enter);
      }

        [Test]
        public void TestSendMessageInChat()
        {
            // Test logic for sending a message in the chat in Chrome
            Logger.Log("Sending a message in the chat in Chrome.");
        }

        [Test]
        public void TestUploadFileToOneDrive()
        {
            // Test logic for uploading a file to OneDrive in Chrome
            Logger.Log("Uploading a file to OneDrive in Chrome.");
        }

        [TearDown]
        public override void TearDown()
        {
            Logger.Log("Tearing down Chrome test.");
            driver.Quit();
        }
    }
}
