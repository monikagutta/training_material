using Elucidat.StepDefinition;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Elucidat.DriverCode
{
    class SeleniumMethods : DriverManager
    {
        public void ClickOn(By locator, string locatorName)
        {
            try
            {
                driver.FindElement(locator).Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to click on in :-" + locatorName + "Error message " + ex);
                Assert.IsTrue(false, "Failed to click on in :-" + locatorName + "Error message " + ex);

            }
        }
        public void dragdrop(By draglocator,By droplocator)
        {
            try
            {
                Actions act = new Actions(driver);
                IWebElement From = driver.FindElement(draglocator);
                IWebElement To = driver.FindElement(droplocator);
                act.DragAndDrop(From, To).Build().Perform();
   
                
            }
            catch (Exception ex)
            {


                Console.WriteLine("Failed to dragdrop :-" + draglocator + "Error message " + ex);
                Assert.IsTrue(false, "Failed to dragdrop :-" + draglocator + "Error message " + ex);
            }
        }

        public void Sort1(By draglocator, By droplocator)
        {
            try
            {
                Thread.Sleep(5000);

                IWebElement drag = driver.FindElement(draglocator);
                IWebElement drop = driver.FindElement(droplocator);

                Actions builder = new Actions(driver);
                builder.ClickAndHold(drag)
                .MoveToElement(drag)
                .Release(drop)
                .Build().Perform();

                Console.WriteLine("PASS");


            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
            public bool ElementDisplayed(IWebElement element)
            {
                bool status;
                try
                {
                    status = element.Displayed;
                }
                catch (Exception)
                {

                    status = false;
                }

                return status;
            }

        
    }

}
