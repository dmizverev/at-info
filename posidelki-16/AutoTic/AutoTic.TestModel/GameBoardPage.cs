using System;
using AutoTic.Core;
using WatiN.Core;
using System.Collections.Generic;

namespace AutoTic.TestModel
{
    public class GameBoardPage : MyPage
    {

        [Description("A1")]
        public Button btnA1
        {
            get { return Bro.Button(Find.ByName("c7")); }
        }

        [Description("A2")]
        public Button btnA2
        {
            get { return Bro.Button(Find.ByName("c4")); }
        }

        [Description("A3")]
        public Button btnA3
        {
            get { return Bro.Button(Find.ByName("c1")); }
        }

        [Description("B1")]
        public Button btnB1
        {
            get { return Bro.Button(Find.ByName("c8")); }
        }

        [Description("B2")]
        public Button btnB2
        {
            get { return Bro.Button(Find.ByName("c5")); }
        }

        [Description("B3")]
        public Button btnB3
        {
            get { return Bro.Button(Find.ByName("c2")); }
        }

        [Description("C1")]
        public Button btnC1
        {
            get { return Bro.Button(Find.ByName("c9")); }
        }

        [Description("C2")]
        public Button btnC2
        {
            get { return Bro.Button(Find.ByName("c6")); }
        }

        [Description("C3")]
        public Button btnC3
        {
            get { return Bro.Button(Find.ByName("c3")); }
        }

        [Description("Noughts Move First")]
        public RadioButton radioNoughtsMoveFirst
        {
            get { return Bro.RadioButton(Find.ByValue("O")); }
        }

        [Description("Noughts Player Mode")]
        public SelectList lstNoughtsPlayerMode
        {
            get { return Bro.SelectList(Find.ByName("p2")); }
        }


        [Description("Cross Move First")]
        public RadioButton radioCrossMoveFirst
        {
            get { return Bro.RadioButton(Find.ByValue("X")); }
        }

        [Description("Cross Player Mode")]
        public SelectList lstCrossPlayerMode
        {
            get { return Bro.SelectList(Find.ByName("p1")); }
        }

        [Description("Cross Wins Count")]
        public Button btnCrossWinsCount
        {
            get { return Bro.Button(Find.ByName("xWon")); }
        }

        [Description("Cross Wins Percent")]
        public Button btnCrossWinsPercent
        {
            get { return Bro.Button(Find.ByName("xWonPer")); }
        }

        [Description("Noughts Wins Count")]
        public Button btnNoughtsWinsCount
        {
            get { return Bro.Button(Find.ByName("oWon")); }
        }

        [Description("Noughts Wins Percent")]
        public Button btnNoughtsWinsPercent
        {
            get { return Bro.Button(Find.ByName("oWonPer")); }
        }


        [Description("Draws Count")]
        public Button btnDrawsCount
        {
            get { return Bro.Button(Find.ByName("catsGame")); }
        }

        [Description("Draws Percent")]
        public Button btnDrawsPercent
        {
            get { return Bro.Button(Find.ByName("catsGamePer")); }
        }


        [Description("Clear Stats")]
        public Button btnClearStats
        {
            get { return Bro.Button(Find.ByValue("Clear Stats")); }
        }

        [Description("New Game")]
        public Button btnNewGame
        {
            get { return Bro.Button(Find.ByValue("New Game")); }
        }


        public void Move(int cellIndex)
        {
            Dictionary<int, Button> cellByIndex = 
                new Dictionary<int, Button>()
                {
                    {0, btnA1}, {1, btnB1}, {2, btnC1},
                    {3, btnA2}, {4, btnB2}, {5, btnC2},
                    {6, btnA3}, {7, btnB3}, {8, btnC3},
                };

            Button cell = cellByIndex[cellIndex];
            cell.Focus();
            cell.Click();
        }

        public void Move(string cellName)
        {
            var cell = GetButton(cellName);
            cell.Focus();
            cell.Click();
        }

        public override void Show()
        {
            if (!this.Exists())
            {
                WebBrowser.Instance.GoTo(@"http://ostermiller.org/calc/tictactoe.html");
            }

        }

        public override bool Exists()
        {
            return Bro.Title == "Tic-Tac-Toe";
        }

        public void Set(GameConfiguration gameConfiguration)
        {
            if (gameConfiguration.CrossesMovesFirst)
            {
                radioCrossMoveFirst.Checked = true;
            }
            else
            {
                radioNoughtsMoveFirst.Checked = true;
            }

            lstCrossPlayerMode.Select(gameConfiguration.CrossesPlayerType);
            lstNoughtsPlayerMode.Select(gameConfiguration.NoughtsPlayerType);

        }


        public void StartNewGame()
        {
            btnNewGame.Click();
        }

        public GameConfiguration GetStatus()
        {
            GameConfiguration configuration = new GameConfiguration();

            if (radioCrossMoveFirst.Checked)
            {
                configuration.CrossesMovesFirst = true;
            }

            configuration.CrossesPlayerType = lstCrossPlayerMode.SelectedItem;
            configuration.NoughtsPlayerType = lstNoughtsPlayerMode.SelectedItem;

            configuration.CrossesWinsCount = Convert.ToInt32(btnCrossWinsCount.Value);
            configuration.NoughtsWinsCount = Convert.ToInt32(btnNoughtsWinsCount.Value);

            configuration.DrawsCount = Convert.ToInt32(btnDrawsCount.Value);


            configuration.CrossesWinsPercent = Convert.ToInt32(btnNoughtsWinsPercent.Value.TrimEnd('%'));
            configuration.NoughtsWinsPercent = Convert.ToInt32(btnNoughtsWinsPercent.Value.TrimEnd('%'));
            configuration.DrawsPercent = Convert.ToInt32(btnDrawsPercent.Value.TrimEnd('%'));

            return configuration;


        }

        public void ClearStats()
        {
            btnClearStats.Click();
        }

        public void CorssesMoveFirst()
        {
            radioCrossMoveFirst.Checked = true;
        }

        public void NoughtsMoveFirst()
        {
            radioNoughtsMoveFirst.Checked = true;
        }
    }
}