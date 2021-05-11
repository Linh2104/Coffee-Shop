namespace 喫茶店管理システム
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.boxMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.boxExit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtUserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.chkboxShowPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkboxRemember = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxExit)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(69)))), ((int)(((byte)(57)))));
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.boxIcon);
            this.guna2Panel2.Controls.Add(this.boxMinimize);
            this.guna2Panel2.Controls.Add(this.boxExit);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(338, 162);
            this.guna2Panel2.TabIndex = 2;
            // 
            // boxMinimize
            // 
            this.boxMinimize.Image = ((System.Drawing.Image)(resources.GetObject("boxMinimize.Image")));
            this.boxMinimize.Location = new System.Drawing.Point(272, 3);
            this.boxMinimize.Name = "boxMinimize";
            this.boxMinimize.ShadowDecoration.Parent = this.boxMinimize;
            this.boxMinimize.Size = new System.Drawing.Size(29, 24);
            this.boxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxMinimize.TabIndex = 4;
            this.boxMinimize.TabStop = false;
            this.boxMinimize.Click += new System.EventHandler(this.boxMinimize_Click);
            // 
            // boxExit
            // 
            this.boxExit.Image = ((System.Drawing.Image)(resources.GetObject("boxExit.Image")));
            this.boxExit.Location = new System.Drawing.Point(300, 5);
            this.boxExit.Name = "boxExit";
            this.boxExit.ShadowDecoration.Parent = this.boxExit;
            this.boxExit.Size = new System.Drawing.Size(29, 21);
            this.boxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxExit.TabIndex = 3;
            this.boxExit.TabStop = false;
            this.boxExit.Click += new System.EventHandler(this.boxExit_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserID.DefaultText = "";
            this.txtUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserID.DisabledState.Parent = this.txtUserID;
            this.txtUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserID.FocusedState.Parent = this.txtUserID;
            this.txtUserID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserID.HoverState.Parent = this.txtUserID;
            this.txtUserID.Location = new System.Drawing.Point(40, 197);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserID.MaxLength = 20;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.PasswordChar = '\0';
            this.txtUserID.PlaceholderText = "UserID";
            this.txtUserID.SelectedText = "";
            this.txtUserID.ShadowDecoration.Parent = this.txtUserID;
            this.txtUserID.Size = new System.Drawing.Size(261, 54);
            this.txtUserID.TabIndex = 3;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserPassword.DefaultText = "";
            this.txtUserPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserPassword.DisabledState.Parent = this.txtUserPassword;
            this.txtUserPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserPassword.FocusedState.Parent = this.txtUserPassword;
            this.txtUserPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUserPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserPassword.HoverState.Parent = this.txtUserPassword;
            this.txtUserPassword.Location = new System.Drawing.Point(40, 259);
            this.txtUserPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserPassword.MaxLength = 20;
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '\0';
            this.txtUserPassword.PlaceholderText = "Password";
            this.txtUserPassword.SelectedText = "";
            this.txtUserPassword.ShadowDecoration.Parent = this.txtUserPassword;
            this.txtUserPassword.Size = new System.Drawing.Size(261, 54);
            this.txtUserPassword.TabIndex = 4;
            this.txtUserPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(69)))), ((int)(((byte)(57)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogin.Location = new System.Drawing.Point(80, 384);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(180, 45);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkboxShowPass
            // 
            this.chkboxShowPass.AutoSize = true;
            this.chkboxShowPass.BackColor = System.Drawing.Color.Transparent;
            this.chkboxShowPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkboxShowPass.CheckedState.BorderRadius = 0;
            this.chkboxShowPass.CheckedState.BorderThickness = 0;
            this.chkboxShowPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkboxShowPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxShowPass.ForeColor = System.Drawing.Color.Black;
            this.chkboxShowPass.Location = new System.Drawing.Point(40, 347);
            this.chkboxShowPass.Name = "chkboxShowPass";
            this.chkboxShowPass.Size = new System.Drawing.Size(108, 19);
            this.chkboxShowPass.TabIndex = 6;
            this.chkboxShowPass.Text = "Show Password";
            this.chkboxShowPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkboxShowPass.UncheckedState.BorderRadius = 0;
            this.chkboxShowPass.UncheckedState.BorderThickness = 0;
            this.chkboxShowPass.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.chkboxShowPass.UseVisualStyleBackColor = false;
            this.chkboxShowPass.CheckedChanged += new System.EventHandler(this.chkboxShowPass_CheckedChanged);
            // 
            // chkboxRemember
            // 
            this.chkboxRemember.AutoSize = true;
            this.chkboxRemember.BackColor = System.Drawing.Color.Transparent;
            this.chkboxRemember.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkboxRemember.CheckedState.BorderRadius = 0;
            this.chkboxRemember.CheckedState.BorderThickness = 0;
            this.chkboxRemember.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkboxRemember.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxRemember.ForeColor = System.Drawing.Color.Black;
            this.chkboxRemember.Location = new System.Drawing.Point(40, 322);
            this.chkboxRemember.Name = "chkboxRemember";
            this.chkboxRemember.Size = new System.Drawing.Size(104, 19);
            this.chkboxRemember.TabIndex = 5;
            this.chkboxRemember.Text = "Remember me";
            this.chkboxRemember.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkboxRemember.UncheckedState.BorderRadius = 0;
            this.chkboxRemember.UncheckedState.BorderThickness = 0;
            this.chkboxRemember.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.chkboxRemember.UseVisualStyleBackColor = false;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(69)))), ((int)(((byte)(57)))));
            this.guna2Panel3.Controls.Add(this.label4);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 457);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(338, 47);
            this.guna2Panel3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(26, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Software Version 1.0.0.1";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Black;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.Location = new System.Drawing.Point(117, 35);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(100, 108);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 1;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.label3.Location = new System.Drawing.Point(68, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login below to get started";
            // 
            // boxIcon
            // 
            this.boxIcon.Image = ((System.Drawing.Image)(resources.GetObject("boxIcon.Image")));
            this.boxIcon.Location = new System.Drawing.Point(3, 3);
            this.boxIcon.Name = "boxIcon";
            this.boxIcon.ShadowDecoration.Parent = this.boxIcon;
            this.boxIcon.Size = new System.Drawing.Size(29, 24);
            this.boxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxIcon.TabIndex = 5;
            this.boxIcon.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 504);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.chkboxRemember);
            this.Controls.Add(this.chkboxShowPass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MIU COFFEE HOUSE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxExit)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox boxMinimize;
        private Guna.UI2.WinForms.Guna2PictureBox boxExit;
        private Guna.UI2.WinForms.Guna2TextBox txtUserID;
        private Guna.UI2.WinForms.Guna2TextBox txtUserPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2CheckBox chkboxShowPass;
        private Guna.UI2.WinForms.Guna2CheckBox chkboxRemember;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox boxIcon;
    }
}

