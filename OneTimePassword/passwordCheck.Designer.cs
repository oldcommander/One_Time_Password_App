namespace OneTimePassword
{
    partial class passwordCheck
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(passwordCheck));
            this.label1 = new System.Windows.Forms.Label();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_kod = new Guna.UI.WinForms.GunaTextBox();
            this.btn_yenikodAl = new Guna.UI.WinForms.GunaButton();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(59, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel1.Location = new System.Drawing.Point(117, 229);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(111, 25);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Kalan Süre: ";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gunaLabel2.Location = new System.Drawing.Point(234, 226);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(0, 28);
            this.gunaLabel2.TabIndex = 2;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel3.Location = new System.Drawing.Point(274, 229);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(65, 25);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "saniye";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_kod
            // 
            this.txt_kod.BackColor = System.Drawing.Color.Transparent;
            this.txt_kod.BaseColor = System.Drawing.Color.White;
            this.txt_kod.BorderColor = System.Drawing.Color.Silver;
            this.txt_kod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_kod.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_kod.FocusedBorderColor = System.Drawing.Color.Black;
            this.txt_kod.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_kod.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kod.Location = new System.Drawing.Point(122, 306);
            this.txt_kod.Name = "txt_kod";
            this.txt_kod.PasswordChar = '\0';
            this.txt_kod.SelectedText = "";
            this.txt_kod.Size = new System.Drawing.Size(217, 53);
            this.txt_kod.TabIndex = 4;
            this.txt_kod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_yenikodAl
            // 
            this.btn_yenikodAl.AnimationHoverSpeed = 0.07F;
            this.btn_yenikodAl.AnimationSpeed = 0.03F;
            this.btn_yenikodAl.BackColor = System.Drawing.Color.Transparent;
            this.btn_yenikodAl.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_yenikodAl.BorderColor = System.Drawing.Color.Black;
            this.btn_yenikodAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_yenikodAl.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_yenikodAl.FocusedColor = System.Drawing.Color.Empty;
            this.btn_yenikodAl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yenikodAl.ForeColor = System.Drawing.Color.White;
            this.btn_yenikodAl.Image = null;
            this.btn_yenikodAl.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_yenikodAl.Location = new System.Drawing.Point(39, 397);
            this.btn_yenikodAl.Name = "btn_yenikodAl";
            this.btn_yenikodAl.OnHoverBaseColor = System.Drawing.Color.Lime;
            this.btn_yenikodAl.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_yenikodAl.OnHoverForeColor = System.Drawing.Color.Black;
            this.btn_yenikodAl.OnHoverImage = null;
            this.btn_yenikodAl.OnPressedColor = System.Drawing.Color.Black;
            this.btn_yenikodAl.Radius = 18;
            this.btn_yenikodAl.Size = new System.Drawing.Size(129, 49);
            this.btn_yenikodAl.TabIndex = 6;
            this.btn_yenikodAl.Text = "Yeni Kod Al";
            this.btn_yenikodAl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_yenikodAl.Click += new System.EventHandler(this.btn_yenikodAl_Click);
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = null;
            this.gunaButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton3.Location = new System.Drawing.Point(291, 397);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.Yellow;
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Radius = 18;
            this.gunaButton3.Size = new System.Drawing.Size(134, 49);
            this.gunaButton3.TabIndex = 7;
            this.gunaButton3.Text = "Gönder";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton3.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 58);
            this.label2.TabIndex = 8;
            this.label2.Text = "hesabınıza gelen kodu belirtilen süre \r\niçerisinde aşağıdaki alana girin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 485);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gunaButton3);
            this.Controls.Add(this.btn_yenikodAl);
            this.Controls.Add(this.txt_kod);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "passwordCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "passwordCheck";
            this.Load += new System.EventHandler(this.passwordCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaTextBox txt_kod;
        private Guna.UI.WinForms.GunaButton btn_yenikodAl;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private System.Windows.Forms.Label label2;
    }
}