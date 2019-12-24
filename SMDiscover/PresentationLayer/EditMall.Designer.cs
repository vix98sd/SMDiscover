namespace PresentationLayer
{
    partial class EditMall
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
            this.lblEditMall = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.cbTown = new System.Windows.Forms.ComboBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.tbAbout = new System.Windows.Forms.TextBox();
            this.lblAbout = new System.Windows.Forms.Label();
            this.tbImage = new System.Windows.Forms.TextBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.tbOpen = new System.Windows.Forms.TextBox();
            this.lblWorkingHours = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbClose = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEditMall
            // 
            this.lblEditMall.AutoSize = true;
            this.lblEditMall.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditMall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(197)))), ((int)(((byte)(130)))));
            this.lblEditMall.Location = new System.Drawing.Point(68, 38);
            this.lblEditMall.Name = "lblEditMall";
            this.lblEditMall.Size = new System.Drawing.Size(272, 36);
            this.lblEditMall.TabIndex = 7;
            this.lblEditMall.Text = "Edit Shopping Mall";
            // 
            // btnAddUser
            // 
            this.btnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(197)))), ((int)(((byte)(130)))));
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Image = global::PresentationLayer.Properties.Resources.save_32px;
            this.btnAddUser.Location = new System.Drawing.Point(341, 364);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(85, 33);
            this.btnAddUser.TabIndex = 48;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(197)))), ((int)(((byte)(130)))));
            this.lblInfo.Location = new System.Drawing.Point(70, 93);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(603, 48);
            this.lblInfo.TabIndex = 51;
            this.lblInfo.Text = "Adding a mall is pretty straightforward. To delete mall fill name textbox then se" +
    "arch and delete :)";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.Window;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(201, 187);
            this.tbName.Name = "tbName";
            this.tbName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbName.Size = new System.Drawing.Size(159, 19);
            this.tbName.TabIndex = 53;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(70, 184);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 22);
            this.lblName.TabIndex = 52;
            this.lblName.Text = "Name";
            // 
            // cbCountry
            // 
            this.cbCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(201, 223);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(159, 21);
            this.cbCountry.TabIndex = 55;
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.White;
            this.lblCountry.Location = new System.Drawing.Point(70, 223);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(85, 22);
            this.lblCountry.TabIndex = 54;
            this.lblCountry.Text = "Country";
            // 
            // cbTown
            // 
            this.cbTown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTown.FormattingEnabled = true;
            this.cbTown.Location = new System.Drawing.Point(201, 263);
            this.cbTown.Name = "cbTown";
            this.cbTown.Size = new System.Drawing.Size(159, 21);
            this.cbTown.TabIndex = 57;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.ForeColor = System.Drawing.Color.White;
            this.lblTown.Location = new System.Drawing.Point(70, 263);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(58, 22);
            this.lblTown.TabIndex = 56;
            this.lblTown.Text = "Town";
            // 
            // tbLocation
            // 
            this.tbLocation.BackColor = System.Drawing.SystemColors.Window;
            this.tbLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLocation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLocation.Location = new System.Drawing.Point(201, 302);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbLocation.Size = new System.Drawing.Size(159, 19);
            this.tbLocation.TabIndex = 59;
            this.tbLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.White;
            this.lblLocation.Location = new System.Drawing.Point(70, 299);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(83, 22);
            this.lblLocation.TabIndex = 58;
            this.lblLocation.Text = "Address";
            // 
            // tbAbout
            // 
            this.tbAbout.BackColor = System.Drawing.SystemColors.Window;
            this.tbAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAbout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAbout.Location = new System.Drawing.Point(531, 225);
            this.tbAbout.Name = "tbAbout";
            this.tbAbout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbAbout.Size = new System.Drawing.Size(159, 19);
            this.tbAbout.TabIndex = 61;
            this.tbAbout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.White;
            this.lblAbout.Location = new System.Drawing.Point(383, 222);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(69, 22);
            this.lblAbout.TabIndex = 60;
            this.lblAbout.Text = "About";
            // 
            // tbImage
            // 
            this.tbImage.BackColor = System.Drawing.SystemColors.Window;
            this.tbImage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbImage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbImage.Location = new System.Drawing.Point(531, 266);
            this.tbImage.Name = "tbImage";
            this.tbImage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbImage.Size = new System.Drawing.Size(159, 19);
            this.tbImage.TabIndex = 63;
            this.tbImage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.ForeColor = System.Drawing.Color.White;
            this.lblImage.Location = new System.Drawing.Point(383, 263);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(70, 22);
            this.lblImage.TabIndex = 62;
            this.lblImage.Text = "Image";
            // 
            // tbOpen
            // 
            this.tbOpen.BackColor = System.Drawing.SystemColors.Window;
            this.tbOpen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOpen.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOpen.Location = new System.Drawing.Point(531, 302);
            this.tbOpen.Name = "tbOpen";
            this.tbOpen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbOpen.Size = new System.Drawing.Size(31, 19);
            this.tbOpen.TabIndex = 65;
            this.tbOpen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblWorkingHours
            // 
            this.lblWorkingHours.AutoSize = true;
            this.lblWorkingHours.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkingHours.ForeColor = System.Drawing.Color.White;
            this.lblWorkingHours.Location = new System.Drawing.Point(383, 299);
            this.lblWorkingHours.Name = "lblWorkingHours";
            this.lblWorkingHours.Size = new System.Drawing.Size(137, 22);
            this.lblWorkingHours.TabIndex = 64;
            this.lblWorkingHours.Text = "Working hours";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(197)))), ((int)(((byte)(130)))));
            this.label6.Location = new System.Drawing.Point(568, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 22);
            this.label6.TabIndex = 66;
            this.label6.Text = "-";
            // 
            // tbClose
            // 
            this.tbClose.BackColor = System.Drawing.SystemColors.Window;
            this.tbClose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbClose.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClose.Location = new System.Drawing.Point(590, 302);
            this.tbClose.Name = "tbClose";
            this.tbClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbClose.Size = new System.Drawing.Size(31, 19);
            this.tbClose.TabIndex = 67;
            this.tbClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(197)))), ((int)(((byte)(130)))));
            this.label7.Location = new System.Drawing.Point(627, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 22);
            this.label7.TabIndex = 68;
            this.label7.Text = "h";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(197)))), ((int)(((byte)(130)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::PresentationLayer.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(445, 173);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(39, 33);
            this.btnDelete.TabIndex = 70;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(197)))), ((int)(((byte)(130)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::PresentationLayer.Properties.Resources.search_32px;
            this.btnSearch.Location = new System.Drawing.Point(387, 173);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(39, 33);
            this.btnSearch.TabIndex = 69;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbSelect
            // 
            this.cbSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Location = new System.Drawing.Point(201, 149);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(159, 21);
            this.cbSelect.TabIndex = 72;
            this.cbSelect.SelectedIndexChanged += new System.EventHandler(this.cbSelect_SelectedIndexChanged);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.ForeColor = System.Drawing.Color.White;
            this.lblSelect.Location = new System.Drawing.Point(70, 149);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(106, 22);
            this.lblSelect.TabIndex = 71;
            this.lblSelect.Text = "Select mall";
            // 
            // EditMall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.cbSelect);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbOpen);
            this.Controls.Add(this.lblWorkingHours);
            this.Controls.Add(this.tbImage);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.tbAbout);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.cbTown);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lblEditMall);
            this.Name = "EditMall";
            this.Size = new System.Drawing.Size(771, 422);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditMall;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox cbTown;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox tbAbout;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.TextBox tbImage;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.TextBox tbOpen;
        private System.Windows.Forms.Label lblWorkingHours;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.Label lblSelect;
    }
}
