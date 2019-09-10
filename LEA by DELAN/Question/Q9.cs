﻿using System;
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
    public partial class Q9 : Form
    {

        public Q9()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\LEA by DELAN\LEA by DELAN\Resources\AUD9.wav");
            player.Stop();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (choiceB.Checked == true)
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
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\LEA by DELAN\LEA by DELAN\Resources\AUD9.wav");
            player.Play();
        }

        private void Text1_Click(object sender, EventArgs e)
        {
            Question.Question_Hint.Text9 ViewText9 = new Question.Question_Hint.Text9();
            ViewText9.ShowDialog();
        }
    }
}