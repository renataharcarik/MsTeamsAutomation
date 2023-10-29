using NUnit.Framework;
using OpenQA.Selenium;

namespace QA_Task{
    public abstract class CommonTest
    {

        
        [SetUp]
        public virtual void SetUp()
        {
            Logger.Log("Test started.");
        }

        [TearDown]
        public virtual void TearDown()
        {
            Logger.Log(TestContext.CurrentContext.Result.Outcome.Status.ToString());
            Logger.Log("Test finished.");
        }

        [Test]
        public void Test1()
        {
            Assert.Fail();
        }

        [Test]
        public void Test2()
        {
            Assert.Pass();
        }
    }
}
