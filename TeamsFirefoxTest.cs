using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace QA_Task{
    public class TeamsFirefoxTest : CommonTest
    {

        IWebDriver driver;
        WebDriverWait wait;

        [SetUp]
        public override void SetUp()
        {
            Logger.Log("Setting up Firefox test.");
            driver = new FirefoxDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

        }
       
        [Test]
        public void FirefoxLogin(){
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
            Logger.Log("Sending a message in the chat in Firefox.");
            //Depending on number of messages in test, consider adding a for cycle
           
        }

        [Test]
        public void TestUploadFileToOneDrive()
        {
            Logger.Log("Uploading a file to OneDrive in Firefox.");
            
        }

        [TearDown]
        public override void TearDown()
        {
            Logger.Log("Tearing down Firefox test.");
            driver.Quit();
        }
    }
}
