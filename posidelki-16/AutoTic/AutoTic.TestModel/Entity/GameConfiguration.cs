using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoTic.TestModel
{
    public class GameConfiguration
    {
        public bool CrossesMovesFirst { get; set; }
        public string NoughtsPlayerType { get; set; }
        public string CrossesPlayerType { get; set; }

        public int CrossesWinsCount { get; set; }
        public int NoughtsWinsCount { get; set; }
        public int DrawsCount { get; set; }


        public int CrossesWinsPercent { get; set; }
        public int NoughtsWinsPercent { get; set; }
        public int DrawsPercent { get; set; }

        public GameConfiguration()
        {
            CrossesMovesFirst = true;
            NoughtsPlayerType = "Human";
            CrossesPlayerType = "Human";
        }

        public void Set()
        {
            var gameBoardPage = new GameBoardPage();
            gameBoardPage.Show();

            gameBoardPage.Set(this);
            if (CrossesMovesFirst)
            {
                gameBoardPage.radioCrossMoveFirst.Checked = true;
            }
        }

        public void UpdateFromCurrentStatus()
        {
            var gameBoardPage = new GameBoardPage();

            var actual = gameBoardPage.GetStatus();

            this.CrossesMovesFirst = actual.CrossesMovesFirst;
            this.CrossesPlayerType = actual.CrossesPlayerType;
            this.CrossesWinsCount = actual.CrossesWinsCount;
            this.CrossesWinsPercent = actual.CrossesWinsPercent;
            this.DrawsCount = actual.DrawsCount;
            this.DrawsPercent = actual.DrawsPercent;
            this.NoughtsPlayerType = actual.NoughtsPlayerType;
            this.NoughtsWinsCount = actual.NoughtsWinsCount;
            this.NoughtsWinsPercent = actual.NoughtsWinsPercent;
        }
    }
}
