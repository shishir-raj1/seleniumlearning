using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace seleniumlearning
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int x = 3;
             double y = 4;
             float z = 'y';
             float varr = Convert.ToInt64(3.55);
             string sx = "Random string";

             Console.WriteLine("Hello world");
             Console.Write("Hello Shishir");
             Console.WriteLine("My First C# Program");

             Console.WriteLine("Enter your name");
             string name = Console.ReadLine();
             Console.WriteLine("Hey hello" + name);

             Console.ReadLine();*/
            /*
            
             Console.Write("test case started ");
             //create the refrence for our browser
             IWebDriver driver = new ChromeDriver();

             //navigate to google page
             driver.Navigate().GoToUrl("http://www.google.com");

             //find the element
             IWebElement element = driver.FindElement(By.Name("q"));

             //performing ops
             element.SendKeys("HelloShishir");

            //close the browser  
            driver.Close();
            Console.Write("test case ended ");
            */
            /*
            public void Initialize()
            {
                //open the browser  
                Console.Write("test case started ");
                driver.Navigate().GoToUrl("http://www.google.com");
            }
            public void ExecuteTest()
            {
                //perform browser operations  
                //find the element
                IWebElement element = driver.FindElement(By.Name("q"));

                //performing ops
                element.SendKeys("HelloShishir");

            }
            public void EndTest()
            {
                //close the browser  
                //close the browser  
                driver.Close();
                Console.Write("test case ended ");
            }
            */

            //create the reference for the browser  
            IWebDriver driver = new ChromeDriver();
            [SetUp]
            public void Initialize()
            {
                //navigate to URL  
                driver.Navigate().GoToUrl("https://www.facebook.com/");
                //Maximize the browser window  
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);
            }
            [Test]
            public void ExecuteTest()
            {
                //identify the username text box  
                IWebElement ele = driver.FindElement(By.Id("email"));
                //enter the username value  
                ele.SendKeys("xyz11@gmail.com");
                Thread.Sleep(2000);
                Console.Write("username value is entered \n");
                //identify the password text box  
                IWebElement ele1 = driver.FindElement(By.Name("pass"));
                //enter the password value  
                ele1.SendKeys("########");
                Console.Write("password is entered \n");
                //click on the Login button  
                IWebElement ele2 = driver.FindElement(By.Id("u_0_b"));
                ele2.Click();
                Thread.Sleep(3000);
                Console.Write("login button is clicked \n");
            }
            [TearDown]
            public void EndTest()
            {
                //close the browser  
                driver.Close();

            }
    }
}
