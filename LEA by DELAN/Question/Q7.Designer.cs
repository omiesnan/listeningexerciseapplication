namespace LEA_by_DELAN
{
    partial class Q7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAudio = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.choiceD = new System.Windows.Forms.RadioButton();
            this.choiceC = new System.Windows.Forms.RadioButton();
            this.choiceB = new System.Windows.Forms.RadioButton();
            this.choiceA = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.viewPics = new System.Windows.Forms.PictureBox();
            this.Text1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPics)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAudio
            // 
            this.btnAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudio.Location = new System.Drawing.Point(12, 246);
            this.btnAudio.Name = "btnAudio";
            this.btnAudio.Size = new System.Drawing.Size(294, 45);
            this.btnAudio.TabIndex = 1;
            this.btnAudio.Text = "PLAY AUDIO";
            this.btnAudio.UseVisualStyleBackColor = true;
            this.btnAudio.Click += new System.EventHandler(this.btnAudio_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.choiceD);
            this.groupBox1.Controls.Add(this.choiceC);
            this.groupBox1.Controls.Add(this.choiceB);
            this.groupBox1.Controls.Add(this.choiceA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(313, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 278);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question and Answer";
            // 
            // choiceD
            // 
            this.choiceD.AutoSize = true;
            this.choiceD.Location = new System.Drawing.Point(6, 136);
            this.choiceD.Name = "choiceD";
            this.choiceD.Size = new System.Drawing.Size(284, 17);
            this.choiceD.TabIndex = 4;
            this.choiceD.TabStop = true;
            this.choiceD.Text = "Trying to get hold of Holi as soon as she can.";
            this.choiceD.UseVisualStyleBackColor = true;
            // 
            // choiceC
            // 
            this.choiceC.AutoSize = true;
            this.choiceC.Location = new System.Drawing.Point(6, 113);
            this.choiceC.Name = "choiceC";
            this.choiceC.Size = new System.Drawing.Size(243, 17);
            this.choiceC.TabIndex = 3;
            this.choiceC.TabStop = true;
            this.choiceC.Text = "Mailing a short letter through an email.";
            this.choiceC.UseVisualStyleBackColor = true;
            // 
            // choiceB
            // 
            this.choiceB.AutoSize = true;
            this.choiceB.Location = new System.Drawing.Point(6, 90);
            this.choiceB.Name = "choiceB";
            this.choiceB.Size = new System.Drawing.Size(200, 17);
            this.choiceB.TabIndex = 2;
            this.choiceB.TabStop = true;
            this.choiceB.Text = "Postponing a call to her friend.";
            this.choiceB.UseVisualStyleBackColor = true;
            // 
            // choiceA
            // 
            this.choiceA.AutoSize = true;
            this.choiceA.Location = new System.Drawing.Point(6, 67);
            this.choiceA.Name = "choiceA";
            this.choiceA.Size = new System.Drawing.Size(298, 17);
            this.choiceA.TabIndex = 1;
            this.choiceA.TabStop = true;
            this.choiceA.Text = "Leaving a message on a piece of paper for Holi.";
            this.choiceA.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What does Helen suggest to Angel?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(732, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 320);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(140, 60);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // viewPics
            // 
            this.viewPics.Image = global::LEA_by_DELAN.Properties.Resources._7;
            this.viewPics.Location = new System.Drawing.Point(12, 11);
            this.viewPics.Name = "viewPics";
            this.viewPics.Size = new System.Drawing.Size(295, 229);
            this.viewPics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viewPics.TabIndex = 0;
            this.viewPics.TabStop = false;
            // 
            // Text1
            // 
            this.Text1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Text1.Location = new System.Drawing.Point(586, 320);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(140, 60);
            this.Text1.TabIndex = 6;
            this.Text1.Text = "View Text";
            this.Text1.UseVisualStyleBackColor = true;
            this.Text1.Click += new System.EventHandler(this.Text1_Click);
            // 
            // Q7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.viewPics);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAudio);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 450);
            this.MinimumSize = new System.Drawing.Size(900, 450);
            this.Name = "Q7";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question 7";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAudio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton choiceD;
        private System.Windows.Forms.RadioButton choiceC;
        private System.Windows.Forms.RadioButton choiceB;
        private System.Windows.Forms.RadioButton choiceA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox viewPics;
        private System.Windows.Forms.Button Text1;
    }
}