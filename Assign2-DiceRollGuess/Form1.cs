namespace Assign2_DiceRollGuess
{
    public partial class Form1 : Form
    {

        Bitmap myImg;

        //variables to track data, as the UI is clearing this info between turns within methods.
        private int iTotalGamesPlayed = 0;
        private int iDiceFrequency1 = 0;
        private int iDiceFrequency2 = 0;
        private int iDiceFrequency3 = 0;
        private int iDiceFrequency4 = 0;
        private int iDiceFrequency5 = 0;
        private int iDiceFrequency6 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// event to roll the dice, accept user input if it's an integer (1-6), update game info box labels (3 items to update), 
        /// update dice data box labels, 18 items that could be updated. Percent should update every time, other two fields
        /// should only update based on the user input and the random dice number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRollDice_Click(object sender, EventArgs e)
        {
            string sUserGuess = txtbxUsrGuess.Text;
            int iUserGuess;

            bool bUserGuess = int.TryParse(sUserGuess, out iUserGuess);

            if (!bUserGuess)
            {
                warningMsgBox();
                return;

            } else if (iUserGuess <= 0 || iUserGuess >= 7)
            {
                warningMsgBox();
                return;

            } else
            {
                int iDiceNumber = randomNum(1, 7);

                updateFields(iUserGuess, iDiceNumber);
                rollDiceImg();
                setDiceFace(iDiceNumber);

                return;
            }

        }

        private void btnResetGame_Click(object sender, EventArgs e)
        {
            iTotalGamesPlayed = 0;
            iDiceFrequency1 = 0;
            iDiceFrequency2 = 0;
            iDiceFrequency3 = 0;
            iDiceFrequency4 = 0;
            iDiceFrequency5 = 0;
            iDiceFrequency6 = 0;

            lblFreq1.Text = "0";
            lblFreq2.Text = "0";
            lblFreq3.Text = "0";
            lblFreq4.Text = "0";
            lblFreq5.Text = "0";
            lblFreq6.Text = "0";

            lblPercent1.Text = "0%";
            lblPercent2.Text = "0%";
            lblPercent3.Text = "0%";
            lblPercent4.Text = "0%";
            lblPercent5.Text = "0%";
            lblPercent6.Text = "0%";

            lblNumGuess1.Text = "0";
            lblNumGuess2.Text = "0";
            lblNumGuess3.Text = "0";
            lblNumGuess4.Text = "0";
            lblNumGuess5.Text = "0";
            lblNumGuess6.Text = "0";

            lblGamesPlayedDisp.Text = "0";
            lblCorrectGuesses.Text = "0";
            lblIncorrectGuesses.Text = "0";

            txtbxUsrGuess.Clear();

        }

        /// <summary>
        /// Method used to display a warning box if user enters a value that is not 1, 2, 3, 4, 5, 6
        /// </summary>
        private void warningMsgBox()
        {
            string txtbxDisplayText = "Please enter a number between 1 and 6.";
            string caption = "Warning: Bad user input";

            MessageBoxButtons btnRetryCancel = MessageBoxButtons.RetryCancel;
            DialogResult result;

            result = MessageBox.Show(txtbxDisplayText, caption, btnRetryCancel, MessageBoxIcon.Warning);

            if (result != DialogResult.Cancel)
            {
                txtbxUsrGuess.Clear();
                return;

            }
            this.Close();
        }

        /// <summary>
        /// updateFields is used to update all fields based on user input and the random dice number
        /// targeted fields will be number of games played, correct guesses made, incorrect guesses made, frequency field,
        /// percent field, and number of times guessed.
        /// </summary>
        /// <param name="iUserInput"></param>
        /// <param name="iDiceNum"></param>
        private void updateFields(int iUserInput, int iDiceNum)
        {
            iTotalGamesPlayed = iTotalGamesPlayed + 1;
            lblGamesPlayedDisp.Text = iTotalGamesPlayed.ToString();

            if (iUserInput == iDiceNum)
            {
                int iCorrectGuesses;
                int.TryParse(lblCorrectGuesses.Text, out iCorrectGuesses);
                iCorrectGuesses++;
                lblCorrectGuesses.Text = iCorrectGuesses.ToString();

            } else if (iUserInput != iDiceNum)
            {
                int iIncorrectGuesses;
                int.TryParse(lblIncorrectGuesses.Text, out iIncorrectGuesses);
                iIncorrectGuesses++;
                lblIncorrectGuesses.Text = iIncorrectGuesses.ToString();

            }

            updateDiceData(iUserInput, iDiceNum);
            percentMath();

            txtbxUsrGuess.Clear();

        }

        /// <summary>
        /// take user input and the random dice side, and update the frequency and number of guesses made.
        /// This will also be the method used to call the percent update method percentMath() 
        /// </summary>
        /// <param name="iUserInput"></param>
        /// <param name="iDiceNum"></param>
        private void updateDiceData(int iUserInput, int iDiceNum)
        {
            int iTempNumberOfGuesses;

            switch(iDiceNum)
            {
                case 1:
                    // int.TryParse(lblFreq1.Text, out iTempFreq);
                    iDiceFrequency1 = iDiceFrequency1 + 1;
                    lblFreq1.Text = iDiceFrequency1.ToString();

                    break;

                case 2:
                    // int.TryParse(lblFreq2.Text, out iTempFreq);
                    iDiceFrequency2 = iDiceFrequency2 + 1;
                    lblFreq2.Text = iDiceFrequency2.ToString();

                    break;

                case 3:
                    // int.TryParse(lblFreq3.Text, out iTempFreq);
                    iDiceFrequency3 = iDiceFrequency3 + 1;
                    lblFreq3.Text = iDiceFrequency3.ToString();

                    break;

                case 4:
                    // int.TryParse(lblFreq4.Text, out iTempFreq);
                    iDiceFrequency4 = iDiceFrequency4 + 1;
                    lblFreq4.Text = iDiceFrequency4.ToString();

                    break;

                case 5:
                    // int.TryParse(lblFreq5.Text, out iTempFreq);
                    iDiceFrequency5 = iDiceFrequency5 + 1;
                    lblFreq5.Text = iDiceFrequency5.ToString();

                    break;

                case 6:
                    // int.TryParse(lblFreq6.Text, out iTempFreq);
                    iDiceFrequency6 = iDiceFrequency6 + 1;
                    lblFreq6.Text = iDiceFrequency6.ToString();

                    break;
            }

            

            switch (iUserInput)
            {
                case 1:

                    int.TryParse(lblNumGuess1.Text, out iTempNumberOfGuesses);
                    iTempNumberOfGuesses = iTempNumberOfGuesses + 1;
                    lblNumGuess1.Text = iTempNumberOfGuesses.ToString();

                    break;

                case 2:

                    int.TryParse(lblNumGuess2.Text, out iTempNumberOfGuesses);
                    iTempNumberOfGuesses = iTempNumberOfGuesses + 1;
                    lblNumGuess2.Text = iTempNumberOfGuesses.ToString();

                    break;

                case 3:

                    int.TryParse(lblNumGuess3.Text, out iTempNumberOfGuesses);
                    iTempNumberOfGuesses = iTempNumberOfGuesses + 1;
                    lblNumGuess3.Text = iTempNumberOfGuesses.ToString();

                    break;

                case 4:

                    int.TryParse(lblNumGuess4.Text, out iTempNumberOfGuesses);
                    iTempNumberOfGuesses = iTempNumberOfGuesses + 1;
                    lblNumGuess4.Text = iTempNumberOfGuesses.ToString();

                    break;

                case 5:

                    int.TryParse(lblNumGuess5.Text, out iTempNumberOfGuesses);
                    iTempNumberOfGuesses = iTempNumberOfGuesses + 1;
                    lblNumGuess5.Text = iTempNumberOfGuesses.ToString();

                    break;

                case 6:

                    int.TryParse(lblNumGuess6.Text, out iTempNumberOfGuesses);
                    iTempNumberOfGuesses = iTempNumberOfGuesses + 1;
                    lblNumGuess6.Text = iTempNumberOfGuesses.ToString();

                    break;

            }


        }


        /// <summary>
        /// This method will accept a parameter of numbers of games played, and use this to divide by the frequency of
        /// each dice face. Input parameter is used to save time from writiing a tryparse statement.
        /// </summary>
        /// <param name="iGamesPlayed"></param>
        private void percentMath()
        {


            int iPercent1 = (this.iDiceFrequency1 / this.iTotalGamesPlayed) * 100;
            int iPercent2 = (this.iDiceFrequency2 / this.iTotalGamesPlayed) * 100;
            int iPercent3 = (this.iDiceFrequency3 / this.iTotalGamesPlayed) * 100;
            int iPercent4 = (this.iDiceFrequency4 / this.iTotalGamesPlayed) * 100;
            int iPercent5 = (this.iDiceFrequency5 / this.iTotalGamesPlayed) * 100;
            int iPercent6 = (this.iDiceFrequency6 / this.iTotalGamesPlayed) * 100;

            string sPercent1 = iPercent1.ToString();
            string sPercent2 = iPercent2.ToString();
            string sPercent3 = iPercent3.ToString();
            string sPercent4 = iPercent4.ToString();
            string sPercent5 = iPercent5.ToString();
            string sPercent6 = iPercent6.ToString();

            lblPercent1.Text = sPercent1 + "%";
            lblPercent2.Text = sPercent2 + "%";
            lblPercent3.Text = sPercent3 + "%";
            lblPercent4.Text = sPercent4 + "%";
            lblPercent5.Text = sPercent5 + "%";
            lblPercent6.Text = sPercent6 + "%";

        }

        /// <summary>
        /// method to change dice image. First dice will roll x amount of times then will land on same side as random dice number
        /// </summary>
        private void rollDiceImg()
        {
            
            int x = randomNum(4, 7);

            for (int i = 1; i < x; i++)
            {

                myImg?.Dispose();

                int y = randomNum(1, 7);

                switch(y)
                {
                    case 1:

                        myImg = new Bitmap(Properties.Resources.dice_roll_1);
                        pbDiceDisplay.Image = myImg;

                        break;

                    case 2:
                        myImg = new Bitmap(Properties.Resources.dice_roll_2);
                        pbDiceDisplay.Image = myImg;

                        break;

                    case 3:
                        myImg = new Bitmap(Properties.Resources.dice_roll_3);
                        pbDiceDisplay.Image = myImg;

                        break;

                    case 4:
                        myImg = new Bitmap(Properties.Resources.dice_roll_4);
                        pbDiceDisplay.Image = myImg;

                        break;

                    case 5:
                        myImg = new Bitmap(Properties.Resources.dice_roll_5);
                        pbDiceDisplay.Image = myImg;

                        break;

                    case 6:
                        myImg = new Bitmap(Properties.Resources.dice_roll_6);
                        pbDiceDisplay.Image = myImg;

                        break;

                }
                pbDiceDisplay.Refresh();
                Thread.Sleep(212);

            }            

        }


        private void setDiceFace(int iDiceFace)
        {
            switch (iDiceFace)
            {
                case 1:
                    myImg = new Bitmap(Properties.Resources.dice_side_1);
                    pbDiceDisplay.Image = myImg;

                    break;

                case 2:
                    myImg = new Bitmap(Properties.Resources.dice_side_2);
                    pbDiceDisplay.Image = myImg;

                    break;

                case 3:
                    myImg = new Bitmap(Properties.Resources.dice_side_3);
                    pbDiceDisplay.Image = myImg;

                    break;

                case 4:
                    myImg = new Bitmap(Properties.Resources.dice_side_4);
                    pbDiceDisplay.Image = myImg;

                    break;

                case 5:
                    myImg = new Bitmap(Properties.Resources.dice_side_5);
                    pbDiceDisplay.Image = myImg;

                    break;

                case 6:
                    myImg = new Bitmap(Properties.Resources.dice_side_6);
                    pbDiceDisplay.Image = myImg;

                    break;
            }

            pbDiceDisplay.Refresh();

        }

        /// <summary>
        /// generate a random number between int x and int i
        /// </summary>
        /// <returns></returns>
        private int randomNum(int x, int i)
        {
            var vRand = new Random();
            int iRand = vRand.Next(x, i);

            return iRand;

        }
    }
}
