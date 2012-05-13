using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoTic.TestModel
{
    public class GameBoard : List<string>
    {

        private int gameboardWidth = 3;
        private int gameboardHeight = 3;

        private string X = "X";
        private string O = "O";
        private string Empty = "";



        public void Set()
        {
            var boradPage = new GameBoardPage();
            var gameBoard = this.ToArray();
            boradPage.Show();
            

            GameConfiguration configuration = new GameConfiguration();
            configuration.UpdateFromCurrentStatus();
            
            bool isCrossMove = configuration.CrossesMovesFirst;

            for (int n = 0; n < gameboardWidth * gameboardHeight; n++)
            {
                for (int x = 0; x < gameboardWidth; x++)
                {
                    for (int y = 0; y < gameboardHeight; y++)
                    {
                        int cellIndex = (y * gameboardHeight) + x;

                        bool isValidCrossMove = String.Compare(X, gameBoard[cellIndex], true) == 0 && isCrossMove;
                        bool isValidNoughtsMove = String.Compare(O, gameBoard[cellIndex], true) == 0 &&
                                                  isCrossMove == false;

                        bool isValidMove = isValidCrossMove || isValidNoughtsMove;

                        if ( isValidMove )
                        {
                            boradPage.Move(cellIndex);
                            gameBoard[cellIndex] = Empty;
                            isCrossMove = !isCrossMove;
                            System.Threading.Thread.Sleep(50);
                        }
                    }
                }
            }

        }

        


    }
}
