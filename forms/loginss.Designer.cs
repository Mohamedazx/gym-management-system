
namespace elly_gym.forms
{
    partial class loginss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginss));
            this.showPass = new Bunifu.Framework.UI.BunifuCheckbox();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.user_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.RadioButton();
            this.admin = new System.Windows.Forms.RadioButton();
            this.bunifuImageButton7 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).BeginInit();
            this.SuspendLayout();
            // 
            // showPass
            // 
            this.showPass.BackColor = System.Drawing.Color.Maroon;
            this.showPass.ChechedOffColor = System.Drawing.Color.Maroon;
            this.showPass.Checked = false;
            this.showPass.CheckedOnColor = System.Drawing.Color.Maroon;
            this.showPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.showPass.Location = new System.Drawing.Point(30, 202);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(20, 20);
            this.showPass.TabIndex = 47;
            this.showPass.OnChange += new System.EventHandler(this.cb_OnChange);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.password.ForeColor = System.Drawing.Color.Maroon;
            this.password.HintForeColor = System.Drawing.Color.Empty;
            this.password.HintText = "";
            this.password.isPassword = true;
            this.password.LineFocusedColor = System.Drawing.Color.Maroon;
            this.password.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.password.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.password.LineThickness = 3;
            this.password.Location = new System.Drawing.Point(30, 162);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(271, 33);
            this.password.TabIndex = 46;
            this.password.Text = "كلمه المرور";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // user_name
            // 
            this.user_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.user_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user_name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.user_name.ForeColor = System.Drawing.Color.Maroon;
            this.user_name.HintForeColor = System.Drawing.Color.Empty;
            this.user_name.HintText = "";
            this.user_name.isPassword = false;
            this.user_name.LineFocusedColor = System.Drawing.Color.Maroon;
            this.user_name.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.user_name.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.user_name.LineThickness = 3;
            this.user_name.Location = new System.Drawing.Point(30, 109);
            this.user_name.Margin = new System.Windows.Forms.Padding(4);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(271, 33);
            this.user_name.TabIndex = 45;
            this.user_name.Text = "اسم المستخدم";
            this.user_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Longhaul", 20.24999F);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(124, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 31);
            this.label2.TabIndex = 44;
            this.label2.Text = "Login";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.Color.Transparent;
            this.user.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold);
            this.user.ForeColor = System.Drawing.Color.Maroon;
            this.user.Location = new System.Drawing.Point(190, 212);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(61, 24);
            this.user.TabIndex = 43;
            this.user.TabStop = true;
            this.user.Text = "User";
            this.user.UseVisualStyleBackColor = false;
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.BackColor = System.Drawing.Color.Transparent;
            this.admin.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.ForeColor = System.Drawing.Color.Maroon;
            this.admin.Location = new System.Drawing.Point(80, 212);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(75, 24);
            this.admin.TabIndex = 42;
            this.admin.TabStop = true;
            this.admin.Text = "Admin\r\n";
            this.admin.UseVisualStyleBackColor = false;
            // 
            // bunifuImageButton7
            // 
            this.bunifuImageButton7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton7.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton7.Image")));
            this.bunifuImageButton7.ImageActive = null;
            this.bunifuImageButton7.Location = new System.Drawing.Point(288, 12);
            this.bunifuImageButton7.Name = "bunifuImageButton7";
            this.bunifuImageButton7.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton7.TabIndex = 49;
            this.bunifuImageButton7.TabStop = false;
            this.bunifuImageButton7.Zoom = 10;
            this.bunifuImageButton7.Click += new System.EventHandler(this.bunifuImageButton7_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Login";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Longhaul", 14.24999F);
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton23.Location = new System.Drawing.Point(57, 287);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(199, 45);
            this.bunifuThinButton23.TabIndex = 48;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // loginss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(330, 353);
            this.Controls.Add(this.bunifuImageButton7);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user);
            this.Controls.Add(this.admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginss";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton7;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuCheckbox showPass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox user_name;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RadioButton user;
        public System.Windows.Forms.RadioButton admin;
    }
}