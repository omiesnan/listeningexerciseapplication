using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEA_by_DELAN
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void enterTest_Click(object sender, EventArgs e)
        {
            NumberTest Select = new NumberTest();
            Select.ShowDialog();
        }

        private void lastResult_Click(object sender, EventArgs e)
        {
            Result Hasil = new Result();
            Hasil.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://isnanasseghaf.bantenhost.com/");
        }

        private void answerKey_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can't see the answer key. You have to test first", "Are you kidding?!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click 'Enter Test' from main menu, and you can read the instructions before begin the test", "I will tell you..", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
