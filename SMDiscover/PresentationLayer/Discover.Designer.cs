namespace PresentationLayer
{
    partial class Discover
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.lblDiscover = new System.Windows.Forms.Label();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.cbTown = new System.Windows.Forms.ComboBox();
            this.lvDiscover = new System.Windows.Forms.ListView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDiscover
            // 
            this.lblDiscover.AutoSize = true;
            this.lblDiscover.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(197)))), ((int)(((byte)(130)))));
            this.lblDiscover.Location = new System.Drawing.Point(127, 28);
            this.lblDiscover.Name = "lblDiscover";
            this.lblDiscover.Size = new System.Drawing.Size(488, 22);
            this.lblDiscover.TabIndex = 34;
            this.lblDiscover.Text = "Pleas select country and town you want, thank you.";
            // 
            // cbCountry
            // 
            this.cbCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(184, 66);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(180, 21);
            this.cbCountry.TabIndex = 35;
            // 
            // cbTown
            // 
            this.cbTown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTown.FormattingEnabled = true;
            this.cbTown.Location = new System.Drawing.Point(396, 66);
            this.cbTown.Name = "cbTown";
            this.cbTown.Size = new System.Drawing.Size(180, 21);
            this.cbTown.TabIndex = 36;
            // 
            // lvDiscover
            // 
            this.lvDiscover.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvDiscover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.lvDiscover.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvDiscover.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lvDiscover.ForeColor = System.Drawing.Color.White;
            this.lvDiscover.FullRowSelect = true;
            this.lvDiscover.HideSelection = false;
            listViewItem1.IndentCount = 124;
            this.lvDiscover.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lvDiscover.Location = new System.Drawing.Point(18, 115);
            this.lvDiscover.Name = "lvDiscover";
            this.lvDiscover.Size = new System.Drawing.Size(731, 247);
            this.lvDiscover.TabIndex = 37;
            this.lvDiscover.UseCompatibleStateImageBehavior = false;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(197)))), ((int)(((byte)(130)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::PresentationLayer.Properties.Resources.location_32px;
            this.btnSearch.Location = new System.Drawing.Point(343, 368);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 33);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Discover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lvDiscover);
            this.Controls.Add(this.cbTown);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.lblDiscover);
            this.Name = "Discover";
            this.Size = new System.Drawing.Size(771, 422);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiscover;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.ComboBox cbTown;
        private System.Windows.Forms.ListView lvDiscover;
        private System.Windows.Forms.Button btnSearch;
    }
}
