using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniumtest
{
    class Program
    {
        

        static void Main(string[] args)
        {
//Create reference of browser

           IWebDriver driver = new ChromeDriver(); 


        }


        [SetUp]
        public void initialize() 
        {
            //1- Open the Browser.    
            //2-  Navigate to the Wikipedia site.
            Driver.Navigate().GoToUrl("https://www.wikipedia.org");

            //3- Choose english language.
            Driver.FindElement(By.LinkText("English — Wikipedia — The Free Encyclopedia")).Click();


            //4- Get the search results panel that contains the link for result.
            //Perform Ops
            Driver.FindElement(By.Name("search")).SendKeys("Test Automation");

            Driver.FindElement(By.Name("go")).Click();


            //Again Navigate the page to search the Keyword Unit Testing  
            Driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Test_automation");

        }

        [Test]
        public void ExecuteTest() 
        {


            // Search the element
            IWebElement element = Driver.FindElement(By.Name("search"));


            // Perform Ops
              element.SendKeys("Test Automation");

                Console.WriteLine("Test Automation");
            
        }

        [Test]
          public void UTTest1()
        {
            
            IWebElement element = driver.FindElement(By.Name("Unit Test"));
            //Assert.IsTrue(body.Text.Contains("Unit Testing"));

            Console.WriteLine("Unit Test");
        }

        [Test]
        public void AutomationTest()
        {
            // b- Existence of Test Automation Interface Model picture
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Test_automation#Graphical_User_Interface_(GUI)_testing");

            try
            {
                Assert.IsTrue(driver.FindElement(By.Id("thumbimage")).Displayed);
                Console.Write("Existence of Test Automation Interface Model picture");
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            Console.Read();

            Console.WriteLine(" Test Automation Interface Model picture");
        }

        
        [Test]
        public void BDDTest()
        {
            //6- Search for the link of Behavior driven development and navigate to there

            query.SendKeys("Behavior-drivern Development");
            query.Submit();
            Assert.IsTrue(driver.PageSource.Contains("https://en.wikipedia.org/wiki/Behavior-driven_development"));
            Assert.AreEqual("Behavior-drivern Development - WikipediaSearch", driver.Title);
            driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Behavior-driven_development");

            Console.WriteLine("Behavior-drivern Development");
        }
        public void executetest()
        {

            //Find the element
            IWebElement body = Driver.FindElement(By.TagName("Unit Testing"));
                        Assert.That(Driver.PageSource.Contains("Unit Test"), Is.EqualTo(true),
                                                                  "Unit Test Does not Exits");


                        IWebElement query = driver.FindElement(By.Name("search"));

        }


        [TearDown]
       public void CleanUp() 
       {

        Driver.Close();

         Console.WriteLine("Close the brwoser");
        }
    }
}
