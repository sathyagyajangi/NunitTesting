using System;
using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace HockeyIndia
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.hockeyindia.org/");


            driver.Manage().Window.Maximize();

            string handle = driver.CurrentWindowHandle;

            for (int i = 7; i <= 7; i++)


            {
                Thread.Sleep(2000);
                FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li["+i+"]/span", "xpath");

                Thread.Sleep(2000);

                string title = driver.FindElement(By.XPath("/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[" + i + "]/span")).Text; ;

                Console.WriteLine(title);
                if (title.Contains("ABOUT HI"))
                {
                    for (int j = 1; j <= 9; j++)
                    {
                        FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[" + i + "]/span", "xpath");

                        Thread.Sleep(2000);

                        FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[2]/div/ul/li[" + j + "]/a/span", "xpath");

                        driver.Navigate().Back();


                        Thread.Sleep(2000);
                    }
                }

                if (title.Contains("NATIONAL TEAM"))
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[" + i + "]/span", "xpath");

                        Thread.Sleep(2000);
                        FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[3]/div/ul/li[" + k + "]/a/span", "xpath");

                        Thread.Sleep(2000);
                    }
                }


                if (title.Contains("MEDIA"))
                {

                    for (int d = 1; d <= 3; d++)
                    {
                        FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[" + i + "]/span", "xpath");

                        Thread.Sleep(2000);

                        FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[4]/div/ul/li[" + d + "]/a/span", "xpath");

                        Thread.Sleep(2000);
                    }
                }

                if (title.Contains("TECHNICAL"))
                {
                    for (int m = 1; m <= 2; m++)
                    {
                        FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[" + i + "]/span", "xpath");

                        Thread.Sleep(2000);

                        FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[5]/div/ul/li[" + m + "]/span", "xpath");

                        string sTitle = driver.FindElement(By.XPath("/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[5]/div/ul/li[" + m + "]/span")).Text;

                        Console.WriteLine(sTitle);

                        if (sTitle.Contains("HI COACHING EDUCATION PATHWAY"))
                        {
                            FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[5]/div/ul/li[" + m + "]/span", "xpath");

                            Thread.Sleep(2000);
                            for (int a = 1; a <= 5; a++)
                            {
                                FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[" + i + "]/span", "xpath");

                                Thread.Sleep(2000);
                                FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[5]/div/ul/li[" + m + "]/span", "xpath");
                                Thread.Sleep(2000);

                                FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[5]/div/ul/li[1]/ul/li[" + a + "]/a", "xpath");

                                Thread.Sleep(2000);

                                driver.SwitchTo().Window(handle);

                            }
                        }

                        if (sTitle.Contains("IMPORTANT INFORMATION - UMPIRES/TECHNICAL OFFICIALS"))
                        {
                            FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[5]/div/ul/li[" + m + "]/span", "xpath");

                            Thread.Sleep(2000);
                            for (int b = 1; b <= 5; b++)

                            {
                                string title2 = driver.FindElement(By.XPath("/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[5]/div/ul/li[2]/ul/li[" + b + "]/a")).Text;

                                Console.WriteLine(title2);
                                if (title2.Contains("UMPIRE/TECHNICAL OFFICIAL ONLINE TEST"))
                                {
                                    FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[5]/div/ul/li[2]/ul/li[" + b + "]/a", "xpath");



                                    Thread.Sleep(2000);

                                    driver.SwitchTo().Window(handle);
                                }
                                if (!title2.Equals("UMPIRE/TECHNICAL OFFICIAL ONLINE TEST"))
                                {
                                    FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[" + i + "]/span", "xpath");

                                    Thread.Sleep(2000);
                                    FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[5]/div/ul/li[" + m + "]/span", "xpath");
                                    Thread.Sleep(2000);


                                    FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[5]/div/ul/li[2]/ul/li[" + b + "]/a", "xpath");

                                }

                            }


                        }
                    }   
                   for(int n=3;n<=8;n++)
                        {
                            FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[" + i + "]/span", "xpath");

                            Thread.Sleep(2000);

                            



                   
                            FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[5]/div/ul/li[" + n + "]/a/span","xpath");

                            string playerdetails = driver.FindElement(By.XPath("/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[5]/div/ul/li[" + n + "]/a/span")).Text;

                            if (playerdetails.Contains("PLAYER REGISTRATION DETAILS"))
                            {
                                FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[5]/div/ul/li[" + n + "]/a/span", "xpath");

                                driver.SwitchTo().Window(handle);

                            }
                        }



                    

                   
                }
                if (title.Contains("SCHEDULE"))
                {
                    for (int c = 1; c <= 4; c++)
                    {
                        FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[" + i + "]/span", "xpath");

                        Thread.Sleep(2000);

                        

                        string hi = driver.FindElement(By.XPath("/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[6]/div/ul/li[" + c + "]/a/span")).Text;

                        Console.WriteLine(hi);
                        if (hi.Contains("HOCKEY INDIA TMS"))
                        {
                            FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[6]/div/ul/li[" + c + "]/a/span", "xpath");

                            driver.SwitchTo().Window(handle);
                        }


                        else
                        {

                            FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[" + i + "]/span", "xpath");

                            FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[6]/div/ul/li[" + c + "]/a/span", "xpath");

                        }

                        if (hi.Contains("NATIONAL TRAINING CAMPS"))

                        {
                            FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[6]/div/ul/li[" + c + "]/a/span", "xpath");
                            driver.SwitchTo().Window(handle);
                        }
                    }
                }

               if (title.Contains("HALL OF FAME"))
                {

                    for (int o = 1; o <= 9; o++)
                    {
                        FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[" + i + "]/span", "xpath");

                        Thread.Sleep(2000);

                        FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[7]/div/ul/li[" + o + "]/a/span", "xpath");
                        Thread.Sleep(2000);
                    }


                }

            }

    }

        [TestMethod]
        public void temp()

        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.hockeyindia.org/");


            driver.Manage().Window.Maximize();


            string handle = driver.CurrentWindowHandle;

            Console.WriteLine(handle);

        IWebElement element=   driver.FindElement(By.XPath("/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[5]/span"));

            element.Click();
            Thread.Sleep(2000);
            FunctionalLibrary.clickAction(driver, "/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[5]/div/ul/li[2]/span", "xpath");


            Thread.Sleep(2000);


           string title= driver.FindElement(By.XPath("/html/body/div[1]/header/section/div/div/div[2]/nav/ul/li[5]/div/ul/li[2]/ul/li[1]/a")).Text;

            Console.WriteLine(title);
            Thread.Sleep(2000);



           
            




        }

        [TestMethod]

        public void TournamentSquad()
        {

            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://beta-hockeyindia.sportz.io/schedule/tournaments";

            driver.Manage().Window.Maximize();
            string handle = driver.CurrentWindowHandle;

            for (int i=1;i<=19;i++)
            {
               

                FunctionalLibrary.clickAction(driver, "/html/body/div[1]/div/myapp/section/div/div/div/div/section/div/div[2]/div/div/div/div/div[2]/div[2]/div[2]/div[2]/div[" + i + "]/div[1]/div[3]/span[2]","xpath");

                Thread.Sleep(1000);

                FunctionalLibrary.shiftClick(driver, "/html/body/div[1]/div/myapp/section/div/div/div/div/section/div/div[2]/div/div/div/div/div[2]/div[2]/div[2]/div[2]/div[" + i + "]/div[2]/a[1]/span");

                Thread.Sleep(1000);
              
                driver.SwitchTo().Window(handle);
                }

        }
    }
}
