using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using WatiN.Core;

namespace AutoTic.Tests.BadExamples
{
    [Binding]
    public class Steps
    {
        public IE Br { 
            get
            {
                if (!ScenarioContext.Current.ContainsKey("Browser") || ScenarioContext.Current["Browser"] == null)
                {
                    ScenarioContext.Current["Browser"] = new IE();
                }

                return ScenarioContext.Current["Browser"] as IE;
            }
        }

        [Given(@"^I am on the page '(.+?)'")]
        public void GivenIAmOnThePage(string url)
        {
            Br.GoTo(url);
        }


        [Given(@"I have Started new Game ‘Human’ vs ‘Human’")]
        public void GivenIHaveStartedNewGameHumanVsHuman()
        {
            Br.SelectList(Find.ByName("p1")).Select("Human");
            Br.SelectList(Find.ByName("p2")).Select("Human");

            Br.Button(Find.ByValue(@"New Game")).Click();
            Br.Button(Find.ByValue(@"Clear Stats")).Click();
        }


        [Then(@"the Player X Won count should be '1'")]
        public void ThenThePlayerXWonCountShouldBe1()
        {
            var btnPlayerXStats = Br.Button(Find.ByName("xWon"));            
            Assert.AreEqual("1", btnPlayerXStats.Value);
        }


        [When(@"^I press the Button '(.+?)'")]
        [Given(@"^I have pressed the Button '(.+?)'")]
        public void GivenIHavePressedTheButton(string btnName)
        {
            Br.Button(Find.ByName(btnName)).Click();
        }




    }
}
