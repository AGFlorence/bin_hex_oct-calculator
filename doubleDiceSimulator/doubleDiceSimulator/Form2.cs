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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Global variables
        int slot1;
        int slot2;
        int slot3;
        int slot4;
        int slot5;
        int slot6;
        int slot7;
        int slot8;
        int slot9;
        int M;
        int CR;

        //form start up protocols
        private void Form2_Load(object sender, EventArgs e)
        {
            LBL_CRD.Text = "30";
            CR = Convert.ToInt16(LBL_CRD.Text);
            CMB_CRDB.Text = "1";
            M = Convert.ToInt16(CMB_CRDB.Text);
            LBL_S3.Text = ("for 1 matching line of 3 reward is: " + 2 * M + " Credits");
            LBL_D3.Text = ("for 2 matching line of 3 reward is: " + 3 * M + " Credits");
            LBL_T3.Text = ("for 3 matching line of 3 reward is: " + 4 * M + " Credits");
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            Form3 SF = new Form3();
            this.Hide();
            SF.Show();
        }

        //processes spining of the slot machine
        private void BTN_SPIN_Click(object sender, EventArgs e)
        {
            bool L1;
            bool L2;
            bool L3;
            int CRB;
            if (CBX_HD1.Checked && CBX_HD2.Checked && CBX_HD3.Checked == true)
            {
                MessageBox.Show("you cannot hold all 3 slots");
                MessageBox.Show("only 0 - 2 of them");
            }
            else
            {
                CR = CR - Convert.ToInt16(CMB_CRDB.Text);
                LBL_CRD.Text = Convert.ToString(CR);
                Random R = new Random();
                if (CBX_HD1.Checked == false)
                {
                    slot1 = R.Next(1, 9);
                    LBL_SL1.Text = "0" + Convert.ToString(slot1);
                    slot4 = R.Next(1, 9);
                    LBL_SL4.Text = "0" + Convert.ToString(slot4);
                    slot7 = R.Next(1, 9);
                    LBL_SL7.Text = "0" + Convert.ToString(slot7);
                }
                else
                {
                    slot1 = Convert.ToInt16(LBL_SL1.Text);
                    slot4 = Convert.ToInt16(LBL_SL4.Text);
                    slot7 = Convert.ToInt16(LBL_SL7.Text);
                }
                if (CBX_HD2.Checked == false)
                {
                    slot2 = R.Next(1, 9);
                    LBL_SL2.Text = "0" + Convert.ToString(slot2);
                    slot5 = R.Next(1, 9);
                    LBL_SL5.Text = "0" + Convert.ToString(slot5);
                    slot8 = R.Next(1, 9);
                    LBL_SL8.Text = "0" + Convert.ToString(slot8);
                }
                else
                {
                    slot2 = Convert.ToInt16(LBL_SL2.Text);
                    slot5 = Convert.ToInt16(LBL_SL5.Text);
                    slot8 = Convert.ToInt16(LBL_SL8.Text);
                }
                if (CBX_HD3.Checked == false)
                {
                    slot3 = R.Next(1, 9);
                    LBL_SL3.Text = "0" + Convert.ToString(slot3);
                    slot6 = R.Next(1, 9);
                    LBL_SL6.Text = "0" + Convert.ToString(slot6);
                    slot9 = R.Next(1, 9);
                    LBL_SL9.Text = "0" + Convert.ToString(slot9);
                }
                else
                {
                    slot3 = Convert.ToInt16(LBL_SL3.Text);
                    slot6 = Convert.ToInt16(LBL_SL6.Text);
                    slot9 = Convert.ToInt16(LBL_SL9.Text);
                }
                if (slot1 == slot2 && slot1 == slot3)
                {
                    L1 = true;
                }
                else
                {
                    L1 = false;
                }
                if (slot4 == slot5 && slot4 == slot6)
                {
                    L2 = true;
                }
                else
                {
                    L2 = false;
                }
                if (slot7 == slot8 && slot7 == slot9)
                {
                    L3 = true;
                }
                else
                {
                    L3 = false;
                }
                if (L1 == true || L2 == true || L3 == true)
                {
                    CRB = 2 * M;
                    CR = CR + CRB;
                    LBL_CRD.Text = Convert.ToString(CR);
                }
                if (L1 == true && L2 == true)
                {
                    CRB = 3 * M;
                    CR = CR + CRB;
                    LBL_CRD.Text = Convert.ToString(CR);
                }
                if (L1 == true && L3 == true)
                {
                    CRB = 3 * M;
                    CR = CR + CRB;
                    LBL_CRD.Text = Convert.ToString(CR);
                }
                if (L2 == true && L3 == true)
                {
                    CRB = 3 * M;
                    CR = CR + CRB;
                    LBL_CRD.Text = Convert.ToString(CR);
                }
                if (L1 == true && L2 == true && L3 == true)
                {
                    CRB = 4 * M;
                    CR = CR + CRB;
                    LBL_CRD.Text = Convert.ToString(CR);
                }
            }
        }
        private void CMB_CRDB_TextUpdate(object sender, EventArgs e)
        {
            
        }

        private void CMB_CRDB_TextChanged(object sender, EventArgs e)
        {
            M = Convert.ToInt16(CMB_CRDB.Text);
            LBL_S3.Text = ("for 1 matching line of 3 reward is: " + 2 * M + " Credits");
            LBL_D3.Text = ("for 2 matching line of 3 reward is: " + 3 * M + " Credits");
            LBL_T3.Text = ("for 3 matching line of 3 reward is: " + 4 * M + " Credits");
        }
    }
}
