using Elucidat.DriverCode;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Elucidat.Pages
{
    class Assessment : SeleniumMethods
    {
        By ButtonStart = By.Id("pa_602f99d67dab9_p15766ba6ccd-button__text");
        By ButtonGo = By.XPath("//span[@id='pa_602f99d68219c_p17390dca4cb-button__text']");
        By goggles = By.XPath("//div[@id='pa_602f99d685e21_p157047c2abc-card__image-1']");
        By labcoat = By.Id("pa_602f99d685e21_p157047c2abc-card__image-2");
        By shoes = By.Id("pa_602f99d685e21_p157047c2abc-card__image-1738fba5860");
        By Submit1 = By.Id("pa_602f99d685e21_p157047c2bfa-save_button");
        By spilledChemical = By.Id("pa_602f99d689d61_p173907cd8ee-itemInner-1");
        By Submit2 = By.Id("pa_602f99d689d61_p173907cd90d-button__text");
        By spillage = By.Id("pa_602f99d68d87d_p173907cd7b3-answer-3");
        By Submit3 = By.Id("pa_602f99d68d87d_p173907cd90d-button__text");
        By TopofCabinet = By.XPath("//span[@id='pa_602f99d691558_p17395ca1f90-dropper__inner-1']");
        By BelowEyeLevel = By.XPath("//span[@id='pa_602f99d691558_p17395ca1f90-dropper__inner-2']");
        By WindowFront = By.XPath("//a[@id='pa_602f99d691558_p17395ca1e67-dropper-3']");
        By HeatSource = By.XPath("//span[@id='pa_602f99d691558_p17395ca1f90-dropper__inner-17395cc1fa6']");
        By InsideCabinet = By.XPath("//span[@id='pa_602f99d691558_p17395ca1f90-dropper__inner-17395cc2166']");
        By safe = By.XPath("//li[@id='pa_602f99d691558_p17395ca1e6c-dropbox-1']");
        By notsafe = By.XPath("//li[@id='pa_602f99d691558_p17395ca1e6c-dropbox-2']");
        By Submit4 = By.Id("pa_602f99d691558_p17395ca20af-save_button");
        By buttongo2 = By.Id("pa_602f99d697407_p17390dca4cb-button__text");
        By byDrag1 = By.XPath("//strong[text()='Identify hazards']/../../..");
        By byDrop1 = By.XPath("//strong[text()='Decide who may be harmed and how']/../../..");
        By byDrag2 = By.XPath("//strong[text()='Make a record of your findings']/../../..");
        By byDrop2 = By.XPath("//strong[text()='Decide who may be harmed and how']/../../..");
        By Submit5 = By.Id("pa_602f99d69b591_p17394b7e89c-button__text");
        By byDrag3 = By.XPath("//strong[text()='PPE']/../../..");
        By byDrop3 = By.XPath("//strong[text()='Elimination']/../../..");
        By Submit6 = By.Id("pa_602f99d6a06a0_p17394b7e89c-button__text");
        By notallowed = By.Id("pa_602f99d6a5613_p17390f41440-right-button-text");
        By allowed = By.Id("pa_602f99d6a5613_p17390f41447-left-button-text");
        By Submit7 = By.Id("pa_602f99d6a5613_p17390f4145d-button__text");
        By yes = By.Id("pa_602f99d6aa7e0_p173907cd8ee-itemInner-1");
        By Submit8 = By.Id("pa_602f99d6aa7e0_p173907cd90d-button__text");
        By seeResults = By.Id("pa_602f99d6ae60a_p17390dca4cb-button--link");
        By score = By.Id("pa_602f99d6b60cc_p15507291710-text");
        By result = By.Id("pa_602f99d6b60cc_p1738ff52cdc-title");




        public void ClickStart()
        {
            Thread.Sleep(3000);
            ClickOn(ButtonStart, "Submitbutton");
        }
        public void ClickGo()
        {
            Thread.Sleep(3000);
            ClickOn(ButtonGo, "GoButton");
        }
        public void ClickGoggles()
        {
            Thread.Sleep(3000);
            ClickOn(goggles, "Goggles");
        }
        public void LabCoat()
        {
            Thread.Sleep(3000);
            ClickOn(labcoat, "Labcoat");
        }
        public void Shoes()
        {
            Thread.Sleep(3000);
            ClickOn(shoes, "Shoes");
        }
        public void ButtonSubmit1()
        {
            Thread.Sleep(3000);
            ClickOn(Submit1, "Submit1");
        }
        public void SpilledChemical()
        {
            Thread.Sleep(3000);
            ClickOn(spilledChemical, "Submit1");
        }
        public void ButtonSubmit2()
        {
            Thread.Sleep(3000);
            ClickOn(Submit2, "Submit2");
        }
        public void Spillage()
        {
            Thread.Sleep(3000);
            ClickOn(spillage, "spillage");
        }
        public void ButtonSubmit3()
        {
            Thread.Sleep(3000);
            ClickOn(Submit3, "Submit3");
        }
        public void dragdrop1()
        {
            Thread.Sleep(3000);
            dragdrop(TopofCabinet, notsafe);
        }
        public void dragdrop2()
        {
            Thread.Sleep(3000);
            dragdrop(BelowEyeLevel, safe);
        }
        public void dragdrop3()
        {
            Thread.Sleep(3000);
            dragdrop(WindowFront, notsafe);
        }
        public void dragdrop4()
        {
            Thread.Sleep(3000);
            dragdrop(HeatSource, notsafe);
        }
        public void dragdrop5()
        {
            Thread.Sleep(3000);
            dragdrop(InsideCabinet, safe);
        }
        public void ButtonSubmit4()
        {
            Thread.Sleep(3000);
            ClickOn(Submit4, "Submit4");
        }
        public void ClickGo2()
        {
            Thread.Sleep(3000);
            ClickOn(buttongo2, "GoButton");
        }
        public void sortby1()
        {
          Thread.Sleep(3000);
            Sort1(byDrag1, byDrop1);
        }
        public void sortby2()
        {
            Thread.Sleep(3000);
            Sort1(byDrag2, byDrop2);
        }
        public void ButtonSubmit5()
        {
            Thread.Sleep(3000);
            ClickOn(Submit5, "Submit5");
        }
        public void sortby3()
        {
            Thread.Sleep(3000);
            
            Sort1(byDrag3, byDrop3);
        }
        public void ButtonSubmit6()
        {
            Thread.Sleep(3000);
            ClickOn(Submit6, "Submit6");
        }
        public void ClickNotAllowed()
        {
            Thread.Sleep(3000);
            ClickOn(notallowed, "notallowed");
        }
        public void ClickAllowed()
        {
            Thread.Sleep(3000);
            ClickOn(allowed, "allowed");
        }
        public void ButtonSubmit7()
        {
            Thread.Sleep(3000);
            ClickOn(Submit7, "Submit7");
        }
        public void ClickYes()
        {
            Thread.Sleep(3000);
            ClickOn(yes, "yes");
        }
        public void ButtonSubmit8()
        {
            Thread.Sleep(3000);
            ClickOn(Submit8, "Submit8");
        }
        public void SeeResults()
        {
            Thread.Sleep(3000);
            ClickOn(seeResults, "SeeResults");
        }
        public void ScoreDisplayed()
        {
            Thread.Sleep(3000);
         IWebElement element = driver.FindElement(score);
            ElementDisplayed(element);
        }
        public void Result()
        {
            Thread.Sleep(3000);
            IWebElement element = driver.FindElement(result);
            ElementDisplayed(element);
        }


        

    }
}
    
