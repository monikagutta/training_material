using Elucidat.Pages;
using System;
using TechTalk.SpecFlow;

namespace Elucidat.StepDefinitions
{
    [Binding]
    public class AssessmentSteps
    {
        Assessment assessment = new Assessment();
        [Given(@"User is on Assessment page")]
        public void GivenUserIsOnAssessmentPage()
        {
          
        }
        
        [When(@"User Click on Start button")]
        public void WhenUserClickOnStartButton()
        {
            assessment.ClickStart();
        }
        
        [When(@"User Click on Go button")]
        public void WhenUserClickOnGoButton()
        {
            assessment.ClickGo();
            
        }
        
        [When(@"User Click on Goggles")]
        public void WhenUserClickOnGoggles()
        {
            assessment.ClickGoggles();
        }
        
        [When(@"User Click on Lab coat")]
        public void WhenUserClickOnLabCoat()
        {
            assessment.LabCoat();
        }
        
        [When(@"User Click on Steel toe cap shoes")]
        public void WhenUserClickOnSteelToeCapShoes()
        {
            assessment.Shoes();
        }
        
        [When(@"User Click on Submit button")]
        public void WhenUserClickOnSubmitButton()
        {
            assessment.ButtonSubmit1();
        }
        
        [When(@"User Click on You as you are close to the spillage")]
        public void WhenUserClickOnYouAsYouAreCloseToTheSpillage()
        {
            assessment.SpilledChemical();
        }
        [When(@"User Click on Set up a causion sign in the affected area")]
        public void WhenUserClickOnSetUpACausionSignInTheAffectedArea()
        {
            assessment.Spillage();
        }
        [When(@"User Click on Submit button(.*)")]
        public void WhenUserClickOnSubmitButton2(int p0)
        {
            assessment.ButtonSubmit2();
        }
        [When(@"User Click on Submitthree button")]
        public void WhenUserClickOnSubmitthreeButton()
        {
            assessment.ButtonSubmit3();
        }

        [When(@"user click on On top of a cabinet and drop on unsafe")]
        public void WhenUserClickOnOnTopOfACabinetAndDropOnUnsafe()
        {
            assessment.dragdrop1();
        }
        
        [When(@"user click on Shelving below eye level and drop on safe")]
        public void WhenUserClickOnShelvingBelowEyeLevelAndDropOnSafe()
        {
            assessment.dragdrop2();
        }
        [When(@"user click on In front of a window and drop on unsafe")]
        public void WhenUserClickOnInFrontOfAWindowAndDropOnUnsafe()
        {
            assessment.dragdrop3();
        }
        [When(@"user click on Next to a heat source and drop on unsafe")]
        public void WhenUserClickOnNextToAHeatSourceAndDropOnUnsafe()
        {
            assessment.dragdrop4();
        }
        [When(@"user click on Inside a metal cabinet and drop on safe")]
        public void WhenUserClickOnInsideAMetalCabinetAndDropOnSafe()
        {
            assessment.dragdrop5();
        }
        [When(@"User Click on Submitfour button")]
        public void WhenUserClickOnSubmitfourButton()
        {
            assessment.ButtonSubmit4();
        }
        [When(@"User Click on Go buttontwo")]
        public void WhenUserClickOnGoButtontwo()
        {
            assessment.ClickGo2();
        }
        [When(@"user click on Identify hazard and drop as first")]
        public void WhenUserClickOnIdentifyHazardAndDropAsFirst()
        {
            assessment.sortby1();
        }
        [When(@"user click on make a record of your findings and drop as second")]
        public void WhenUserClickOnMakeARecordOfYourFindingsAndDropAsSecond()
        {
            assessment.sortby2();
        }
        [When(@"user click on Submitfive button")]
        public void WhenUserClickOnSubmitfiveButton()
        {
            assessment.ButtonSubmit5();
        }
        [When(@"user click on PPE and drop as first")]
        public void WhenUserClickOnPPEAndDropAsFirst()
        {
            assessment.sortby3();
        }
        [When(@"User Click on Submitsix button")]
        public void WhenUserClickOnSubmitsixButton()
        {
            assessment.ButtonSubmit6();
        }
        [When(@"user Click on Not allowed for Stud earrings")]
        public void WhenUserClickOnNotAllowedForStudEarrings()
        {
            assessment.ClickNotAllowed();
        }
        [When(@"user Click on Not allowed for loose clothing")]
        public void WhenUserClickOnNotAllowedForLooseClothing()
        {
            assessment.ClickNotAllowed();
        }

        [When(@"user Click on allowed for long hair tied back")]
        public void WhenUserClickOnAllowedForLongHairTiedBack()
        {
            assessment.ClickAllowed();
        }
        [When(@"user Click on Not allowed for sandles")]
        public void WhenUserClickOnNotAllowedForSandles()
        {
            assessment.ClickNotAllowed();
        }
        [When(@"user Click on Not allowed for necklase")]
        public void WhenUserClickOnNotAllowedForNecklase()
        {
            assessment.ClickNotAllowed();
        }
        [When(@"user Click on Not allowed for contact lenses")]
        public void WhenUserClickOnNotAllowedForContactLenses()
        {
            assessment.ClickNotAllowed();
        }
        [When(@"User Click on Submitseven button")]
        public void WhenUserClickOnSubmitsevenButton()
        {
            assessment.ButtonSubmit7();
        }
        [When(@"User Click on Yes- even near misses need to be reported")]
        public void WhenUserClickOnYes_EvenNearMissesNeedToBeReported()
        {
            assessment.ClickYes();
        }
        [When(@"User Click on Submiteight button")]
        public void WhenUserClickOnSubmiteightButton()
        {
            assessment.ButtonSubmit8();
        }
        [When(@"user click on See results button")]
        public void WhenUserClickOnSeeResultsButton()
        {
            assessment.SeeResults();
        }

        [Then(@"should display score")]
        public void ThenShouldDisplayScore()
        {
            assessment.ScoreDisplayed();
        }
        [Then(@"also should display Pass or fail")]
        public void ThenAlsoShouldDisplayPassOrFail()
        {
            assessment.Result();
        }


















    }
}
