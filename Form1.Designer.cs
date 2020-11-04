namespace TicTacToeGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.strtGameButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.statsGrpBox = new System.Windows.Forms.GroupBox();
            this.TieCnt = new System.Windows.Forms.Label();
            this.player2WinCnt = new System.Windows.Forms.Label();
            this.player1WinCnt = new System.Windows.Forms.Label();
            this.Ties = new System.Windows.Forms.Label();
            this.player2Wins = new System.Windows.Forms.Label();
            this.player1Wins = new System.Windows.Forms.Label();
            this.vertLine1 = new System.Windows.Forms.Label();
            this.VertLine2 = new System.Windows.Forms.Label();
            this.HorzLine1 = new System.Windows.Forms.Label();
            this.HorzLine2 = new System.Windows.Forms.Label();
            this.TopLeft = new System.Windows.Forms.Label();
            this.TopMiddle = new System.Windows.Forms.Label();
            this.TopRight = new System.Windows.Forms.Label();
            this.MiddleLeft = new System.Windows.Forms.Label();
            this.BottomLeft = new System.Windows.Forms.Label();
            this.MiddleMiddle = new System.Windows.Forms.Label();
            this.MiddleRight = new System.Windows.Forms.Label();
            this.BottomMiddle = new System.Windows.Forms.Label();
            this.BottomRight = new System.Windows.Forms.Label();
            this.gameStatusBox = new System.Windows.Forms.GroupBox();
            this.status = new System.Windows.Forms.Label();
            this.statsGrpBox.SuspendLayout();
            this.gameStatusBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // strtGameButton
            // 
            this.strtGameButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.strtGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.strtGameButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strtGameButton.Location = new System.Drawing.Point(358, 235);
            this.strtGameButton.Name = "strtGameButton";
            this.strtGameButton.Size = new System.Drawing.Size(107, 68);
            this.strtGameButton.TabIndex = 16;
            this.strtGameButton.Text = "Start Game";
            this.strtGameButton.UseVisualStyleBackColor = false;
            this.strtGameButton.Click += new System.EventHandler(this.strtGameButton_Click);
            this.strtGameButton.Paint += new System.Windows.Forms.PaintEventHandler(this.strtGameButton_Paint);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.resetButton.Enabled = false;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(493, 235);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(104, 68);
            this.resetButton.TabIndex = 17;
            this.resetButton.Text = "Reset Scores";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            this.resetButton.Paint += new System.Windows.Forms.PaintEventHandler(this.resetButton_Paint);
            // 
            // statsGrpBox
            // 
            this.statsGrpBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.statsGrpBox.Controls.Add(this.TieCnt);
            this.statsGrpBox.Controls.Add(this.player2WinCnt);
            this.statsGrpBox.Controls.Add(this.player1WinCnt);
            this.statsGrpBox.Controls.Add(this.Ties);
            this.statsGrpBox.Controls.Add(this.player2Wins);
            this.statsGrpBox.Controls.Add(this.player1Wins);
            this.statsGrpBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsGrpBox.Location = new System.Drawing.Point(358, 30);
            this.statsGrpBox.Margin = new System.Windows.Forms.Padding(2);
            this.statsGrpBox.Name = "statsGrpBox";
            this.statsGrpBox.Padding = new System.Windows.Forms.Padding(2);
            this.statsGrpBox.Size = new System.Drawing.Size(239, 173);
            this.statsGrpBox.TabIndex = 18;
            this.statsGrpBox.TabStop = false;
            this.statsGrpBox.Text = "Statistics";
            this.statsGrpBox.Paint += new System.Windows.Forms.PaintEventHandler(this.statsGrpBox_Paint);
            // 
            // TieCnt
            // 
            this.TieCnt.AutoSize = true;
            this.TieCnt.Location = new System.Drawing.Point(121, 109);
            this.TieCnt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TieCnt.Name = "TieCnt";
            this.TieCnt.Size = new System.Drawing.Size(16, 14);
            this.TieCnt.TabIndex = 24;
            this.TieCnt.Text = "0";
            // 
            // player2WinCnt
            // 
            this.player2WinCnt.AutoSize = true;
            this.player2WinCnt.Location = new System.Drawing.Point(121, 67);
            this.player2WinCnt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player2WinCnt.Name = "player2WinCnt";
            this.player2WinCnt.Size = new System.Drawing.Size(16, 14);
            this.player2WinCnt.TabIndex = 23;
            this.player2WinCnt.Text = "0";
            // 
            // player1WinCnt
            // 
            this.player1WinCnt.AutoSize = true;
            this.player1WinCnt.Location = new System.Drawing.Point(121, 29);
            this.player1WinCnt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player1WinCnt.Name = "player1WinCnt";
            this.player1WinCnt.Size = new System.Drawing.Size(16, 14);
            this.player1WinCnt.TabIndex = 22;
            this.player1WinCnt.Text = "0";
            // 
            // Ties
            // 
            this.Ties.AutoSize = true;
            this.Ties.Location = new System.Drawing.Point(4, 109);
            this.Ties.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ties.Name = "Ties";
            this.Ties.Size = new System.Drawing.Size(39, 14);
            this.Ties.TabIndex = 21;
            this.Ties.Text = "Ties:";
            // 
            // player2Wins
            // 
            this.player2Wins.AutoSize = true;
            this.player2Wins.Location = new System.Drawing.Point(4, 67);
            this.player2Wins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player2Wins.Name = "player2Wins";
            this.player2Wins.Size = new System.Drawing.Size(109, 14);
            this.player2Wins.TabIndex = 20;
            this.player2Wins.Text = "Player 2 Wins: ";
            // 
            // player1Wins
            // 
            this.player1Wins.AutoSize = true;
            this.player1Wins.Location = new System.Drawing.Point(4, 29);
            this.player1Wins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player1Wins.Name = "player1Wins";
            this.player1Wins.Size = new System.Drawing.Size(109, 14);
            this.player1Wins.TabIndex = 19;
            this.player1Wins.Text = "Player 1 Wins: ";
            // 
            // vertLine1
            // 
            this.vertLine1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vertLine1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vertLine1.Location = new System.Drawing.Point(130, 30);
            this.vertLine1.Name = "vertLine1";
            this.vertLine1.Size = new System.Drawing.Size(5, 310);
            this.vertLine1.TabIndex = 19;
            this.vertLine1.Paint += new System.Windows.Forms.PaintEventHandler(this.vertLine1_Paint);
            // 
            // VertLine2
            // 
            this.VertLine2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.VertLine2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VertLine2.Location = new System.Drawing.Point(235, 30);
            this.VertLine2.Name = "VertLine2";
            this.VertLine2.Size = new System.Drawing.Size(5, 310);
            this.VertLine2.TabIndex = 20;
            this.VertLine2.Paint += new System.Windows.Forms.PaintEventHandler(this.VertLine2_Paint);
            // 
            // HorzLine1
            // 
            this.HorzLine1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HorzLine1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HorzLine1.Location = new System.Drawing.Point(30, 130);
            this.HorzLine1.Name = "HorzLine1";
            this.HorzLine1.Size = new System.Drawing.Size(310, 5);
            this.HorzLine1.TabIndex = 21;
            this.HorzLine1.Paint += new System.Windows.Forms.PaintEventHandler(this.HorzLine1_Paint);
            // 
            // HorzLine2
            // 
            this.HorzLine2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HorzLine2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HorzLine2.Location = new System.Drawing.Point(30, 235);
            this.HorzLine2.Name = "HorzLine2";
            this.HorzLine2.Size = new System.Drawing.Size(310, 5);
            this.HorzLine2.TabIndex = 22;
            this.HorzLine2.Paint += new System.Windows.Forms.PaintEventHandler(this.HorzLine2_Paint);
            // 
            // TopLeft
            // 
            this.TopLeft.Enabled = false;
            this.TopLeft.Font = new System.Drawing.Font("Yu Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopLeft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TopLeft.Location = new System.Drawing.Point(30, 30);
            this.TopLeft.Name = "TopLeft";
            this.TopLeft.Size = new System.Drawing.Size(100, 100);
            this.TopLeft.TabIndex = 23;
            this.TopLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopLeft.Click += new System.EventHandler(this.SpaceClick);
            // 
            // TopMiddle
            // 
            this.TopMiddle.Enabled = false;
            this.TopMiddle.Font = new System.Drawing.Font("Yu Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopMiddle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TopMiddle.Location = new System.Drawing.Point(135, 30);
            this.TopMiddle.Name = "TopMiddle";
            this.TopMiddle.Size = new System.Drawing.Size(100, 100);
            this.TopMiddle.TabIndex = 24;
            this.TopMiddle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopMiddle.Click += new System.EventHandler(this.SpaceClick);
            // 
            // TopRight
            // 
            this.TopRight.Enabled = false;
            this.TopRight.Font = new System.Drawing.Font("Yu Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopRight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TopRight.Location = new System.Drawing.Point(240, 30);
            this.TopRight.Name = "TopRight";
            this.TopRight.Size = new System.Drawing.Size(100, 100);
            this.TopRight.TabIndex = 25;
            this.TopRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopRight.Click += new System.EventHandler(this.SpaceClick);
            // 
            // MiddleLeft
            // 
            this.MiddleLeft.Enabled = false;
            this.MiddleLeft.Font = new System.Drawing.Font("Yu Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleLeft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MiddleLeft.Location = new System.Drawing.Point(30, 135);
            this.MiddleLeft.Name = "MiddleLeft";
            this.MiddleLeft.Size = new System.Drawing.Size(100, 100);
            this.MiddleLeft.TabIndex = 26;
            this.MiddleLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MiddleLeft.Click += new System.EventHandler(this.SpaceClick);
            // 
            // BottomLeft
            // 
            this.BottomLeft.Enabled = false;
            this.BottomLeft.Font = new System.Drawing.Font("Yu Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomLeft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BottomLeft.Location = new System.Drawing.Point(30, 240);
            this.BottomLeft.Name = "BottomLeft";
            this.BottomLeft.Size = new System.Drawing.Size(100, 100);
            this.BottomLeft.TabIndex = 27;
            this.BottomLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BottomLeft.Click += new System.EventHandler(this.SpaceClick);
            // 
            // MiddleMiddle
            // 
            this.MiddleMiddle.Enabled = false;
            this.MiddleMiddle.Font = new System.Drawing.Font("Yu Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleMiddle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MiddleMiddle.Location = new System.Drawing.Point(135, 135);
            this.MiddleMiddle.Name = "MiddleMiddle";
            this.MiddleMiddle.Size = new System.Drawing.Size(100, 100);
            this.MiddleMiddle.TabIndex = 28;
            this.MiddleMiddle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MiddleMiddle.Click += new System.EventHandler(this.SpaceClick);
            // 
            // MiddleRight
            // 
            this.MiddleRight.Enabled = false;
            this.MiddleRight.Font = new System.Drawing.Font("Yu Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleRight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MiddleRight.Location = new System.Drawing.Point(240, 135);
            this.MiddleRight.Name = "MiddleRight";
            this.MiddleRight.Size = new System.Drawing.Size(100, 100);
            this.MiddleRight.TabIndex = 29;
            this.MiddleRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MiddleRight.Click += new System.EventHandler(this.SpaceClick);
            // 
            // BottomMiddle
            // 
            this.BottomMiddle.Enabled = false;
            this.BottomMiddle.Font = new System.Drawing.Font("Yu Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomMiddle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BottomMiddle.Location = new System.Drawing.Point(135, 240);
            this.BottomMiddle.Name = "BottomMiddle";
            this.BottomMiddle.Size = new System.Drawing.Size(100, 100);
            this.BottomMiddle.TabIndex = 30;
            this.BottomMiddle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BottomMiddle.Click += new System.EventHandler(this.SpaceClick);
            // 
            // BottomRight
            // 
            this.BottomRight.Enabled = false;
            this.BottomRight.Font = new System.Drawing.Font("Yu Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomRight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BottomRight.Location = new System.Drawing.Point(240, 240);
            this.BottomRight.Name = "BottomRight";
            this.BottomRight.Size = new System.Drawing.Size(100, 100);
            this.BottomRight.TabIndex = 31;
            this.BottomRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BottomRight.Click += new System.EventHandler(this.SpaceClick);
            // 
            // gameStatusBox
            // 
            this.gameStatusBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gameStatusBox.Controls.Add(this.status);
            this.gameStatusBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStatusBox.Location = new System.Drawing.Point(51, 364);
            this.gameStatusBox.Name = "gameStatusBox";
            this.gameStatusBox.Size = new System.Drawing.Size(268, 110);
            this.gameStatusBox.TabIndex = 32;
            this.gameStatusBox.TabStop = false;
            this.gameStatusBox.Text = "Game Status";
            this.gameStatusBox.Paint += new System.Windows.Forms.PaintEventHandler(this.gameStatusBox_Paint);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(102, 54);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(47, 14);
            this.status.TabIndex = 33;
            this.status.Text = "status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(635, 505);
            this.Controls.Add(this.gameStatusBox);
            this.Controls.Add(this.BottomRight);
            this.Controls.Add(this.BottomMiddle);
            this.Controls.Add(this.MiddleRight);
            this.Controls.Add(this.MiddleMiddle);
            this.Controls.Add(this.BottomLeft);
            this.Controls.Add(this.MiddleLeft);
            this.Controls.Add(this.TopRight);
            this.Controls.Add(this.TopMiddle);
            this.Controls.Add(this.TopLeft);
            this.Controls.Add(this.HorzLine2);
            this.Controls.Add(this.HorzLine1);
            this.Controls.Add(this.VertLine2);
            this.Controls.Add(this.vertLine1);
            this.Controls.Add(this.statsGrpBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.strtGameButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TIC TAC TOE !!!";
            this.statsGrpBox.ResumeLayout(false);
            this.statsGrpBox.PerformLayout();
            this.gameStatusBox.ResumeLayout(false);
            this.gameStatusBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button strtGameButton; 
        private System.Windows.Forms.Button resetButton;  
        private System.Windows.Forms.GroupBox statsGrpBox; 
        private System.Windows.Forms.Label player2WinCnt; 
        private System.Windows.Forms.Label player1WinCnt; 
        private System.Windows.Forms.Label Ties;
        private System.Windows.Forms.Label player2Wins;
        private System.Windows.Forms.Label player1Wins;
        private System.Windows.Forms.Label TieCnt; 
        private System.Windows.Forms.Label TopLeft; 
        private System.Windows.Forms.Label TopMiddle; 
        private System.Windows.Forms.Label TopRight; 
        private System.Windows.Forms.Label MiddleLeft; 
        private System.Windows.Forms.Label BottomLeft; 
        private System.Windows.Forms.Label MiddleMiddle; 
        private System.Windows.Forms.Label MiddleRight; 
        private System.Windows.Forms.Label BottomMiddle; 
        private System.Windows.Forms.Label BottomRight; 
        private System.Windows.Forms.Label vertLine1;
        private System.Windows.Forms.Label VertLine2;
        private System.Windows.Forms.Label HorzLine1;
        private System.Windows.Forms.Label HorzLine2;
        private System.Windows.Forms.GroupBox gameStatusBox; 
        private System.Windows.Forms.Label status; 
    }
}

