namespace v1go
{
    partial class Loader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loader));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblExpiry = new System.Windows.Forms.Label();
            this.lblActiveSubscriptions = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSelectCheat = new System.Windows.Forms.Label();
            this.lstCheats = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpGameInfo = new System.Windows.Forms.GroupBox();
            this.grpCheatInfo = new System.Windows.Forms.GroupBox();
            this.chkRememberCheat = new System.Windows.Forms.CheckBox();
            this.lblGameName = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDaysLeft = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblStatusLabel = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpGameInfo.SuspendLayout();
            this.grpCheatInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(18, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 74);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblExpiry
            // 
            this.lblExpiry.Location = new System.Drawing.Point(326, 24);
            this.lblExpiry.Name = "lblExpiry";
            this.lblExpiry.Size = new System.Drawing.Size(219, 13);
            this.lblExpiry.TabIndex = 2;
            this.lblExpiry.Text = "Your VIP will expire on {expiryDate}";
            // 
            // lblActiveSubscriptions
            // 
            this.lblActiveSubscriptions.Location = new System.Drawing.Point(390, 45);
            this.lblActiveSubscriptions.Name = "lblActiveSubscriptions";
            this.lblActiveSubscriptions.Size = new System.Drawing.Size(153, 13);
            this.lblActiveSubscriptions.TabIndex = 3;
            this.lblActiveSubscriptions.Text = "You have {activeSubscriptions} subscription active";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Location = new System.Drawing.Point(138, 85);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(297, 23);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome {username}!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectCheat
            // 
            this.lblSelectCheat.AutoSize = true;
            this.lblSelectCheat.Location = new System.Drawing.Point(18, 102);
            this.lblSelectCheat.Name = "lblSelectCheat";
            this.lblSelectCheat.Size = new System.Drawing.Size(88, 13);
            this.lblSelectCheat.TabIndex = 5;
            this.lblSelectCheat.Text = "Select the cheat:";
            // 
            // lstCheats
            // 
            this.lstCheats.FormattingEnabled = true;
            this.lstCheats.Items.AddRange(new object[] {
            "Counter-Strike: Global Offensive"});
            this.lstCheats.Location = new System.Drawing.Point(21, 121);
            this.lstCheats.Name = "lstCheats";
            this.lstCheats.ScrollAlwaysVisible = true;
            this.lstCheats.Size = new System.Drawing.Size(259, 225);
            this.lstCheats.TabIndex = 6;
            this.lstCheats.SelectedIndexChanged += new System.EventHandler(this.lstCheats_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Enabled = false;
            this.btnLoad.Location = new System.Drawing.Point(21, 364);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(259, 29);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(299, 364);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(259, 29);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpGameInfo
            // 
            this.grpGameInfo.Controls.Add(this.lblVersion);
            this.grpGameInfo.Controls.Add(this.lblGameName);
            this.grpGameInfo.Location = new System.Drawing.Point(299, 121);
            this.grpGameInfo.Name = "grpGameInfo";
            this.grpGameInfo.Size = new System.Drawing.Size(274, 82);
            this.grpGameInfo.TabIndex = 9;
            this.grpGameInfo.TabStop = false;
            this.grpGameInfo.Text = "Game Information";
            // 
            // grpCheatInfo
            // 
            this.grpCheatInfo.Controls.Add(this.lblStatus);
            this.grpCheatInfo.Controls.Add(this.lblStatusLabel);
            this.grpCheatInfo.Controls.Add(this.lblExpirationDate);
            this.grpCheatInfo.Controls.Add(this.lblDaysLeft);
            this.grpCheatInfo.Location = new System.Drawing.Point(299, 209);
            this.grpCheatInfo.Name = "grpCheatInfo";
            this.grpCheatInfo.Size = new System.Drawing.Size(274, 108);
            this.grpCheatInfo.TabIndex = 10;
            this.grpCheatInfo.TabStop = false;
            this.grpCheatInfo.Text = "Cheat Information";
            // 
            // chkRememberCheat
            // 
            this.chkRememberCheat.AutoSize = true;
            this.chkRememberCheat.Location = new System.Drawing.Point(299, 329);
            this.chkRememberCheat.Name = "chkRememberCheat";
            this.chkRememberCheat.Size = new System.Drawing.Size(152, 17);
            this.chkRememberCheat.TabIndex = 11;
            this.chkRememberCheat.Text = "Remember cheat selection";
            this.chkRememberCheat.UseVisualStyleBackColor = true;
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Location = new System.Drawing.Point(15, 34);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(10, 13);
            this.lblGameName.TabIndex = 0;
            this.lblGameName.Text = "-";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(15, 54);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(51, 13);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version: -";
            // 
            // lblDaysLeft
            // 
            this.lblDaysLeft.AutoSize = true;
            this.lblDaysLeft.Location = new System.Drawing.Point(13, 29);
            this.lblDaysLeft.Name = "lblDaysLeft";
            this.lblDaysLeft.Size = new System.Drawing.Size(176, 13);
            this.lblDaysLeft.TabIndex = 0;
            this.lblDaysLeft.Text = "This subscription will expire in - days";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(15, 59);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(88, 13);
            this.lblExpirationDate.TabIndex = 1;
            this.lblExpirationDate.Text = "Expiration Date: -";
            // 
            // lblStatusLabel
            // 
            this.lblStatusLabel.AutoSize = true;
            this.lblStatusLabel.Location = new System.Drawing.Point(15, 79);
            this.lblStatusLabel.Name = "lblStatusLabel";
            this.lblStatusLabel.Size = new System.Drawing.Size(40, 13);
            this.lblStatusLabel.TabIndex = 2;
            this.lblStatusLabel.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(51, 79);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(10, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "-";
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 413);
            this.Controls.Add(this.chkRememberCheat);
            this.Controls.Add(this.grpCheatInfo);
            this.Controls.Add(this.grpGameInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lstCheats);
            this.Controls.Add(this.lblSelectCheat);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblActiveSubscriptions);
            this.Controls.Add(this.lblExpiry);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Loader";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Loader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpGameInfo.ResumeLayout(false);
            this.grpGameInfo.PerformLayout();
            this.grpCheatInfo.ResumeLayout(false);
            this.grpCheatInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblExpiry;
        private System.Windows.Forms.Label lblActiveSubscriptions;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSelectCheat;
        private System.Windows.Forms.ListBox lstCheats;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpGameInfo;
        private System.Windows.Forms.GroupBox grpCheatInfo;
        private System.Windows.Forms.CheckBox chkRememberCheat;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDaysLeft;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblStatusLabel;
        private System.Windows.Forms.Label lblStatus;
    }
}