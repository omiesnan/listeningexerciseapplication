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
using LEA_by_DELAN.Question.Question_Hint;

namespace LEA_by_DELAN
{
    public partial class Q1 : Form
    {

        public Q1()
        {
            InitializeComponent();
        }

        private void Q1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Dialog Title", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\LEA by DELAN\LEA by DELAN\Resources\AUD1.wav");
                    player.Stop();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\LEA by DELAN\LEA by DELAN\Resources\AUD1.wav");
            player.Stop();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (choiceD.Checked == true)
            {
                MessageBox.Show("Correct!", "That's true!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect!", "You can try again!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\LEA by DELAN\LEA by DELAN\Resources\AUD1.wav");
            player.Play();
            }

        private void Text1_Click(object sender, EventArgs e)
        {
            Question.Question_Hint.Text1 ViewText1 = new Question.Question_Hint.Text1();
            ViewText1.ShowDialog();
        }
    }

}
