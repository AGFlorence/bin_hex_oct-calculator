using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doubleDiceSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Global Variables
        int StNo;
        int RlNo;
        //form start up protocols
        private void Form1_Load(object sender, EventArgs e)
        {
            StNo = 57;
            LBL_StNo.Text = Convert.ToString(StNo);
            LBL_NoR.Visible = false;
            RlNo = 0;
            BTN_Reset.Enabled = false;
        }

        private void BTN_RD_Click(object sender, EventArgs e)
        {
            int dice_RL;
            //simulates a dice roll
            Random R = new Random();
            dice_RL = R.Next(1, 6);
            //stops dice roll from being taken away when start number is lower
            if (StNo < dice_RL && StNo > 0)
            {
                LBL_DS.Text = Convert.ToString("you rolled: " + dice_RL);
                dice_RL = 0;
                MessageBox.Show("you must roll to be exactly zero");                
            }
            //takes dice roll away from start number and increments roll number by +1
            else
            {
            StNo = StNo - dice_RL;
            LBL_DS.Text = Convert.ToString("you rolled: " + dice_RL);
            LBL_StNo.Text = Convert.ToString(StNo);
            RlNo = RlNo + 1;
            }
               
        }
        //when the text is changed in this control the no. of rolls label is viewable
        private void LBL_StNo_TextChanged(object sender, EventArgs e)
        {
            //when start number = zero enables reset button in place of dice roll button and shows no. of rolls info
            if (StNo == 0)
            {
                BTN_RD.Enabled = false;
                LBL_NoR.Text = ("number of rolls to get to zero was " + RlNo);
                LBL_NoR.Visible = true;
                BTN_Reset.Enabled = true;
            }
            //enables dice roll button if the form is reset
            else
            {
                BTN_RD.Enabled = true;
            }
        }
        //resets the form to the original start when form is loaded
        private void BTN_Reset_Click(object sender, EventArgs e)
        {
            StNo = 57;
            LBL_StNo.Text = Convert.ToString(StNo);
            LBL_NoR.Visible = false;
            RlNo = 0;
            BTN_Reset.Enabled = false;
        }
        //shuts down the application when exit button is pressed
        private void BTN_XF_Click(object sender, EventArgs e)
        {
            Form3 SF = new Form3();
            this.Hide();
            SF.Show();
        }
    }
}