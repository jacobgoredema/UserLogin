namespace UserLogin.App
{
    partial class frmMainForm
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnInbox = new System.Windows.Forms.Button();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnBackground = new System.Windows.Forms.Button();
            this.btnSkin = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Controls.Add(this.btnHelp);
            this.panelTop.Controls.Add(this.btnUsers);
            this.panelTop.Controls.Add(this.btnReports);
            this.panelTop.Controls.Add(this.btnInbox);
            this.panelTop.Controls.Add(this.btnSendMessage);
            this.panelTop.Controls.Add(this.btnRegister);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(786, 78);
            this.panelTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(6, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.Image = global::UserLogin.App.Properties.Resources.help;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHelp.Location = new System.Drawing.Point(661, 7);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(106, 53);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            this.btnUsers.Image = global::UserLogin.App.Properties.Resources.user;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsers.Location = new System.Drawing.Point(554, 7);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(106, 53);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsers.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Image = global::UserLogin.App.Properties.Resources.report;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReports.Location = new System.Drawing.Point(447, 7);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(106, 53);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnInbox
            // 
            this.btnInbox.Image = global::UserLogin.App.Properties.Resources.envelope;
            this.btnInbox.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInbox.Location = new System.Drawing.Point(340, 7);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Size = new System.Drawing.Size(106, 53);
            this.btnInbox.TabIndex = 2;
            this.btnInbox.Text = "Inbox";
            this.btnInbox.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInbox.UseVisualStyleBackColor = true;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Image = global::UserLogin.App.Properties.Resources.send_sms;
            this.btnSendMessage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSendMessage.Location = new System.Drawing.Point(233, 7);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(106, 53);
            this.btnSendMessage.TabIndex = 1;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSendMessage.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Image = global::UserLogin.App.Properties.Resources.data_entry;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegister.Location = new System.Drawing.Point(126, 7);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(106, 53);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Data Entry";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // panelBottom
            // 
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Controls.Add(this.btnBackground);
            this.panelBottom.Controls.Add(this.btnSkin);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 322);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(786, 49);
            this.panelBottom.TabIndex = 0;
            this.panelBottom.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBottom_Paint);
            // 
            // btnBackground
            // 
            this.btnBackground.Location = new System.Drawing.Point(559, 8);
            this.btnBackground.Name = "btnBackground";
            this.btnBackground.Size = new System.Drawing.Size(101, 31);
            this.btnBackground.TabIndex = 8;
            this.btnBackground.Text = "Background";
            this.btnBackground.UseVisualStyleBackColor = true;
            // 
            // btnSkin
            // 
            this.btnSkin.Location = new System.Drawing.Point(666, 8);
            this.btnSkin.Name = "btnSkin";
            this.btnSkin.Size = new System.Drawing.Size(101, 31);
            this.btnSkin.TabIndex = 7;
            this.btnSkin.Text = "Skin";
            this.btnSkin.UseVisualStyleBackColor = true;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(786, 371);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnInbox;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBackground;
        private System.Windows.Forms.Button btnSkin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}