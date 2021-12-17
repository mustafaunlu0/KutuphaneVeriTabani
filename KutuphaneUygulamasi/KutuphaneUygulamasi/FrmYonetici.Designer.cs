namespace KutuphaneUygulamasi
{
    partial class FrmYonetici
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rdbDanisman = new System.Windows.Forms.RadioButton();
            this.rdbGuvenlik = new System.Windows.Forms.RadioButton();
            this.rdbTemizlik = new System.Windows.Forms.RadioButton();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCikar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbIslem = new System.Windows.Forms.GroupBox();
            this.btnPersonelletisim = new System.Windows.Forms.Button();
            this.btnPersonelYakini = new System.Windows.Forms.Button();
            this.btnPersonel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbIslem.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Ink Free", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yönetici Girişi";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel Id:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(172, 185);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(110, 23);
            this.txtId.TabIndex = 3;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(172, 210);
            this.txtAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(110, 23);
            this.txtAd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personel Adı:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(172, 234);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(110, 23);
            this.txtSoyad.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Personel Soyadı:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(27, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Personel Tipi:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(26, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "Personel Bilgileri";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(404, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 30);
            this.label7.TabIndex = 11;
            this.label7.Text = "Personel Tipi";
            // 
            // rdbDanisman
            // 
            this.rdbDanisman.AutoSize = true;
            this.rdbDanisman.Location = new System.Drawing.Point(172, 282);
            this.rdbDanisman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbDanisman.Name = "rdbDanisman";
            this.rdbDanisman.Size = new System.Drawing.Size(78, 19);
            this.rdbDanisman.TabIndex = 12;
            this.rdbDanisman.TabStop = true;
            this.rdbDanisman.Text = "Danışman";
            this.rdbDanisman.UseVisualStyleBackColor = true;
            this.rdbDanisman.CheckedChanged += new System.EventHandler(this.rdbDanisman_CheckedChanged);
            // 
            // rdbGuvenlik
            // 
            this.rdbGuvenlik.AutoSize = true;
            this.rdbGuvenlik.Location = new System.Drawing.Point(172, 305);
            this.rdbGuvenlik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbGuvenlik.Name = "rdbGuvenlik";
            this.rdbGuvenlik.Size = new System.Drawing.Size(71, 19);
            this.rdbGuvenlik.TabIndex = 13;
            this.rdbGuvenlik.TabStop = true;
            this.rdbGuvenlik.Text = "Güvenlik";
            this.rdbGuvenlik.UseVisualStyleBackColor = true;
            this.rdbGuvenlik.CheckedChanged += new System.EventHandler(this.rdbGuvenlik_CheckedChanged);
            // 
            // rdbTemizlik
            // 
            this.rdbTemizlik.AutoSize = true;
            this.rdbTemizlik.Location = new System.Drawing.Point(172, 327);
            this.rdbTemizlik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbTemizlik.Name = "rdbTemizlik";
            this.rdbTemizlik.Size = new System.Drawing.Size(67, 19);
            this.rdbTemizlik.TabIndex = 14;
            this.rdbTemizlik.TabStop = true;
            this.rdbTemizlik.Text = "Temizlik";
            this.rdbTemizlik.UseVisualStyleBackColor = true;
            this.rdbTemizlik.CheckedChanged += new System.EventHandler(this.rdbTemizlik_CheckedChanged);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(470, 185);
            this.txt1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(110, 23);
            this.txt1.TabIndex = 16;
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(402, 185);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(103, 22);
            this.lbl1.TabIndex = 15;
            this.lbl1.Text = "Blok:";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(470, 210);
            this.txt2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(110, 23);
            this.txt2.TabIndex = 18;
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(402, 211);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(103, 22);
            this.lbl2.TabIndex = 17;
            this.lbl2.Text = "Kat:";
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.IndianRed;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListele.ForeColor = System.Drawing.Color.Transparent;
            this.btnListele.Location = new System.Drawing.Point(460, 305);
            this.btnListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(82, 22);
            this.btnListele.TabIndex = 43;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.IndianRed;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.ForeColor = System.Drawing.Color.Transparent;
            this.btnEkle.Location = new System.Drawing.Point(404, 265);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(82, 22);
            this.btnEkle.TabIndex = 44;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnCikar
            // 
            this.btnCikar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCikar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCikar.Location = new System.Drawing.Point(520, 265);
            this.btnCikar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(82, 22);
            this.btnCikar.TabIndex = 45;
            this.btnCikar.Text = "Çıkar";
            this.btnCikar.UseVisualStyleBackColor = false;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 373);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(699, 278);
            this.dataGridView1.TabIndex = 47;
            // 
            // gbIslem
            // 
            this.gbIslem.Controls.Add(this.btnPersonelletisim);
            this.gbIslem.Controls.Add(this.btnPersonelYakini);
            this.gbIslem.Controls.Add(this.btnPersonel);
            this.gbIslem.Location = new System.Drawing.Point(27, 69);
            this.gbIslem.Name = "gbIslem";
            this.gbIslem.Size = new System.Drawing.Size(313, 54);
            this.gbIslem.TabIndex = 48;
            this.gbIslem.TabStop = false;
            this.gbIslem.Text = "KAYIT TÜRÜ";
            // 
            // btnPersonelletisim
            // 
            this.btnPersonelletisim.Location = new System.Drawing.Point(193, 22);
            this.btnPersonelletisim.Name = "btnPersonelletisim";
            this.btnPersonelletisim.Size = new System.Drawing.Size(112, 23);
            this.btnPersonelletisim.TabIndex = 2;
            this.btnPersonelletisim.Text = "Personel İletişim";
            this.btnPersonelletisim.UseVisualStyleBackColor = true;
            this.btnPersonelletisim.Click += new System.EventHandler(this.btnPersonelletisim_Click);
            // 
            // btnPersonelYakini
            // 
            this.btnPersonelYakini.Location = new System.Drawing.Point(87, 22);
            this.btnPersonelYakini.Name = "btnPersonelYakini";
            this.btnPersonelYakini.Size = new System.Drawing.Size(100, 23);
            this.btnPersonelYakini.TabIndex = 1;
            this.btnPersonelYakini.Text = "Personel Yakını";
            this.btnPersonelYakini.UseVisualStyleBackColor = true;
            this.btnPersonelYakini.Click += new System.EventHandler(this.btnPersonelYakini_Click);
            // 
            // btnPersonel
            // 
            this.btnPersonel.Location = new System.Drawing.Point(6, 22);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(75, 23);
            this.btnPersonel.TabIndex = 0;
            this.btnPersonel.Text = "Personel";
            this.btnPersonel.UseVisualStyleBackColor = true;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // FrmYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(728, 662);
            this.Controls.Add(this.gbIslem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.rdbTemizlik);
            this.Controls.Add(this.rdbGuvenlik);
            this.Controls.Add(this.rdbDanisman);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmYonetici";
            this.Text = "FrmYonetici";
            this.Load += new System.EventHandler(this.FrmYonetici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbIslem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtId;
        private TextBox txtAd;
        private Label label3;
        private TextBox txtSoyad;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private RadioButton rdbDanisman;
        private RadioButton rdbGuvenlik;
        private RadioButton rdbTemizlik;
        private TextBox txt1;
        private Label lbl1;
        private TextBox txt2;
        private Label lbl2;
        private Button btnListele;
        private Button btnEkle;
        private Button btnCikar;
        private DataGridView dataGridView1;
        private GroupBox gbIslem;
        private Button btnPersonelletisim;
        private Button btnPersonelYakini;
        private Button btnPersonel;
    }
}