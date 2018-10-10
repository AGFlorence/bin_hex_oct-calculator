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
    public partial class Form4 : Form
    {
        public string RS { get; private set; }

        public Form4()
        {
            InitializeComponent();
        }

        private void BTN_Exit_Click_1(object sender, EventArgs e)
        {
            Form3 SF = new Form3();
            this.Hide();
            SF.Show();
        }
        //global variables
        string RtS;
        bool RtF = false;
        string[] b = { "0", "0", "0", "0", "0", "0", "0", "0" };
        string[] z = { "#", "#", "#", "#", "#", "#", "#", "#" };

        //Function for returning binary value convert from individual strings
        private string ReturnBinary(int n)
        {
            if (n <= 255)
            {
                while (n > 0)
                {
                    if (n >= 128)
                    {
                        n = n - 128;
                        b[0] = "1";
                    }
                    if (n < 128 && n >= 64)
                    {
                        n = n - 64;
                        b[1] = "1";
                    }
                    if (n < 64 && n >= 32)
                    {
                        n = n - 32;
                        b[2] = "1";
                    }
                    if (n < 32 && n >= 16)
                    {
                        n = n - 16;
                        b[3] = "1";
                    }
                    if (n < 16 && n >= 8)
                    {
                        n = n - 8;
                        b[4] = "1";
                    }
                    if (n < 8 && n >= 4)
                    {
                        n = n - 4;
                        b[5] = "1";
                    }
                    if (n < 4 && n >= 2)
                    {
                        n = n - 2;
                        b[6] = "1";
                    }
                    if (n < 2 && n >= 1)
                    {
                        n = n - 1;
                        b[7] = "1";
                    }
                }
            }
            else
            {
                RtF = true;
            }
            RtS = string.Concat(b[0] + b[1] + b[2] + b[3] + b[4] + b[5] + b[6] + b[7]);
            return RtS;
        }
        //end function

        //function for returning hexadecimal value as individual strings
        private string ReturnHex(int n)
        {
            int [] x = { 0, 1, 2, 3, 4, 5, 6, 7 };
            int y = 0;
            int A = 10;
            int B = 11;
            int C = 12;
            int D = 13;
            int E = 14;
            int F = 15;
            while (n >= 16)
            {
                if (n > 0)
                {
                    x[y] = n % 16;
                    if (x[y] == A)
                    {
                        z[y] = "A";
                        
                    }
                    if (x[y] == B)
                    {
                        z[y] = "B";
                        
                    }
                    if (x[y] == C)
                    {
                        z[y] = "C";
                        
                    }
                    if (x[y] == D)
                    {
                        z[y] = "D";
                        
                    }
                    if (x[y] == E)
                    {
                        z[y] = "E";
                        
                    }
                    if (x[y] == F)
                    {
                        z[y] = "F";
                        
                    }
                    else
                    {
                        z[y] = Convert.ToString(x[y]);
                        
                    }
                }
                else
                {
                    z[y] = Convert.ToString(n);
                }
                if (y < 8)
                {
                    y = y + 1;
                    n = n - (n % 16);
                }
                else
                {
                    break;
                }
                

            }
            RtS = String.Concat(z[0], z[1], z[2], z[3], z[4], z[5], z[6], z[7]);
            return RtS;
        }
        
        private void BTN_Convert_Click_1(object sender, EventArgs e)
        {
            int Value;
            Value = Convert.ToInt32(TXT_Input.Text);
            ReturnBinary(Value);
            MessageBox.Show(RtS);
            //ReturnHex(Value);
            //MessageBox.Show(RtS);
            if (RtF == false)
            {
                LBL_8.Text = b[0];
                LBL_7.Text = b[1];
                LBL_6.Text = b[2];
                LBL_5.Text = b[3];
                LBL_4.Text = b[4];
                LBL_3.Text = b[5];
                LBL_2.Text = b[6];
                LBL_1.Text = b[7];
                LBL_9.Text = z[0];
                LBL_10.Text = z[1];
                LBL_11.Text = z[2];
                LBL_12.Text = z[3];
                LBL_13.Text = z[4];
                LBL_14.Text = z[5];
                LBL_15.Text = z[6];
                LBL_16.Text = z[7];
            }
            else
            {
                LBL_8.Text = "*";
                LBL_7.Text = "*";
                LBL_6.Text = "*";
                LBL_5.Text = "*";
                LBL_4.Text = "*";
                LBL_3.Text = "*";
                LBL_2.Text = "*";
                LBL_1.Text = "*";
                MessageBox.Show("number does not fit into 8-bit binary");
                RtF = false;
            }
        }
    }
}
