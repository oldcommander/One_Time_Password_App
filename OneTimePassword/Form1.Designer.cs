namespace OneTimePassword
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.txt_user = new Guna.UI.WinForms.GunaTextBox();
            this.txt_password = new Guna.UI.WinForms.GunaTextBox();
            this.btn_cikis = new Guna.UI.WinForms.GunaButton();
            this.btn_giris = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(148, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.BackgroundImage")));
            this.gunaPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Location = new System.Drawing.Point(12, 182);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(66, 67);
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.BackgroundImage")));
            this.gunaPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Location = new System.Drawing.Point(12, 288);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(66, 65);
            this.gunaPictureBox2.TabIndex = 1;
            this.gunaPictureBox2.TabStop = false;
            // 
            // txt_user
            // 
            this.txt_user.BaseColor = System.Drawing.Color.White;
            this.txt_user.BorderColor = System.Drawing.Color.Silver;
            this.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_user.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_user.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_user.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_user.Location = new System.Drawing.Point(101, 192);
            this.txt_user.Name = "txt_user";
            this.txt_user.PasswordChar = '\0';
            this.txt_user.SelectedText = "";
            this.txt_user.Size = new System.Drawing.Size(329, 45);
            this.txt_user.TabIndex = 2;
            // 
            // txt_password
            // 
            this.txt_password.BaseColor = System.Drawing.Color.White;
            this.txt_password.BorderColor = System.Drawing.Color.Silver;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_password.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_password.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_password.Location = new System.Drawing.Point(101, 299);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.SelectedText = "";
            this.txt_password.Size = new System.Drawing.Size(329, 45);
            this.txt_password.TabIndex = 3;
            // 
            // btn_cikis
            // 
            this.btn_cikis.AnimationHoverSpeed = 0.07F;
            this.btn_cikis.AnimationSpeed = 0.03F;
            this.btn_cikis.BackColor = System.Drawing.Color.Transparent;
            this.btn_cikis.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_cikis.BorderColor = System.Drawing.Color.Black;
            this.btn_cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cikis.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_cikis.FocusedColor = System.Drawing.Color.Empty;
            this.btn_cikis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.ForeColor = System.Drawing.Color.White;
            this.btn_cikis.Image = null;
            this.btn_cikis.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_cikis.Location = new System.Drawing.Point(29, 414);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cikis.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_cikis.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_cikis.OnHoverImage = null;
            this.btn_cikis.OnPressedColor = System.Drawing.Color.Black;
            this.btn_cikis.Radius = 18;
            this.btn_cikis.Size = new System.Drawing.Size(138, 53);
            this.btn_cikis.TabIndex = 4;
            this.btn_cikis.Text = "ÇIKIŞ";
            this.btn_cikis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_giris
            // 
            this.btn_giris.AnimationHoverSpeed = 0.07F;
            this.btn_giris.AnimationSpeed = 0.03F;
            this.btn_giris.BackColor = System.Drawing.Color.Transparent;
            this.btn_giris.BaseColor = System.Drawing.Color.Green;
            this.btn_giris.BorderColor = System.Drawing.Color.Black;
            this.btn_giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_giris.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_giris.FocusedColor = System.Drawing.Color.Empty;
            this.btn_giris.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.ForeColor = System.Drawing.Color.White;
            this.btn_giris.Image = null;
            this.btn_giris.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_giris.Location = new System.Drawing.Point(267, 414);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_giris.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_giris.OnHoverForeColor = System.Drawing.Color.Black;
            this.btn_giris.OnHoverImage = null;
            this.btn_giris.OnPressedColor = System.Drawing.Color.Black;
            this.btn_giris.Radius = 18;
            this.btn_giris.Size = new System.Drawing.Size(138, 53);
            this.btn_giris.TabIndex = 5;
            this.btn_giris.Text = "GİRİŞ";
            this.btn_giris.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 503);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaTextBox txt_user;
        private Guna.UI.WinForms.GunaTextBox txt_password;
        private Guna.UI.WinForms.GunaButton btn_cikis;
        private Guna.UI.WinForms.GunaButton btn_giris;
    }
}

