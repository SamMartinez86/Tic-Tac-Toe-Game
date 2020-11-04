using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class TicTacToeLogic
    {
        #region attributes
        //array version of game board
        private string[,] saBoard;
        //number of wins for player 1
        private int iPlayer1Wins;
        //number of wins for player 2
        private int iPlayer2Wins;
        //number of Ties
        private int iTies;
        //enumeration for winning moves
        private WinningMove eWinningMove;
        #endregion

        #region enumerations
        /// <summary>
        /// enumeration that defines types of winning moves
        /// </summary>
        public enum WinningMove
        {
            row1,
            row2,
            row3,
            col1,
            col2,
            col3,
            diag1,
            diag2
        }
        #endregion

        #region constructors
        /// <summary>
        /// tic tac toe constructor to initialize board
        /// </summary>
        public TicTacToeLogic()
        {
            // create 3x3 board
            saBoard = new string[3, 3];
        }
        #endregion

        #region properTies
        /// <summary>
        /// board property 
        /// </summary>
        public string[,] Board
        {
            get
            {
                return saBoard;
            }

            set
            {
                //makes the value equal to the value being passed in 
                saBoard = value;
            }
        }

        /// <summary>
        /// WinningMove property
        /// </summary>
        public WinningMove Winner
        {
            //returns position of winning move
            get
            {
                return eWinningMove;
            }
        }

        /// <summary>
        /// PlayerOne property
        /// </summary>
        public int PlayerOne
        {
            //returns player wins 
            get
            {
                return iPlayer1Wins;
            }
            //sets player wins
            set
            {
                iPlayer1Wins = value;

            }
        }

        /// <summary>
        /// PlayerTwo property
        /// </summary>
        public int PlayerTwo
        {
            //returns player wins 
            get
            {
                return iPlayer2Wins;
            }
            //sets player wins
            set
            {
                iPlayer2Wins = value;
            }
        }

        /// <summary>
        /// Ties property
        /// </summary>
        public int Ties
        {
            //returns Ties
            get
            {
                return iTies;
            }
            //sets Ties
            set
            {
                iTies = value;
            }
        }
        #endregion

        #region methods
        /// <summary>
        /// Check winning move
        /// </summary>
        /// <returns></returns>
        public bool isWinningMove()
        {
            if (saBoard[0, 0] == "X" && saBoard[1, 0] == "X" && saBoard[2, 0] == "X" || saBoard[0, 0] == "O" && saBoard[1, 0] == "O" && saBoard[1, 0] == "O")
            {
                //set winning move to column 1
                eWinningMove = WinningMove.col1;
                return true;//return winning move
            }
            else if (saBoard[0, 1] == "X" && saBoard[1, 1] == "X" && saBoard[2, 1] == "X" || saBoard[0, 1] == "O" && saBoard[1, 1] == "O" && saBoard[2, 1] == "O")
            {
                //set winning move to column 2
                eWinningMove = WinningMove.col2;
                return true;//return winning move
            }
            else if (saBoard[0, 2] == "X" && saBoard[1, 2] == "X" && saBoard[2, 2] == "X" || saBoard[0, 2] == "O" && saBoard[1, 2] == "O" && saBoard[2, 2] == "O")
            {
                //set winning move to column 3
                eWinningMove = WinningMove.col3;
                return true;//return winning move
            }
            else if (saBoard[0, 0] == "X" && saBoard[0, 1] == "X" && saBoard[0, 2] == "X" || saBoard[0, 0] == "O" && saBoard[0, 1] == "O" && saBoard[0, 2] == "O")
            {
                //set winning move to row 1
                eWinningMove = WinningMove.row1;
                return true;//return winning move
            }
            else if (saBoard[1, 0] == "X" && saBoard[1, 1] == "X" && saBoard[1, 2] == "X" || saBoard[1, 0] == "O" && saBoard[1, 1] == "O" && saBoard[1, 2] == "O")
            {
                //set winning move to row 2
                eWinningMove = WinningMove.row2;
                return true;//return winning move
            }
            else if (saBoard[2, 0] == "X" && saBoard[2, 1] == "X" && saBoard[2, 2] == "X" || saBoard[2, 0] == "O" && saBoard[2, 1] == "O" && saBoard[2, 2] == "O")
            {
                //set winning move to row 3
                eWinningMove = WinningMove.row3;
                return true;//winning move
            }
            else if (saBoard[0, 0] == "X" && saBoard[1, 1] == "X" && saBoard[2, 2] == "X" || saBoard[0, 0] == "O" && saBoard[1, 1] == "O" && saBoard[2, 2] == "O")
            {
                //set winning move to diagonal 1
                eWinningMove = WinningMove.diag1;
                return true;//winning move
            }
            else if (saBoard[2, 0] == "X" && saBoard[1, 1] == "X" && saBoard[0, 2] == "X" || saBoard[2, 0] == "O" && saBoard[1, 1] == "O" && saBoard[0, 2] == "O")
            {
                //set winning move to diagonal 2 
                eWinningMove = WinningMove.diag2;
                return true;//winning move
            }

            return false;
        }

        /// <summary>
        /// method clears board
        /// </summary>
        public void ClearBoard()
        {
            //loop through 
            for (int row = saBoard.GetLowerBound(0); row <= saBoard.GetUpperBound(0); row++)
            {
                for (int column = saBoard.GetLowerBound(0); column <= saBoard.GetUpperBound(0); column++)
                {
                    //clear values
                    saBoard[row, column] = "";
                }
            }
        }

        /// <summary>
        /// method checks for tie
        /// </summary>
        /// <returns></returns>
        public bool IsTie()
        {
            int isFillSpace = 0;
            
            // loop through and check for filled spaces
            for (int row = saBoard.GetLowerBound(0); row <= saBoard.GetUpperBound(0); row++)
            {
                for (int column = saBoard.GetLowerBound(1); column <= saBoard.GetUpperBound(1); column++)
                {
                    //checking for space
                    if (saBoard[row, column] != "")
                    {
                        //if free space increment
                        isFillSpace++;
                    }
                }
            }
            if (isWinningMove() == false && isFillSpace == 9)
            {
                //add to ties count
                iTies++;
                //return tie
                return true;
            } 
            //return no tie
            return false;
        }

        /// <summary>
        /// method checks to see if the space clicked is blank
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool IsBlank(string space)
        {
            // if space is blank
            if (space == "")
            {
                return true;
            }//else if not
            else
            {
                return false;
            }
        }

        #endregion

    }
}
