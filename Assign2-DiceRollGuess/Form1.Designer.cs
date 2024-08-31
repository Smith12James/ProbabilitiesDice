namespace Assign2_DiceRollGuess
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gpboxGameStats = new GroupBox();
            lblIncorrectGuesses = new Label();
            lblCorrectGuesses = new Label();
            lblGamesPlayedDisp = new Label();
            lblGamesLost = new Label();
            lblGamesWon = new Label();
            lblGamesPlayed = new Label();
            btnRollDice = new Button();
            btnResetGame = new Button();
            txtbxUsrGuess = new TextBox();
            lblUsrGuess = new Label();
            pbDiceDisplay = new PictureBox();
            gpbxDiceData = new GroupBox();
            lblNumGuess6 = new Label();
            lblNumGuess5 = new Label();
            lblNumGuess4 = new Label();
            lblNumGuess3 = new Label();
            lblNumGuess2 = new Label();
            lblNumGuess1 = new Label();
            lblPercent6 = new Label();
            lblPercent5 = new Label();
            lblPercent4 = new Label();
            lblPercent3 = new Label();
            lblPercent2 = new Label();
            lblPercent1 = new Label();
            lblFreq6 = new Label();
            lblFreq5 = new Label();
            lblFreq4 = new Label();
            lblFreq3 = new Label();
            lblFreq2 = new Label();
            lblFreq1 = new Label();
            lblDiceFace6 = new Label();
            lblDiceFace4 = new Label();
            lblDiceFace5 = new Label();
            lblDiceFace3 = new Label();
            lblDiceFace2 = new Label();
            lblDiceFace1 = new Label();
            lblNumOfGuesses = new Label();
            lblPercent = new Label();
            lblFrequency = new Label();
            lblFace = new Label();
            gpboxGameStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDiceDisplay).BeginInit();
            gpbxDiceData.SuspendLayout();
            SuspendLayout();
            // 
            // gpboxGameStats
            // 
            gpboxGameStats.Controls.Add(lblIncorrectGuesses);
            gpboxGameStats.Controls.Add(lblCorrectGuesses);
            gpboxGameStats.Controls.Add(lblGamesPlayedDisp);
            gpboxGameStats.Controls.Add(lblGamesLost);
            gpboxGameStats.Controls.Add(lblGamesWon);
            gpboxGameStats.Controls.Add(lblGamesPlayed);
            gpboxGameStats.Location = new Point(37, 30);
            gpboxGameStats.Name = "gpboxGameStats";
            gpboxGameStats.Size = new Size(307, 203);
            gpboxGameStats.TabIndex = 0;
            gpboxGameStats.TabStop = false;
            gpboxGameStats.Text = "Game Stats:";
            // 
            // lblIncorrectGuesses
            // 
            lblIncorrectGuesses.AutoSize = true;
            lblIncorrectGuesses.Location = new Point(225, 143);
            lblIncorrectGuesses.Name = "lblIncorrectGuesses";
            lblIncorrectGuesses.Size = new Size(13, 15);
            lblIncorrectGuesses.TabIndex = 5;
            lblIncorrectGuesses.Text = "0";
            // 
            // lblCorrectGuesses
            // 
            lblCorrectGuesses.AutoSize = true;
            lblCorrectGuesses.Location = new Point(225, 87);
            lblCorrectGuesses.Name = "lblCorrectGuesses";
            lblCorrectGuesses.Size = new Size(13, 15);
            lblCorrectGuesses.TabIndex = 4;
            lblCorrectGuesses.Text = "0";
            // 
            // lblGamesPlayedDisp
            // 
            lblGamesPlayedDisp.AutoSize = true;
            lblGamesPlayedDisp.Location = new Point(225, 32);
            lblGamesPlayedDisp.Name = "lblGamesPlayedDisp";
            lblGamesPlayedDisp.Size = new Size(13, 15);
            lblGamesPlayedDisp.TabIndex = 3;
            lblGamesPlayedDisp.Text = "0";
            // 
            // lblGamesLost
            // 
            lblGamesLost.AutoSize = true;
            lblGamesLost.Location = new Point(21, 143);
            lblGamesLost.Name = "lblGamesLost";
            lblGamesLost.Size = new Size(105, 15);
            lblGamesLost.TabIndex = 2;
            lblGamesLost.Text = "Incorrect Guesses: ";
            // 
            // lblGamesWon
            // 
            lblGamesWon.AutoSize = true;
            lblGamesWon.Location = new Point(20, 87);
            lblGamesWon.Name = "lblGamesWon";
            lblGamesWon.Size = new Size(97, 15);
            lblGamesWon.TabIndex = 1;
            lblGamesWon.Text = "Correct Guesses: ";
            // 
            // lblGamesPlayed
            // 
            lblGamesPlayed.AutoSize = true;
            lblGamesPlayed.Location = new Point(21, 32);
            lblGamesPlayed.Name = "lblGamesPlayed";
            lblGamesPlayed.Size = new Size(87, 15);
            lblGamesPlayed.TabIndex = 0;
            lblGamesPlayed.Text = "Games Played: ";
            // 
            // btnRollDice
            // 
            btnRollDice.BackColor = Color.FromArgb(192, 255, 192);
            btnRollDice.Location = new Point(13, 408);
            btnRollDice.Name = "btnRollDice";
            btnRollDice.Size = new Size(150, 30);
            btnRollDice.TabIndex = 1;
            btnRollDice.Text = "Roll Dice";
            btnRollDice.UseVisualStyleBackColor = false;
            btnRollDice.Click += btnRollDice_Click;
            // 
            // btnResetGame
            // 
            btnResetGame.BackColor = Color.FromArgb(255, 192, 192);
            btnResetGame.Location = new Point(638, 408);
            btnResetGame.Name = "btnResetGame";
            btnResetGame.Size = new Size(150, 30);
            btnResetGame.TabIndex = 2;
            btnResetGame.Text = "Reset Game";
            btnResetGame.UseVisualStyleBackColor = false;
            btnResetGame.Click += btnResetGame_Click;
            // 
            // txtbxUsrGuess
            // 
            txtbxUsrGuess.Location = new Point(192, 274);
            txtbxUsrGuess.Name = "txtbxUsrGuess";
            txtbxUsrGuess.Size = new Size(100, 23);
            txtbxUsrGuess.TabIndex = 3;
            // 
            // lblUsrGuess
            // 
            lblUsrGuess.AutoSize = true;
            lblUsrGuess.Location = new Point(58, 277);
            lblUsrGuess.Name = "lblUsrGuess";
            lblUsrGuess.Size = new Size(128, 15);
            lblUsrGuess.TabIndex = 4;
            lblUsrGuess.Text = "Enter your guess (1-6): ";
            // 
            // pbDiceDisplay
            // 
            pbDiceDisplay.Image = Properties.Resources.dice_side_1;
            pbDiceDisplay.Location = new Point(342, 274);
            pbDiceDisplay.Name = "pbDiceDisplay";
            pbDiceDisplay.Size = new Size(157, 150);
            pbDiceDisplay.TabIndex = 5;
            pbDiceDisplay.TabStop = false;
            // 
            // gpbxDiceData
            // 
            gpbxDiceData.Controls.Add(lblNumGuess6);
            gpbxDiceData.Controls.Add(lblNumGuess5);
            gpbxDiceData.Controls.Add(lblNumGuess4);
            gpbxDiceData.Controls.Add(lblNumGuess3);
            gpbxDiceData.Controls.Add(lblNumGuess2);
            gpbxDiceData.Controls.Add(lblNumGuess1);
            gpbxDiceData.Controls.Add(lblPercent6);
            gpbxDiceData.Controls.Add(lblPercent5);
            gpbxDiceData.Controls.Add(lblPercent4);
            gpbxDiceData.Controls.Add(lblPercent3);
            gpbxDiceData.Controls.Add(lblPercent2);
            gpbxDiceData.Controls.Add(lblPercent1);
            gpbxDiceData.Controls.Add(lblFreq6);
            gpbxDiceData.Controls.Add(lblFreq5);
            gpbxDiceData.Controls.Add(lblFreq4);
            gpbxDiceData.Controls.Add(lblFreq3);
            gpbxDiceData.Controls.Add(lblFreq2);
            gpbxDiceData.Controls.Add(lblFreq1);
            gpbxDiceData.Controls.Add(lblDiceFace6);
            gpbxDiceData.Controls.Add(lblDiceFace4);
            gpbxDiceData.Controls.Add(lblDiceFace5);
            gpbxDiceData.Controls.Add(lblDiceFace3);
            gpbxDiceData.Controls.Add(lblDiceFace2);
            gpbxDiceData.Controls.Add(lblDiceFace1);
            gpbxDiceData.Controls.Add(lblNumOfGuesses);
            gpbxDiceData.Controls.Add(lblPercent);
            gpbxDiceData.Controls.Add(lblFrequency);
            gpbxDiceData.Controls.Add(lblFace);
            gpbxDiceData.Location = new Point(369, 30);
            gpbxDiceData.Name = "gpbxDiceData";
            gpbxDiceData.Size = new Size(419, 203);
            gpbxDiceData.TabIndex = 6;
            gpbxDiceData.TabStop = false;
            gpbxDiceData.Text = "Dice Data: ";
            // 
            // lblNumGuess6
            // 
            lblNumGuess6.AutoSize = true;
            lblNumGuess6.Location = new Point(320, 172);
            lblNumGuess6.Name = "lblNumGuess6";
            lblNumGuess6.Size = new Size(13, 15);
            lblNumGuess6.TabIndex = 26;
            lblNumGuess6.Text = "0";
            // 
            // lblNumGuess5
            // 
            lblNumGuess5.AutoSize = true;
            lblNumGuess5.Location = new Point(320, 149);
            lblNumGuess5.Name = "lblNumGuess5";
            lblNumGuess5.Size = new Size(13, 15);
            lblNumGuess5.TabIndex = 25;
            lblNumGuess5.Text = "0";
            // 
            // lblNumGuess4
            // 
            lblNumGuess4.AutoSize = true;
            lblNumGuess4.Location = new Point(320, 126);
            lblNumGuess4.Name = "lblNumGuess4";
            lblNumGuess4.Size = new Size(13, 15);
            lblNumGuess4.TabIndex = 24;
            lblNumGuess4.Text = "0";
            // 
            // lblNumGuess3
            // 
            lblNumGuess3.AutoSize = true;
            lblNumGuess3.Location = new Point(320, 103);
            lblNumGuess3.Name = "lblNumGuess3";
            lblNumGuess3.Size = new Size(13, 15);
            lblNumGuess3.TabIndex = 23;
            lblNumGuess3.Text = "0";
            // 
            // lblNumGuess2
            // 
            lblNumGuess2.AutoSize = true;
            lblNumGuess2.Location = new Point(320, 80);
            lblNumGuess2.Name = "lblNumGuess2";
            lblNumGuess2.Size = new Size(13, 15);
            lblNumGuess2.TabIndex = 22;
            lblNumGuess2.Text = "0";
            // 
            // lblNumGuess1
            // 
            lblNumGuess1.AutoSize = true;
            lblNumGuess1.Location = new Point(320, 57);
            lblNumGuess1.Name = "lblNumGuess1";
            lblNumGuess1.Size = new Size(13, 15);
            lblNumGuess1.TabIndex = 21;
            lblNumGuess1.Text = "0";
            // 
            // lblPercent6
            // 
            lblPercent6.AutoSize = true;
            lblPercent6.Location = new Point(190, 172);
            lblPercent6.Name = "lblPercent6";
            lblPercent6.Size = new Size(23, 15);
            lblPercent6.TabIndex = 20;
            lblPercent6.Text = "0%";
            // 
            // lblPercent5
            // 
            lblPercent5.AutoSize = true;
            lblPercent5.Location = new Point(190, 149);
            lblPercent5.Name = "lblPercent5";
            lblPercent5.Size = new Size(23, 15);
            lblPercent5.TabIndex = 19;
            lblPercent5.Text = "0%";
            // 
            // lblPercent4
            // 
            lblPercent4.AutoSize = true;
            lblPercent4.Location = new Point(190, 126);
            lblPercent4.Name = "lblPercent4";
            lblPercent4.Size = new Size(23, 15);
            lblPercent4.TabIndex = 18;
            lblPercent4.Text = "0%";
            // 
            // lblPercent3
            // 
            lblPercent3.AutoSize = true;
            lblPercent3.Location = new Point(190, 103);
            lblPercent3.Name = "lblPercent3";
            lblPercent3.Size = new Size(23, 15);
            lblPercent3.TabIndex = 17;
            lblPercent3.Text = "0%";
            // 
            // lblPercent2
            // 
            lblPercent2.AutoSize = true;
            lblPercent2.Location = new Point(190, 80);
            lblPercent2.Name = "lblPercent2";
            lblPercent2.Size = new Size(23, 15);
            lblPercent2.TabIndex = 16;
            lblPercent2.Text = "0%";
            // 
            // lblPercent1
            // 
            lblPercent1.AutoSize = true;
            lblPercent1.Location = new Point(190, 57);
            lblPercent1.Name = "lblPercent1";
            lblPercent1.Size = new Size(23, 15);
            lblPercent1.TabIndex = 15;
            lblPercent1.Text = "0%";
            // 
            // lblFreq6
            // 
            lblFreq6.AutoSize = true;
            lblFreq6.Location = new Point(95, 172);
            lblFreq6.Name = "lblFreq6";
            lblFreq6.Size = new Size(13, 15);
            lblFreq6.TabIndex = 14;
            lblFreq6.Text = "0";
            // 
            // lblFreq5
            // 
            lblFreq5.AutoSize = true;
            lblFreq5.Location = new Point(95, 149);
            lblFreq5.Name = "lblFreq5";
            lblFreq5.Size = new Size(13, 15);
            lblFreq5.TabIndex = 13;
            lblFreq5.Text = "0";
            // 
            // lblFreq4
            // 
            lblFreq4.AutoSize = true;
            lblFreq4.Location = new Point(95, 126);
            lblFreq4.Name = "lblFreq4";
            lblFreq4.Size = new Size(13, 15);
            lblFreq4.TabIndex = 12;
            lblFreq4.Text = "0";
            // 
            // lblFreq3
            // 
            lblFreq3.AutoSize = true;
            lblFreq3.Location = new Point(95, 103);
            lblFreq3.Name = "lblFreq3";
            lblFreq3.Size = new Size(13, 15);
            lblFreq3.TabIndex = 11;
            lblFreq3.Text = "0";
            // 
            // lblFreq2
            // 
            lblFreq2.AutoSize = true;
            lblFreq2.Location = new Point(95, 80);
            lblFreq2.Name = "lblFreq2";
            lblFreq2.Size = new Size(13, 15);
            lblFreq2.TabIndex = 10;
            lblFreq2.Text = "0";
            // 
            // lblFreq1
            // 
            lblFreq1.AutoSize = true;
            lblFreq1.Location = new Point(95, 57);
            lblFreq1.Name = "lblFreq1";
            lblFreq1.Size = new Size(13, 15);
            lblFreq1.TabIndex = 9;
            lblFreq1.Text = "0";
            // 
            // lblDiceFace6
            // 
            lblDiceFace6.AutoSize = true;
            lblDiceFace6.Location = new Point(16, 172);
            lblDiceFace6.Name = "lblDiceFace6";
            lblDiceFace6.Size = new Size(13, 15);
            lblDiceFace6.TabIndex = 7;
            lblDiceFace6.Text = "6";
            // 
            // lblDiceFace4
            // 
            lblDiceFace4.AutoSize = true;
            lblDiceFace4.Location = new Point(16, 126);
            lblDiceFace4.Name = "lblDiceFace4";
            lblDiceFace4.Size = new Size(13, 15);
            lblDiceFace4.TabIndex = 8;
            lblDiceFace4.Text = "4";
            // 
            // lblDiceFace5
            // 
            lblDiceFace5.AutoSize = true;
            lblDiceFace5.Location = new Point(16, 149);
            lblDiceFace5.Name = "lblDiceFace5";
            lblDiceFace5.Size = new Size(13, 15);
            lblDiceFace5.TabIndex = 7;
            lblDiceFace5.Text = "5";
            // 
            // lblDiceFace3
            // 
            lblDiceFace3.AutoSize = true;
            lblDiceFace3.Location = new Point(16, 103);
            lblDiceFace3.Name = "lblDiceFace3";
            lblDiceFace3.Size = new Size(13, 15);
            lblDiceFace3.TabIndex = 6;
            lblDiceFace3.Text = "3";
            // 
            // lblDiceFace2
            // 
            lblDiceFace2.AutoSize = true;
            lblDiceFace2.Location = new Point(16, 80);
            lblDiceFace2.Name = "lblDiceFace2";
            lblDiceFace2.Size = new Size(13, 15);
            lblDiceFace2.TabIndex = 5;
            lblDiceFace2.Text = "2";
            // 
            // lblDiceFace1
            // 
            lblDiceFace1.AutoSize = true;
            lblDiceFace1.Location = new Point(16, 57);
            lblDiceFace1.Name = "lblDiceFace1";
            lblDiceFace1.Size = new Size(13, 15);
            lblDiceFace1.TabIndex = 4;
            lblDiceFace1.Text = "1";
            // 
            // lblNumOfGuesses
            // 
            lblNumOfGuesses.AutoSize = true;
            lblNumOfGuesses.Location = new Point(248, 32);
            lblNumOfGuesses.Name = "lblNumOfGuesses";
            lblNumOfGuesses.Size = new Size(159, 15);
            lblNumOfGuesses.TabIndex = 3;
            lblNumOfGuesses.Text = "NUMBER OF TIMES GUESSED";
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.Location = new Point(171, 32);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(56, 15);
            lblPercent.TabIndex = 2;
            lblPercent.Text = "PERCENT";
            // 
            // lblFrequency
            // 
            lblFrequency.AutoSize = true;
            lblFrequency.Location = new Point(68, 32);
            lblFrequency.Name = "lblFrequency";
            lblFrequency.Size = new Size(73, 15);
            lblFrequency.TabIndex = 1;
            lblFrequency.Text = "FREQUENCY";
            // 
            // lblFace
            // 
            lblFace.AutoSize = true;
            lblFace.Location = new Point(6, 32);
            lblFace.Name = "lblFace";
            lblFace.Size = new Size(34, 15);
            lblFace.TabIndex = 0;
            lblFace.Text = "FACE";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gpbxDiceData);
            Controls.Add(pbDiceDisplay);
            Controls.Add(lblUsrGuess);
            Controls.Add(txtbxUsrGuess);
            Controls.Add(btnResetGame);
            Controls.Add(btnRollDice);
            Controls.Add(gpboxGameStats);
            Name = "Form1";
            Text = "Dice Guess Game";
            gpboxGameStats.ResumeLayout(false);
            gpboxGameStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbDiceDisplay).EndInit();
            gpbxDiceData.ResumeLayout(false);
            gpbxDiceData.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gpboxGameStats;
        private Label lblIncorrectGuesses;
        private Label lblCorrectGuesses;
        private Label lblGamesPlayedDisp;
        private Label lblGamesLost;
        private Label lblGamesWon;
        private Label lblGamesPlayed;
        private Button btnRollDice;
        private Button btnResetGame;
        private TextBox txtbxUsrGuess;
        private Label lblUsrGuess;
        private PictureBox pbDiceDisplay;
        private GroupBox gpbxDiceData;
        private Label lblFrequency;
        private Label lblFace;
        private Label lblNumOfGuesses;
        private Label lblPercent;
        private Label lblNumGuess6;
        private Label lblNumGuess5;
        private Label lblNumGuess4;
        private Label lblNumGuess3;
        private Label lblNumGuess2;
        private Label lblNumGuess1;
        private Label lblPercent6;
        private Label lblPercent5;
        private Label lblPercent4;
        private Label lblPercent3;
        private Label lblPercent2;
        private Label lblPercent1;
        private Label lblFreq6;
        private Label lblFreq5;
        private Label lblFreq4;
        private Label lblFreq3;
        private Label lblFreq2;
        private Label lblFreq1;
        private Label lblDiceFace6;
        private Label lblDiceFace4;
        private Label lblDiceFace5;
        private Label lblDiceFace3;
        private Label lblDiceFace2;
        private Label lblDiceFace1;
    }
}
