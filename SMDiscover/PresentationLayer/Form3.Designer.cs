namespace PresentationLayer
{
    partial class Form3
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
            DataLayer.models.User user1 = new DataLayer.models.User();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.pbCrown = new System.Windows.Forms.PictureBox();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnEditShop = new System.Windows.Forms.Button();
            this.btnEditMall = new System.Windows.Forms.Button();
            this.btnDiscover = new System.Windows.Forms.Button();
            this.panelDecoration1 = new System.Windows.Forms.Panel();
            this.panelIcon = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbAdmin = new System.Windows.Forms.PictureBox();
            this.panelDecoration2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.editMall1 = new PresentationLayer.EditMall();
            this.review1 = new PresentationLayer.Review();
            this.editUser1 = new PresentationLayer.EditUser();
            this.shoppingMall1 = new PresentationLayer.ShoppingMall();
            this.shop1 = new PresentationLayer.Shop();
            this.discover1 = new PresentationLayer.Discover();
            this.editShop1 = new PresentationLayer.EditShop();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrown)).BeginInit();
            this.panelIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.MenuPanel.Controls.Add(this.btnEditUser);
            this.MenuPanel.Controls.Add(this.pbCrown);
            this.MenuPanel.Controls.Add(this.SidePanel);
            this.MenuPanel.Controls.Add(this.btnEditShop);
            this.MenuPanel.Controls.Add(this.btnEditMall);
            this.MenuPanel.Controls.Add(this.btnDiscover);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(209, 583);
            this.MenuPanel.TabIndex = 0;
            // 
            // btnEditUser
            // 
            this.btnEditUser.FlatAppearance.BorderSize = 0;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.ForeColor = System.Drawing.Color.White;
            this.btnEditUser.Image = global::PresentationLayer.Properties.Resources.add;
            this.btnEditUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditUser.Location = new System.Drawing.Point(12, 317);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(197, 54);
            this.btnEditUser.TabIndex = 31;
            this.btnEditUser.Text = "User";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pbCrown
            // 
            this.pbCrown.Image = global::PresentationLayer.Properties.Resources.crown_96px;
            this.pbCrown.Location = new System.Drawing.Point(51, 25);
            this.pbCrown.Name = "pbCrown";
            this.pbCrown.Size = new System.Drawing.Size(96, 90);
            this.pbCrown.TabIndex = 30;
            this.pbCrown.TabStop = false;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(197)))), ((int)(((byte)(130)))));
            this.SidePanel.Location = new System.Drawing.Point(1, 151);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 54);
            this.SidePanel.TabIndex = 4;
            // 
            // btnEditShop
            // 
            this.btnEditShop.FlatAppearance.BorderSize = 0;
            this.btnEditShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditShop.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditShop.ForeColor = System.Drawing.Color.White;
            this.btnEditShop.Image = global::PresentationLayer.Properties.Resources.add;
            this.btnEditShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditShop.Location = new System.Drawing.Point(12, 257);
            this.btnEditShop.Name = "btnEditShop";
            this.btnEditShop.Size = new System.Drawing.Size(197, 54);
            this.btnEditShop.TabIndex = 4;
            this.btnEditShop.Text = "Shop";
            this.btnEditShop.UseVisualStyleBackColor = true;
            this.btnEditShop.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEditMall
            // 
            this.btnEditMall.FlatAppearance.BorderSize = 0;
            this.btnEditMall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMall.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMall.ForeColor = System.Drawing.Color.White;
            this.btnEditMall.Image = global::PresentationLayer.Properties.Resources.add;
            this.btnEditMall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditMall.Location = new System.Drawing.Point(12, 203);
            this.btnEditMall.Name = "btnEditMall";
            this.btnEditMall.Size = new System.Drawing.Size(197, 54);
            this.btnEditMall.TabIndex = 4;
            this.btnEditMall.Text = "Mall";
            this.btnEditMall.UseVisualStyleBackColor = true;
            this.btnEditMall.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDiscover
            // 
            this.btnDiscover.FlatAppearance.BorderSize = 0;
            this.btnDiscover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscover.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscover.ForeColor = System.Drawing.Color.White;
            this.btnDiscover.Image = global::PresentationLayer.Properties.Resources.location_32px;
            this.btnDiscover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscover.Location = new System.Drawing.Point(12, 149);
            this.btnDiscover.Name = "btnDiscover";
            this.btnDiscover.Size = new System.Drawing.Size(197, 54);
            this.btnDiscover.TabIndex = 4;
            this.btnDiscover.Text = "Discover";
            this.btnDiscover.UseVisualStyleBackColor = true;
            this.btnDiscover.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelDecoration1
            // 
            this.panelDecoration1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(197)))), ((int)(((byte)(130)))));
            this.panelDecoration1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDecoration1.Location = new System.Drawing.Point(209, 0);
            this.panelDecoration1.Name = "panelDecoration1";
            this.panelDecoration1.Size = new System.Drawing.Size(817, 10);
            this.panelDecoration1.TabIndex = 1;
            // 
            // panelIcon
            // 
            this.panelIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(197)))), ((int)(((byte)(130)))));
            this.panelIcon.Controls.Add(this.label3);
            this.panelIcon.Controls.Add(this.label2);
            this.panelIcon.Controls.Add(this.pbAdmin);
            this.panelIcon.Location = new System.Drawing.Point(243, 0);
            this.panelIcon.Name = "panelIcon";
            this.panelIcon.Size = new System.Drawing.Size(136, 143);
            this.panelIcon.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Moderate hell out of it";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Good day sir!";
            // 
            // pbAdmin
            // 
            this.pbAdmin.Image = global::PresentationLayer.Properties.Resources.moderator_96px;
            this.pbAdmin.Location = new System.Drawing.Point(23, 16);
            this.pbAdmin.Name = "pbAdmin";
            this.pbAdmin.Size = new System.Drawing.Size(89, 66);
            this.pbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdmin.TabIndex = 4;
            this.pbAdmin.TabStop = false;
            // 
            // panelDecoration2
            // 
            this.panelDecoration2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelDecoration2.Location = new System.Drawing.Point(385, 120);
            this.panelDecoration2.Name = "panelDecoration2";
            this.panelDecoration2.Size = new System.Drawing.Size(629, 10);
            this.panelDecoration2.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PresentationLayer.Properties.Resources.adminBanner;
            this.pictureBox2.Location = new System.Drawing.Point(386, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(536, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::PresentationLayer.Properties.Resources.shutdown_32px;
            this.btnClose.Location = new System.Drawing.Point(977, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 35);
            this.btnClose.TabIndex = 4;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button13_Click);
            // 
            // btnNotifications
            // 
            this.btnNotifications.FlatAppearance.BorderSize = 0;
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotifications.ForeColor = System.Drawing.Color.White;
            this.btnNotifications.Image = global::PresentationLayer.Properties.Resources.notification_32px;
            this.btnNotifications.Location = new System.Drawing.Point(928, 19);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(32, 35);
            this.btnNotifications.TabIndex = 4;
            this.btnNotifications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotifications.UseVisualStyleBackColor = true;
            // 
            // editMall1
            // 
            this.editMall1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.editMall1.Location = new System.Drawing.Point(243, 146);
            this.editMall1.Name = "editMall1";
            this.editMall1.Size = new System.Drawing.Size(771, 422);
            this.editMall1.TabIndex = 20;
            // 
            // review1
            // 
            this.review1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.review1.Location = new System.Drawing.Point(648, 203);
            this.review1.Name = "review1";
            this.review1.Shop = null;
            this.review1.Size = new System.Drawing.Size(351, 271);
            this.review1.TabIndex = 19;
            user1.Admin = 0;
            user1.Answer = null;
            user1.Email = null;
            user1.Id = 0;
            user1.Name = null;
            user1.Password = null;
            user1.SecretQuestion = null;
            user1.Surname = null;
            user1.Username = null;
            this.review1.User = user1;
            // 
            // editUser1
            // 
            this.editUser1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.editUser1.Location = new System.Drawing.Point(243, 146);
            this.editUser1.Name = "editUser1";
            this.editUser1.Size = new System.Drawing.Size(771, 422);
            this.editUser1.TabIndex = 18;
            // 
            // shoppingMall1
            // 
            this.shoppingMall1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.shoppingMall1.Discover = null;
            this.shoppingMall1.Location = new System.Drawing.Point(243, 149);
            this.shoppingMall1.Name = "shoppingMall1";
            this.shoppingMall1.Shop = null;
            this.shoppingMall1.Size = new System.Drawing.Size(771, 422);
            this.shoppingMall1.TabIndex = 17;
            // 
            // shop1
            // 
            this.shop1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.shop1.Location = new System.Drawing.Point(243, 146);
            this.shop1.Name = "shop1";
            this.shop1.Review = null;
            this.shop1.ShoppingMall = null;
            this.shop1.Size = new System.Drawing.Size(771, 422);
            this.shop1.TabIndex = 16;
            // 
            // discover1
            // 
            this.discover1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.discover1.Location = new System.Drawing.Point(243, 149);
            this.discover1.Name = "discover1";
            this.discover1.ShoppingMall = null;
            this.discover1.Size = new System.Drawing.Size(771, 422);
            this.discover1.TabIndex = 15;
            // 
            // editShop1
            // 
            this.editShop1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.editShop1.Location = new System.Drawing.Point(243, 146);
            this.editShop1.Name = "editShop1";
            this.editShop1.Size = new System.Drawing.Size(771, 422);
            this.editShop1.TabIndex = 21;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 583);
            this.Controls.Add(this.review1);
            this.Controls.Add(this.editShop1);
            this.Controls.Add(this.editMall1);
            this.Controls.Add(this.editUser1);
            this.Controls.Add(this.shoppingMall1);
            this.Controls.Add(this.shop1);
            this.Controls.Add(this.discover1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelDecoration2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNotifications);
            this.Controls.Add(this.panelIcon);
            this.Controls.Add(this.panelDecoration1);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCrown)).EndInit();
            this.panelIcon.ResumeLayout(false);
            this.panelIcon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button btnEditMall;
        private System.Windows.Forms.Button btnDiscover;
        private System.Windows.Forms.Panel panelDecoration1;
        private System.Windows.Forms.Panel panelIcon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbAdmin;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnEditShop;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelDecoration2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbCrown;
        private System.Windows.Forms.Button btnEditUser;
        private Discover discover1;
        private Shop shop1;
        private ShoppingMall shoppingMall1;
        private EditUser editUser1;
        private Review review1;
        private EditMall editMall1;
        private EditShop editShop1;
    }
}

