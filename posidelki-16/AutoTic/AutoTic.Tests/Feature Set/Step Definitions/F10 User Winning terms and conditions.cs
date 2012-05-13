using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using AutoTic.TestModel;

#region ====== NUnit / MSTest
#if !NUNIT
using Microsoft.VisualStudio.TestTools.UnitTesting;
#else
using NUnit.Framework;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using TestInitialize = NUnit.Framework.SetUpAttribute;
using TestCleanup = NUnit.Framework.TearDownAttribute;
using ClassInitialize = NUnit.Framework.TestFixtureTearDownAttribute;
using ClassCleanup = NUnit.Framework.TestFixtureTearDownAttribute;
#endif
#endregion

namespace AutoTic.Tests.Feature_Set.Step_Definitions
{
    [Binding]
    public class F10_User_Winning_terms_and_conditions
    {
        [Given(@"New Game\. The PlayerX is '(.*?)' and PlayerO is '(.*?)'")]
        public void GivenNewGame_ThePlayerXIsHumanAndPlayerOIsHuman(string playerXType, string PlayerOType)
        {
            var config = new GameConfiguration()
                             {
                                 CrossesPlayerType = playerXType,
                                 NoughtsPlayerType = PlayerOType
                             };
            config.Set();
        }

        [Given(@"the Game Statistics is cleared")]
        public void GivenTheGameStatisticsIsCleared()
        {
            var boardPage = new GameBoardPage();
            boardPage.ClearStats();
        }


        [Given(@"Crosses start the game")]
        public void GivenCrossesMovesFirst()
        {
            var boardPage = new GameBoardPage();
            boardPage.CorssesMoveFirst();
        }

        [Given(@"The game situation is the following:")]
        public void GivenTheGameSituationIsTheFollowing(Table table)
        {
            var gameBoard = new GameBoard();
            foreach (var row in table.Rows)
            {
                gameBoard.AddRange(new[] {row["A"],row["B"],row["C"]});
            }
            
            gameBoard.Set();

        }


        [When(@"Crosses make a move to cell '(.*?)'")]
        public void WhenCrossesMakeAMoveToCellC1(string cell)
        {
            var boardPage = new GameBoardPage();
            boardPage.Move(cell);
        }

        [Then(@"Crosses Wins Cound should be '(\d+)'")]
        public void ThenPlayerXWinsCoundShouldBe1(int WinsCount)
        {
            var configuration = new GameConfiguration();
            configuration.UpdateFromCurrentStatus();
            Assert.AreEqual(WinsCount, configuration.NoughtsWinsCount);
        }
    }
}
