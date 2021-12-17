namespace KutuphaneUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbYonetici = new System.Windows.Forms.RadioButton();
            this.rdbDanisman = new System.Windows.Forms.RadioButton();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Ink Free", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(108, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kütüphane Kayıt Sistemine Hoşgeldiniz";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(228, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanici Şifre:";
            // 
            // rdbYonetici
            // 
            this.rdbYonetici.AutoSize = true;
            this.rdbYonetici.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbYonetici.Location = new System.Drawing.Point(374, 164);
            this.rdbYonetici.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbYonetici.Name = "rdbYonetici";
            this.rdbYonetici.Size = new System.Drawing.Size(122, 23);
            this.rdbYonetici.TabIndex = 2;
            this.rdbYonetici.TabStop = true;
            this.rdbYonetici.Text = "Yönetici Girişi";
            this.rdbYonetici.UseVisualStyleBackColor = true;
            // 
            // rdbDanisman
            // 
            this.rdbDanisman.AutoSize = true;
            this.rdbDanisman.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbDanisman.Location = new System.Drawing.Point(374, 189);
            this.rdbDanisman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbDanisman.Name = "rdbDanisman";
            this.rdbDanisman.Size = new System.Drawing.Size(135, 23);
            this.rdbDanisman.TabIndex = 3;
            this.rdbDanisman.TabStop = true;
            this.rdbDanisman.Text = "Danışman Girişi";
            this.rdbDanisman.UseVisualStyleBackColor = true;
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKullaniciSifre.Location = new System.Drawing.Point(374, 133);
            this.txtKullaniciSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.Size = new System.Drawing.Size(134, 29);
            this.txtKullaniciSifre.TabIndex = 4;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.IndianRed;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGiris.Location = new System.Drawing.Point(374, 230);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(128, 27);
            this.btnGiris.TabIndex = 5;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(807, 494);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtKullaniciSifre);
            this.Controls.Add(this.rdbDanisman);
            this.Controls.Add(this.rdbYonetici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private RadioButton rdbYonetici;
        private RadioButton rdbDanisman;
        private TextBox txtKullaniciSifre;
        private Button btnGiris;
    }
}