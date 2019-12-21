namespace PresentationLayer
{
    partial class ForgotPassword
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cbSecQuestion = new System.Windows.Forms.ComboBox();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblSecQuestion = new System.Windows.Forms.Label();
            this.lblTroll = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRecovery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(197)))), ((int)(((byte)(130)))));
            this.lblLogin.Location = new System.Drawing.Point(68, 38);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(259, 36);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "Forgot Password?";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.Window;
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(217, 151);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(180, 19);
            this.tbEmail.TabIndex = 26;
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(68, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 22);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "E-mail";
            // 
            // cbSecQuestion
            // 
            this.cbSecQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSecQuestion.FormattingEnabled = true;
            this.cbSecQuestion.Location = new System.Drawing.Point(217, 191);
            this.cbSecQuestion.Name = "cbSecQuestion";
            this.cbSecQuestion.Size = new System.Drawing.Size(180, 21);
            this.cbSecQuestion.TabIndex = 32;
            // 
            // tbAnswer
            // 
            this.tbAnswer.BackColor = System.Drawing.SystemColors.Window;
            this.tbAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAnswer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnswer.Location = new System.Drawing.Point(217, 235);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(180, 19);
            this.tbAnswer.TabIndex = 31;
            this.tbAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.White;
            this.lblAnswer.Location = new System.Drawing.Point(68, 232);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(78, 22);
            this.lblAnswer.TabIndex = 30;
            this.lblAnswer.Text = "Answer";
            // 
            // lblSecQuestion
            // 
            this.lblSecQuestion.AutoSize = true;
            this.lblSecQuestion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecQuestion.ForeColor = System.Drawing.Color.White;
            this.lblSecQuestion.Location = new System.Drawing.Point(68, 190);
            this.lblSecQuestion.Name = "lblSecQuestion";
            this.lblSecQuestion.Size = new System.Drawing.Size(125, 22);
            this.lblSecQuestion.TabIndex = 29;
            this.lblSecQuestion.Text = "SecQuestion";
            // 
            // lblTroll
            // 
            this.lblTroll.AutoSize = true;
            this.lblTroll.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(197)))), ((int)(((byte)(130)))));
            this.lblTroll.Location = new System.Drawing.Point(141, 301);
            this.lblTroll.Name = "lblTroll";
            this.lblTroll.Size = new System.Drawing.Size(494, 22);
            this.lblTroll.TabIndex = 33;
            this.lblTroll.Text = "\"Who\'s that tripping over my bridge?\" roared the troll.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentationLayer.Properties.Resources._1stWorld;
            this.pictureBox1.Location = new System.Drawing.Point(414, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // btnRecovery
            // 
            this.btnRecovery.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnRecovery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(197)))), ((int)(((byte)(130)))));
            this.btnRecovery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecovery.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecovery.ForeColor = System.Drawing.Color.White;
            this.btnRecovery.Image = global::PresentationLayer.Properties.Resources.Recovery;
            this.btnRecovery.Location = new System.Drawing.Point(341, 326);
            this.btnRecovery.Name = "btnRecovery";
            this.btnRecovery.Size = new System.Drawing.Size(85, 33);
            this.btnRecovery.TabIndex = 34;
            this.btnRecovery.UseVisualStyleBackColor = true;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRecovery);
            this.Controls.Add(this.lblTroll);
            this.Controls.Add(this.cbSecQuestion);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblSecQuestion);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLogin);
            this.Name = "ForgotPassword";
            this.Size = new System.Drawing.Size(771, 422);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cbSecQuestion;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblSecQuestion;
        private System.Windows.Forms.Label lblTroll;
        private System.Windows.Forms.Button btnRecovery;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
