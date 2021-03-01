using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Elucidat.StepDefinition
{
    [Binding]
    class Hooks
    {
        [BeforeScenario]
        public static void BeforeScenario()
        {
            DriverManager.LaunchBrowser();
        }
        [AfterScenario]

        public static void AfterScenario()
        {
            DriverManager.CloseBrowser();
        }

    }
}
