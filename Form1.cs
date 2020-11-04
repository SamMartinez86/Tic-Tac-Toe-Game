using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class Form1 : Form
    {

        #region attributes
        //make object of class TicTacToeLogic
        TicTacToeLogic TicTacToeL;
        //bool check game status
        bool bIsGameStarted;
        //bool checks players turn
        bool IsPlayerOne;
        #endregion

        #region constructor
        /// <summary>
        /// TicTacToe partial class constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            TicTacToeL = new TicTacToeLogic();
            // Game state set to false
            bIsGameStarted = false;
        }
        #endregion

        #region Methods

        #region Helper Methods

        /// <summary>
        /// method clears all labels
        /// </summary>
        private void ClrLbl()
        {
            // clear game status
            status.Text = "";
            status.Visible = true;
            // reset scores 
            player1WinCnt.Text = TicTacToeL.PlayerOne.ToString();
            player2WinCnt.Text = TicTacToeL.PlayerTwo.ToString();
            TieCnt.Text = TicTacToeL.Ties.ToString();
            //clear tic tac toe squares to blank lbl.text =“”; 
            TicTacToeL.ClearBoard();
        }

        /// <summary>
        /// method resets background color for labels
        /// </summary>
        private void ResetColors()
        {
            ///set all labels to background color, ActiveCaption
            TopLeft.BackColor = SystemColors.ActiveCaption;
            TopMiddle.BackColor = SystemColors.ActiveCaption;
            TopRight.BackColor = SystemColors.ActiveCaption;
            MiddleLeft.BackColor = SystemColors.ActiveCaption;
            MiddleMiddle.BackColor = SystemColors.ActiveCaption;
            MiddleRight.BackColor = SystemColors.ActiveCaption;
            BottomLeft.BackColor = SystemColors.ActiveCaption;
            BottomMiddle.BackColor = SystemColors.ActiveCaption;
            BottomRight.BackColor = SystemColors.ActiveCaption;
        }

        /// <summary>
        /// method displays scores
        /// </summary>
        private void Displayscores()
        {
            //display player 1 wins
            player1WinCnt.Text = TicTacToeL.PlayerOne.ToString();
            //display player 2 wins
            player2WinCnt.Text = TicTacToeL.PlayerTwo.ToString();
            //display Ties
            TieCnt.Text = TicTacToeL.Ties.ToString();
        }

        /// <summary>
        /// method sets winning color
        /// </summary>
        private void SetWinningColor()
        {
            //If win was on column 1
            if (TicTacToeL.Winner == TicTacToeLogic.WinningMove.col1)
            {
                //set column 1 to Gold
                TopLeft.BackColor = Color.Gold;
                MiddleLeft.BackColor = Color.Gold;
                BottomLeft.BackColor = Color.Gold;
            }
            //If win was on column 2
            else if (TicTacToeL.Winner == TicTacToeLogic.WinningMove.col2)
            {
                //set column 2 to Gold 
                TopMiddle.BackColor = Color.Gold;
                MiddleMiddle.BackColor = Color.Gold;
                BottomMiddle.BackColor = Color.Gold;
            }
            //if win was on column 3
            else if (TicTacToeL.Winner == TicTacToeLogic.WinningMove.col3)
            {
                //set column 3 to Gold 
                TopRight.BackColor = Color.Gold;
                MiddleRight.BackColor = Color.Gold;
                BottomRight.BackColor = Color.Gold;
            }
            //if win was on row 1
            else if (TicTacToeL.Winner == TicTacToeLogic.WinningMove.row1)
            {
                //set row 1 to Gold 
                TopLeft.BackColor = Color.Gold;
                TopMiddle.BackColor = Color.Gold;
                TopRight.BackColor = Color.Gold;
            }
            //if win was on row 2
            else if (TicTacToeL.Winner == TicTacToeLogic.WinningMove.row2)
            {
                //set row 2 to Gold  
                MiddleLeft.BackColor = Color.Gold;
                MiddleMiddle.BackColor = Color.Gold;
                MiddleRight.BackColor = Color.Gold;
            }
            //if win was on row 3
            else if (TicTacToeL.Winner == TicTacToeLogic.WinningMove.row3)
            {
                //set row 3 to Gold   
                BottomLeft.BackColor = Color.Gold;
                BottomMiddle.BackColor = Color.Gold;
                BottomRight.BackColor = Color.Gold;
            }
            //if win was diagonal 1
            else if (TicTacToeL.Winner == TicTacToeLogic.WinningMove.diag1)
            {
                //set diagonal 1 to Gold 
                TopLeft.BackColor = Color.Gold;
                MiddleMiddle.BackColor = Color.Gold;
                BottomRight.BackColor = Color.Gold;
            }
            //if win was diagonal 2
            else if (TicTacToeL.Winner == TicTacToeLogic.WinningMove.diag2)
            {
                //set diagonal 2 to Gold 
                TopRight.BackColor = Color.Gold;
                MiddleMiddle.BackColor = Color.Gold;
                BottomLeft.BackColor = Color.Gold;
            }
        }


        /// <summary>
        /// method enablesButtons 
        /// </summary>
        private void EnableButtons()
        {
            // all button are set to true game has started
            resetButton.Enabled = true;
            TopLeft.Enabled = true;
            TopMiddle.Enabled = true;
            TopRight.Enabled = true;
            MiddleLeft.Enabled = true;
            MiddleMiddle.Enabled = true;
            MiddleRight.Enabled = true;
            BottomLeft.Enabled = true;
            BottomMiddle.Enabled = true;
            BottomRight.Enabled = true;
        }

        /// <summary>
        /// method DisableButtons
        /// </summary>
        private void DisableButtons()
        {
            //disabling all buttons
            TopLeft.Enabled = false;
            TopMiddle.Enabled = false;
            TopRight.Enabled = false;
            MiddleLeft.Enabled = false;
            MiddleMiddle.Enabled = false;
            MiddleRight.Enabled = false;
            BottomLeft.Enabled = false;
            BottomMiddle.Enabled = false;
            BottomRight.Enabled = false;
        }

        /// <summary>
        /// method ResetBoard 
        /// </summary>
        private void ResetBoard()
        {
            //reset labels
            TopLeft.Text = "";
            TopMiddle.Text = "";
            TopRight.Text = "";
            MiddleLeft.Text = "";
            MiddleMiddle.Text = "";
            MiddleRight.Text = "";
            BottomLeft.Text = "";
            BottomMiddle.Text = "";
            BottomRight.Text = "";

            //set elements to 0
            TicTacToeL.Board[0, 0] = TopLeft.Text;
            TicTacToeL.Board[0, 1] = TopMiddle.Text;
            TicTacToeL.Board[0, 2] = TopRight.Text;
            TicTacToeL.Board[1, 0] = MiddleLeft.Text;
            TicTacToeL.Board[1, 1] = MiddleMiddle.Text;
            TicTacToeL.Board[1, 2] = MiddleRight.Text;
            TicTacToeL.Board[2, 0] = BottomLeft.Text;
            TicTacToeL.Board[2, 1] = BottomMiddle.Text;
            TicTacToeL.Board[2, 2] = BottomRight.Text;
        }

        /// <summary>
        /// method for PlayerInput
        /// </summary>
        private void PlayerInput(Label spaceClicked)
        {


            //if player one make X
            if (IsPlayerOne)
            {
                spaceClicked.Text = "X";
            }
            //else player two make O
            else
            {
                spaceClicked.Text = "O";
            }

            //set game board 
            if (spaceClicked == TopLeft)
            {
                TicTacToeL.Board[0, 0] = spaceClicked.Text;
            }
            else if (spaceClicked == TopMiddle)
            {
                TicTacToeL.Board[0, 1] = spaceClicked.Text;
            }
            else if (spaceClicked == TopRight)
            {
                TicTacToeL.Board[0, 2] = spaceClicked.Text;
            }
            else if (spaceClicked == MiddleLeft)
            {
                TicTacToeL.Board[1, 0] = spaceClicked.Text;
            }
            else if (spaceClicked == MiddleMiddle)
            {
                TicTacToeL.Board[1, 1] = spaceClicked.Text;
            }
            else if (spaceClicked == MiddleRight)
            {
                TicTacToeL.Board[1, 2] = spaceClicked.Text;
            }
            else if (spaceClicked == BottomLeft)
            {
                TicTacToeL.Board[2, 0] = spaceClicked.Text;
            }
            else if (spaceClicked == BottomMiddle)
            {
                TicTacToeL.Board[2, 1] = spaceClicked.Text;
            }
            else if (spaceClicked == BottomRight)
            {
                TicTacToeL.Board[2, 2] = spaceClicked.Text;
            }

        }

        #endregion

        #region Button Methods
        /// <summary>
        /// When startGameButton is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void strtGameButton_Click(object sender, EventArgs e)
        {
            // game state set to true
            bIsGameStarted = true;
            // player one true
            IsPlayerOne = true;
            // enables button property
            EnableButtons();
            // clear game board
            ClrLbl();
            ResetColors();
            ResetBoard();
            // start button can't be presses until new game starts
            strtGameButton.Enabled = false;
        }

        /// <summary>
        /// When resetButton is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            // reset all scores 
            TicTacToeL.PlayerOne = 0;
            TicTacToeL.PlayerTwo = 0;
            TicTacToeL.Ties = 0;
            // clear game board
            ClrLbl();
            ResetColors();
            ResetBoard();
            // set displays to 0
            player1WinCnt.Text = TicTacToeL.PlayerOne.ToString();
            player2WinCnt.Text = TicTacToeL.PlayerTwo.ToString();
            TieCnt.Text = TicTacToeL.Ties.ToString();

        }

        /// <summary>
        /// this is the spaceClick method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpaceClick(object sender, EventArgs e)
        {
            // If game Is started
            if (bIsGameStarted)
            {
                //make label 
                Label signal = (Label)sender;

                //if label blank
                if (TicTacToeL.IsBlank(signal.Text))
                {
                    //send reference to player input
                    PlayerInput(signal);
                }
                //check if winning move
                if (TicTacToeL.isWinningMove())
                {
                    //increment player one win count
                    if (IsPlayerOne)
                    {
                        //increment player one wins
                        TicTacToeL.PlayerOne += 1;
                        //display winner status
                        status.Text = "Player 1 wins!";
                    }
                    else
                    {
                        //increment player two wins
                        TicTacToeL.PlayerTwo += 1;
                        //display winner status
                        status.Text = "Player 2 wins!";
                    }
                    //highlighting the winning spaces
                    SetWinningColor();
                    //setting game started to false
                    bIsGameStarted = false;
                    DisableButtons();
                    //displaying the scores 
                    Displayscores();
                    //letting user click start button again
                    strtGameButton.Enabled = true;

                }
                else
                {
                    //checking for a tie
                    if (TicTacToeL.IsTie())
                    {
                        //setting the winner display text to a tie
                        status.Text = "Its a Tie!";
                        //letting user click start button again
                        strtGameButton.Enabled = true;
                    }
                    //displaying the scores 
                    Displayscores();
                }
            }
            //bool to see who's playing then switch
            if (IsPlayerOne)
            {
                IsPlayerOne = false;
            }
            else
            {
                IsPlayerOne = true;
            }
        }
        #endregion

        #endregion

        /// <summary>
        /// These are some different paint events I did just for appearance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region Fun With paint

        #region Button Style

        private void strtGameButton_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, strtGameButton.ClientRectangle,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset);
        }

        private void resetButton_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, resetButton.ClientRectangle,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset);
        }

        #endregion

        #region TicTacToeHashTag

        private void vertLine1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, vertLine1.ClientRectangle,
            SystemColors.ControlLightLight, 4, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 4, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 4, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 4, ButtonBorderStyle.Outset);

        }

        private void HorzLine1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, HorzLine1.ClientRectangle,
            SystemColors.ControlLightLight, 4, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 4, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 4, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 4, ButtonBorderStyle.Outset);
        }

        private void VertLine2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, VertLine2.ClientRectangle,
            SystemColors.ControlLightLight, 4, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 4, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 4, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 4, ButtonBorderStyle.Outset);
        }

        private void HorzLine2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, HorzLine2.ClientRectangle,
            SystemColors.ControlLightLight, 4, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 4, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 4, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 4, ButtonBorderStyle.Outset);
        }



        #endregion

        #region Group box shading
        private void gameStatusBox_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, gameStatusBox.ClientRectangle,
            SystemColors.ControlLightLight, 1, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 1, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset);
        }

        private void statsGrpBox_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, statsGrpBox.ClientRectangle,
            SystemColors.ControlLightLight, 1, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 1, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset);
        }

        #endregion

        #endregion
    }
}
