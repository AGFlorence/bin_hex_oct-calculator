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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_DS_Click(object sender, EventArgs e)
        {
            Form1 SF = new Form1();
            this.Hide();
            SF.Show();
        }

        private void BTN_SM_Click(object sender, EventArgs e)
        {
            Form2 SF = new Form2();
            this.Hide();
            SF.Show();
        }

        private void BTN_BHOC_Click_1(object sender, EventArgs e)
        {
            Form4 SF = new Form4();
            this.Hide();
            SF.Show();
        }
    }
}
