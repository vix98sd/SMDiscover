namespace PresentationLayer
{
    partial class Review
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
            this.btnSave = new System.Windows.Forms.Button();
            this.trackBarRating = new System.Windows.Forms.TrackBar();
            this.tbReview = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblReview = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRating)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(197)))), ((int)(((byte)(130)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::PresentationLayer.Properties.Resources.save_32px;
            this.btnSave.Location = new System.Drawing.Point(138, 241);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 33);
            this.btnSave.TabIndex = 41;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // trackBarRating
            // 
            this.trackBarRating.LargeChange = 1;
            this.trackBarRating.Location = new System.Drawing.Point(128, 98);
            this.trackBarRating.Maximum = 5;
            this.trackBarRating.Minimum = 1;
            this.trackBarRating.Name = "trackBarRating";
            this.trackBarRating.Size = new System.Drawing.Size(198, 45);
            this.trackBarRating.TabIndex = 42;
            this.trackBarRating.Value = 1;
            // 
            // tbReview
            // 
            this.tbReview.BackColor = System.Drawing.SystemColors.Window;
            this.tbReview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbReview.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReview.Location = new System.Drawing.Point(128, 164);
            this.tbReview.Multiline = true;
            this.tbReview.Name = "tbReview";
            this.tbReview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbReview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbReview.Size = new System.Drawing.Size(198, 61);
            this.tbReview.TabIndex = 44;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.Color.White;
            this.lblRate.Location = new System.Drawing.Point(21, 98);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(73, 22);
            this.lblRate.TabIndex = 45;
            this.lblRate.Text = "Raiting";
            // 
            // lblReview
            // 
            this.lblReview.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReview.ForeColor = System.Drawing.Color.White;
            this.lblReview.Location = new System.Drawing.Point(21, 161);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(101, 64);
            this.lblReview.TabIndex = 46;
            this.lblReview.Text = "Review (optional)";
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(197)))), ((int)(((byte)(130)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::PresentationLayer.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(138, 31);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(64, 33);
            this.btnBack.TabIndex = 47;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblReview);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.tbReview);
            this.Controls.Add(this.trackBarRating);
            this.Controls.Add(this.btnSave);
            this.Name = "Review";
            this.Size = new System.Drawing.Size(351, 306);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TrackBar trackBarRating;
        private System.Windows.Forms.TextBox tbReview;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.Button btnBack;
    }
}
