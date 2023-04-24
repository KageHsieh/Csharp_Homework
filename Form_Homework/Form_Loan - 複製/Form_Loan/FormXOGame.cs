using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Loan
{
    public partial class FormXOGame : Form
    {
        public FormXOGame()
        {
            InitializeComponent();
        }

        //privave void ButtonClick(object sender, EventArgs e)
        //{

        //}
        void Reset()
        {
            turn = true;
            turncount = 0;

            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            buttonE.Enabled = true;
            buttonF.Enabled = true;
            buttonG.Enabled = true;
            buttonH.Enabled = true;
            buttonI.Enabled = true;

            buttonA.Text = "";
            buttonB.Text = "";
            buttonC.Text = "";
            buttonD.Text = "";
            buttonE.Text = "";
            buttonF.Text = "";
            buttonG.Text = "";
            buttonH.Text = "";
            buttonI.Text = "";
        }

        bool turn = true;//true = X turn , false = Y turn
        int turncount = 0;
        private void buttonA_Click(object sender, EventArgs e)
        {
            //Button b = (Button)sender;
            //if (turn)
            //    b.Text = "X";
            //else b.Text = "Y";

            //turn = !turn;

            //b.Enabled = false;

            if(turn)
            {
                buttonA.Text = "X";
                turn = false;
            }
            else
            {
                buttonA.Text = "O";
                turn = true;
            }
            buttonA.Enabled = false;
            turncount++;
            WinnerSetting();



        }

        private void WinnerSetting()
        {
            bool winnerConfirm = false;
            if (buttonA.Text == buttonB.Text && buttonB.Text == buttonC.Text && buttonA.Text != "")
            {
                winnerConfirm = true;
            }
            else if (buttonD.Text == buttonE.Text && buttonE.Text == buttonF.Text && buttonD.Text != "")
            {
                winnerConfirm = true;
            }
            else if (buttonG.Text == buttonH.Text && buttonH.Text == buttonI.Text && buttonG.Text != "")
            {
                winnerConfirm = true;
            }
            else if (buttonA.Text == buttonD.Text && buttonD.Text == buttonG.Text && buttonA.Text != "")
            {
                winnerConfirm = true;
            }
            else if (buttonB.Text == buttonE.Text && buttonE.Text == buttonH.Text && buttonB.Text != "")
            {
                winnerConfirm = true;
            }
            else if (buttonC.Text == buttonF.Text && buttonF.Text == buttonI.Text && buttonC.Text != "")
            {
                winnerConfirm = true;
            }
            else if (buttonA.Text == buttonE.Text && buttonE.Text == buttonI.Text && buttonA.Text != "")
            {
                winnerConfirm = true;
            }
            else if (buttonC.Text == buttonE.Text && buttonE.Text == buttonG.Text && buttonC.Text != "")
            {
                winnerConfirm = true;
            }
            else
            { }

            if (winnerConfirm) 
            {
      
                //DisableButton();
                string winner = "";
                if (turn)
                {
                    winner = "O";
                }
                else
                {
                    winner = "X";
                }
                MessageBox.Show($"{winner}玩家獲勝!", "完局!", MessageBoxButtons.OK);
                Reset();

            }
            else if (turncount == 9) 
            {
                MessageBox.Show("平手!按下確定重新開始","完局",MessageBoxButtons.OK);
                Reset();
            }

        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                buttonB.Text = "X";
                turn = false;
            }
            else
            {
                buttonB.Text = "O";
                turn = true;
            }
            buttonB.Enabled = false;
            turncount++;
            WinnerSetting();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                buttonC.Text = "X";
                turn = false;
            }
            else
            {
                buttonC.Text = "O";
                turn = true;
            }
            buttonC.Enabled = false;
            turncount++;
            WinnerSetting();
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                buttonD.Text = "X";
                turn = false;
            }
            else
            {
                buttonD.Text = "O";
                turn = true;
            }
            buttonD.Enabled = false;
            turncount++;
            WinnerSetting();
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                buttonE.Text = "X";
                turn = false;
            }
            else
            {
                buttonE.Text = "O";
                turn = true;
            }
            buttonE.Enabled = false;
            turncount++;
            WinnerSetting();
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                buttonF.Text = "X";
                turn = false;
            }
            else
            {
                buttonF.Text = "O";
                turn = true;
            }
            buttonF.Enabled = false;
            turncount++;
            WinnerSetting();
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                buttonG.Text = "X";
                turn = false;
            }
            else
            {
                buttonG.Text = "O";
                turn = true;
            }
            buttonG.Enabled = false;
            turncount++;
            WinnerSetting();
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                buttonH.Text = "X";
                turn = false;
            }
            else
            {
                buttonH.Text = "O";
                turn = true;
            }
            buttonH.Enabled = false;
            turncount++;
            WinnerSetting();
        }
        private void buttonI_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                buttonI.Text = "X";
                turn = false;
            }
            else
            {
                buttonI.Text = "O";
                turn = true;
            }
            buttonI.Enabled = false;
            turncount++;
            WinnerSetting();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //turn = true;
            //turncount = 0;

            //buttonA.Enabled = true;
            //buttonB.Enabled = true;
            //buttonC.Enabled = true;
            //buttonD.Enabled = true;
            //buttonE.Enabled = true;
            //buttonF.Enabled = true;
            //buttonG.Enabled = true;
            //buttonH.Enabled = true;
            //buttonI.Enabled = true;

            //buttonA.Text = "";
            //buttonB.Text = "";
            //buttonC.Text = "";
            //buttonD.Text = "";
            //buttonE.Text = "";
            //buttonF.Text = "";
            //buttonG.Text = "";
            //buttonH.Text = "";
            //buttonI.Text = "";
            Reset();


        }
    }
}
