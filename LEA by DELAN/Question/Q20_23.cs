using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace LEA_by_DELAN
{
    public partial class Q20_23 : Form
    {

        public Q20_23()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\LEA by DELAN\LEA by DELAN\Resources\AUD20-23.wav");
            player.Stop();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (choiceC.Checked == true)
            {
                MessageBox.Show("Correct!", "That's true!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Incorrect!", "You can try again!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void submit2_Click(object sender, EventArgs e)
        {
            if (choiceD2.Checked == true)
            {
                MessageBox.Show("Correct!", "That's true!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Incorrect!", "You can try again!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void submit3_Click(object sender, EventArgs e)
        {
            if (choiceA3.Checked == true)
            {
                MessageBox.Show("Correct!", "That's true!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Incorrect!", "You can try again!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void submit4_Click(object sender, EventArgs e)
        {
            if (choiceB4.Checked == true)
            {
                MessageBox.Show("Correct!", "That's true!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Incorrect!", "You can try again!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\LEA by DELAN\LEA by DELAN\Resources\AUD20-23.wav");
            player.Play();
        }

        private void Text1_Click(object sender, EventArgs e)
        {
            Question.Question_Hint.Text20_23 ViewText20_23 = new Question.Question_Hint.Text20_23();
            ViewText20_23.ShowDialog();
        }
    }
}
