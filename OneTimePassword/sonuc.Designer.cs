namespace OneTimePassword
{
    partial class sonuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sonuc));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btn_cıkıs = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial Unicode MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(47, 196);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(485, 80);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "GİRİŞ BAŞARILI";
            // 
            // btn_cıkıs
            // 
            this.btn_cıkıs.AnimationHoverSpeed = 0.07F;
            this.btn_cıkıs.AnimationSpeed = 0.03F;
            this.btn_cıkıs.BackColor = System.Drawing.Color.Transparent;
            this.btn_cıkıs.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_cıkıs.BorderColor = System.Drawing.Color.Black;
            this.btn_cıkıs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cıkıs.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_cıkıs.FocusedColor = System.Drawing.Color.Empty;
            this.btn_cıkıs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cıkıs.ForeColor = System.Drawing.Color.White;
            this.btn_cıkıs.Image = null;
            this.btn_cıkıs.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_cıkıs.Location = new System.Drawing.Point(196, 401);
            this.btn_cıkıs.Name = "btn_cıkıs";
            this.btn_cıkıs.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_cıkıs.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_cıkıs.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_cıkıs.OnHoverImage = null;
            this.btn_cıkıs.OnPressedColor = System.Drawing.Color.Black;
            this.btn_cıkıs.Radius = 18;
            this.btn_cıkıs.Size = new System.Drawing.Size(160, 42);
            this.btn_cıkıs.TabIndex = 1;
            this.btn_cıkıs.Text = "ÇIKIŞ";
            this.btn_cıkıs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_cıkıs.Click += new System.EventHandler(this.btn_cıkıs_Click);
            // 
            // sonuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 535);
            this.Controls.Add(this.btn_cıkıs);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sonuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sonuc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btn_cıkıs;
    }
}