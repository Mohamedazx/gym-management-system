
namespace elly_gym.forms
{
    partial class show_players
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(show_players));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.costs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.d1 = new System.Windows.Forms.DateTimePicker();
            this.d2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dgp = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuThinButton27 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton26 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.typee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgp)).BeginInit();
            this.SuspendLayout();
            // 
            // costs
            // 
            resources.ApplyResources(this.costs, "costs");
            this.costs.ForeColor = System.Drawing.Color.Maroon;
            this.costs.Name = "costs";
            this.costs.Click += new System.EventHandler(this.costs_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Name = "label1";
            // 
            // search
            // 
            resources.ApplyResources(this.search, "search");
            this.search.Name = "search";
            this.search.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Name = "label10";
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.BackColor = System.Drawing.Color.Maroon;
            this.button6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // d1
            // 
            resources.ApplyResources(this.d1, "d1");
            this.d1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.d1.Name = "d1";
            // 
            // d2
            // 
            resources.ApplyResources(this.d2, "d2");
            this.d2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.d2.Name = "d2";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Name = "label2";
            // 
            // dgp
            // 
            this.dgp.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dgp, "dgp");
            this.dgp.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgp.DoubleBuffered = true;
            this.dgp.EnableHeadersVisualStyles = false;
            this.dgp.HeaderBgColor = System.Drawing.Color.Maroon;
            this.dgp.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgp.MultiSelect = false;
            this.dgp.Name = "dgp";
            this.dgp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            // 
            // bunifuThinButton27
            // 
            this.bunifuThinButton27.ActiveBorderThickness = 1;
            this.bunifuThinButton27.ActiveCornerRadius = 20;
            this.bunifuThinButton27.ActiveFillColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton27.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton27.ActiveLineColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.bunifuThinButton27, "bunifuThinButton27");
            this.bunifuThinButton27.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton27.ButtonText = "جمع الكل";
            this.bunifuThinButton27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton27.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton27.IdleBorderThickness = 1;
            this.bunifuThinButton27.IdleCornerRadius = 20;
            this.bunifuThinButton27.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton27.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton27.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton27.Name = "bunifuThinButton27";
            this.bunifuThinButton27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton27.Click += new System.EventHandler(this.bunifuThinButton27_Click);
            // 
            // bunifuThinButton26
            // 
            this.bunifuThinButton26.ActiveBorderThickness = 1;
            this.bunifuThinButton26.ActiveCornerRadius = 20;
            this.bunifuThinButton26.ActiveFillColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton26.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton26.ActiveLineColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.bunifuThinButton26, "bunifuThinButton26");
            this.bunifuThinButton26.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton26.ButtonText = "لاعب  جديد";
            this.bunifuThinButton26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton26.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton26.IdleBorderThickness = 1;
            this.bunifuThinButton26.IdleCornerRadius = 20;
            this.bunifuThinButton26.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton26.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton26.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton26.Name = "bunifuThinButton26";
            this.bunifuThinButton26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton26.Click += new System.EventHandler(this.bunifuThinButton26_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.bunifuThinButton23, "bunifuThinButton23");
            this.bunifuThinButton23.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton23.ButtonText = "تعديل";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.bunifuThinButton21, "bunifuThinButton21");
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.ButtonText = "تقرير";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.bunifuThinButton22, "bunifuThinButton22");
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.ButtonText = "القائــمه الرئيــسيه";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 20;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.bunifuThinButton24, "bunifuThinButton24");
            this.bunifuThinButton24.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton24.ButtonText = "تحديث";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // bunifuThinButton25
            // 
            this.bunifuThinButton25.ActiveBorderThickness = 1;
            this.bunifuThinButton25.ActiveCornerRadius = 20;
            this.bunifuThinButton25.ActiveFillColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton25.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton25.ActiveLineColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.bunifuThinButton25, "bunifuThinButton25");
            this.bunifuThinButton25.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton25.ButtonText = "حذف";
            this.bunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton25.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton25.IdleBorderThickness = 1;
            this.bunifuThinButton25.IdleCornerRadius = 20;
            this.bunifuThinButton25.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton25.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton25.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton25.Name = "bunifuThinButton25";
            this.bunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton25.Click += new System.EventHandler(this.bunifuThinButton25_Click);
            // 
            // typee
            // 
            resources.ApplyResources(this.typee, "typee");
            this.typee.ForeColor = System.Drawing.Color.Maroon;
            this.typee.Name = "typee";
            // 
            // show_players
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.typee);
            this.Controls.Add(this.bunifuThinButton27);
            this.Controls.Add(this.bunifuThinButton26);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton24);
            this.Controls.Add(this.bunifuThinButton25);
            this.Controls.Add(this.dgp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.costs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "show_players";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.show_players_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label costs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DateTimePicker d1;
        private System.Windows.Forms.DateTimePicker d2;
        private System.Windows.Forms.Label label2;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dgp;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton27;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton26;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
        private System.Windows.Forms.Label typee;
    }
}