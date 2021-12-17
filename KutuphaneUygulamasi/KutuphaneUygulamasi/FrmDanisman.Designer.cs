namespace KutuphaneUygulamasi
{
    partial class FrmDanisman
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
            this.rdbKitap = new System.Windows.Forms.RadioButton();
            this.rdbYayinevi = new System.Windows.Forms.RadioButton();
            this.rdbYazar = new System.Windows.Forms.RadioButton();
            this.rdbKullanici = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUygula = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnArama = new System.Windows.Forms.Button();
            this.btnKiralama = new System.Windows.Forms.Button();
            this.btnGuncelleme = new System.Windows.Forms.Button();
            this.btnSilme = new System.Windows.Forms.Button();
            this.btnEkleme = new System.Windows.Forms.Button();
            this.gbKullanici = new System.Windows.Forms.GroupBox();
            this.rdbOgrenci = new System.Windows.Forms.RadioButton();
            this.rdbAkademisyen = new System.Windows.Forms.RadioButton();
            this.rdbMisafir = new System.Windows.Forms.RadioButton();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDanismanNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbKullanici.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Ink Free", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danışman Girişi";
            // 
            // rdbKitap
            // 
            this.rdbKitap.AutoSize = true;
            this.rdbKitap.Location = new System.Drawing.Point(17, 22);
            this.rdbKitap.Name = "rdbKitap";
            this.rdbKitap.Size = new System.Drawing.Size(52, 19);
            this.rdbKitap.TabIndex = 10;
            this.rdbKitap.TabStop = true;
            this.rdbKitap.Text = "Kitap";
            this.rdbKitap.UseVisualStyleBackColor = true;
            this.rdbKitap.CheckedChanged += new System.EventHandler(this.rdbKitap_CheckedChanged);
            // 
            // rdbYayinevi
            // 
            this.rdbYayinevi.AutoSize = true;
            this.rdbYayinevi.Location = new System.Drawing.Point(75, 22);
            this.rdbYayinevi.Name = "rdbYayinevi";
            this.rdbYayinevi.Size = new System.Drawing.Size(68, 19);
            this.rdbYayinevi.TabIndex = 11;
            this.rdbYayinevi.TabStop = true;
            this.rdbYayinevi.Text = "Yayınevi";
            this.rdbYayinevi.UseVisualStyleBackColor = true;
            this.rdbYayinevi.CheckedChanged += new System.EventHandler(this.rdbYayinevi_CheckedChanged);
            // 
            // rdbYazar
            // 
            this.rdbYazar.AutoSize = true;
            this.rdbYazar.Location = new System.Drawing.Point(149, 22);
            this.rdbYazar.Name = "rdbYazar";
            this.rdbYazar.Size = new System.Drawing.Size(52, 19);
            this.rdbYazar.TabIndex = 12;
            this.rdbYazar.TabStop = true;
            this.rdbYazar.Text = "Yazar";
            this.rdbYazar.UseVisualStyleBackColor = true;
            this.rdbYazar.CheckedChanged += new System.EventHandler(this.rdbYazar_CheckedChanged);
            // 
            // rdbKullanici
            // 
            this.rdbKullanici.AutoSize = true;
            this.rdbKullanici.Location = new System.Drawing.Point(207, 22);
            this.rdbKullanici.Name = "rdbKullanici";
            this.rdbKullanici.Size = new System.Drawing.Size(70, 19);
            this.rdbKullanici.TabIndex = 13;
            this.rdbKullanici.TabStop = true;
            this.rdbKullanici.Text = "Kullanıcı";
            this.rdbKullanici.UseVisualStyleBackColor = true;
            this.rdbKullanici.CheckedChanged += new System.EventHandler(this.rdbKullanici_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "ISBN:";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(191, 204);
            this.txt1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(110, 23);
            this.txt1.TabIndex = 16;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(191, 245);
            this.txt2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(110, 23);
            this.txt2.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(35, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Başlık:";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(191, 286);
            this.txt3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(110, 23);
            this.txt3.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(35, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Baskı No:";
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(191, 332);
            this.txt4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(110, 23);
            this.txt4.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(35, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Danışman No:";
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(191, 380);
            this.txt5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(110, 23);
            this.txt5.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(35, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Yayınevi No:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 430);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(781, 326);
            this.dataGridView1.TabIndex = 25;
            // 
            // btnUygula
            // 
            this.btnUygula.BackColor = System.Drawing.Color.IndianRed;
            this.btnUygula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUygula.ForeColor = System.Drawing.Color.Transparent;
            this.btnUygula.Location = new System.Drawing.Point(454, 374);
            this.btnUygula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUygula.Name = "btnUygula";
            this.btnUygula.Size = new System.Drawing.Size(97, 33);
            this.btnUygula.TabIndex = 45;
            this.btnUygula.Text = "Uygula";
            this.btnUygula.UseVisualStyleBackColor = false;
            this.btnUygula.Click += new System.EventHandler(this.btnUygula_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.IndianRed;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListele.ForeColor = System.Drawing.Color.Transparent;
            this.btnListele.Location = new System.Drawing.Point(613, 374);
            this.btnListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(104, 33);
            this.btnListele.TabIndex = 54;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(607, 245);
            this.txt6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(110, 23);
            this.txt6.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(451, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "Bölüm Kodu:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(451, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 20);
            this.label10.TabIndex = 59;
            this.label10.Text = "Fiyat:";
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(607, 292);
            this.txt7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(110, 23);
            this.txt7.TabIndex = 60;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbYazar);
            this.groupBox1.Controls.Add(this.rdbKitap);
            this.groupBox1.Controls.Add(this.rdbYayinevi);
            this.groupBox1.Controls.Add(this.rdbKullanici);
            this.groupBox1.Location = new System.Drawing.Point(35, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 47);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İŞLEM";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnArama);
            this.groupBox2.Controls.Add(this.btnKiralama);
            this.groupBox2.Controls.Add(this.btnGuncelleme);
            this.groupBox2.Controls.Add(this.btnSilme);
            this.groupBox2.Controls.Add(this.btnEkleme);
            this.groupBox2.Location = new System.Drawing.Point(35, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 47);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İŞLEM TÜRÜ";
            // 
            // btnArama
            // 
            this.btnArama.Location = new System.Drawing.Point(354, 18);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(87, 23);
            this.btnArama.TabIndex = 66;
            this.btnArama.Text = "Arama";
            this.btnArama.UseVisualStyleBackColor = true;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // btnKiralama
            // 
            this.btnKiralama.Location = new System.Drawing.Point(261, 18);
            this.btnKiralama.Name = "btnKiralama";
            this.btnKiralama.Size = new System.Drawing.Size(87, 23);
            this.btnKiralama.TabIndex = 65;
            this.btnKiralama.Text = "Kiralama";
            this.btnKiralama.UseVisualStyleBackColor = true;
            this.btnKiralama.Click += new System.EventHandler(this.btnKiralama_Click);
            // 
            // btnGuncelleme
            // 
            this.btnGuncelleme.Location = new System.Drawing.Point(168, 18);
            this.btnGuncelleme.Name = "btnGuncelleme";
            this.btnGuncelleme.Size = new System.Drawing.Size(87, 23);
            this.btnGuncelleme.TabIndex = 64;
            this.btnGuncelleme.Text = "Güncelleme";
            this.btnGuncelleme.UseVisualStyleBackColor = true;
            this.btnGuncelleme.Click += new System.EventHandler(this.btnGuncelleme_Click);
            // 
            // btnSilme
            // 
            this.btnSilme.Location = new System.Drawing.Point(87, 18);
            this.btnSilme.Name = "btnSilme";
            this.btnSilme.Size = new System.Drawing.Size(75, 23);
            this.btnSilme.TabIndex = 64;
            this.btnSilme.Text = "Silme";
            this.btnSilme.UseVisualStyleBackColor = true;
            this.btnSilme.Click += new System.EventHandler(this.btnSilme_Click);
            // 
            // btnEkleme
            // 
            this.btnEkleme.Location = new System.Drawing.Point(6, 18);
            this.btnEkleme.Name = "btnEkleme";
            this.btnEkleme.Size = new System.Drawing.Size(75, 23);
            this.btnEkleme.TabIndex = 63;
            this.btnEkleme.Text = "Ekleme";
            this.btnEkleme.UseVisualStyleBackColor = true;
            this.btnEkleme.Click += new System.EventHandler(this.btnEkleme_Click);
            // 
            // gbKullanici
            // 
            this.gbKullanici.Controls.Add(this.rdbOgrenci);
            this.gbKullanici.Controls.Add(this.rdbAkademisyen);
            this.gbKullanici.Controls.Add(this.rdbMisafir);
            this.gbKullanici.Location = new System.Drawing.Point(451, 180);
            this.gbKullanici.Name = "gbKullanici";
            this.gbKullanici.Size = new System.Drawing.Size(266, 47);
            this.gbKullanici.TabIndex = 62;
            this.gbKullanici.TabStop = false;
            this.gbKullanici.Text = "KULLANICI TÜRÜ";
            // 
            // rdbOgrenci
            // 
            this.rdbOgrenci.AutoSize = true;
            this.rdbOgrenci.Location = new System.Drawing.Point(119, 22);
            this.rdbOgrenci.Name = "rdbOgrenci";
            this.rdbOgrenci.Size = new System.Drawing.Size(67, 19);
            this.rdbOgrenci.TabIndex = 12;
            this.rdbOgrenci.TabStop = true;
            this.rdbOgrenci.Text = "Öğrenci";
            this.rdbOgrenci.UseVisualStyleBackColor = true;
            this.rdbOgrenci.CheckedChanged += new System.EventHandler(this.rdbOgrenci_CheckedChanged);
            // 
            // rdbAkademisyen
            // 
            this.rdbAkademisyen.AutoSize = true;
            this.rdbAkademisyen.Location = new System.Drawing.Point(17, 22);
            this.rdbAkademisyen.Name = "rdbAkademisyen";
            this.rdbAkademisyen.Size = new System.Drawing.Size(96, 19);
            this.rdbAkademisyen.TabIndex = 10;
            this.rdbAkademisyen.TabStop = true;
            this.rdbAkademisyen.Text = "Akademisyen";
            this.rdbAkademisyen.UseVisualStyleBackColor = true;
            this.rdbAkademisyen.CheckedChanged += new System.EventHandler(this.rdbAkademisyen_CheckedChanged);
            // 
            // rdbMisafir
            // 
            this.rdbMisafir.AutoSize = true;
            this.rdbMisafir.Location = new System.Drawing.Point(192, 22);
            this.rdbMisafir.Name = "rdbMisafir";
            this.rdbMisafir.Size = new System.Drawing.Size(61, 19);
            this.rdbMisafir.TabIndex = 13;
            this.rdbMisafir.TabStop = true;
            this.rdbMisafir.Text = "Misafir";
            this.rdbMisafir.UseVisualStyleBackColor = true;
            this.rdbMisafir.CheckedChanged += new System.EventHandler(this.rdbMisafir_CheckedChanged);
            // 
            // txt8
            // 
            this.txt8.Location = new System.Drawing.Point(607, 332);
            this.txt8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(110, 23);
            this.txt8.TabIndex = 64;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(451, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 20);
            this.label11.TabIndex = 63;
            this.label11.Text = "Bölüm:";
            // 
            // txtDanismanNo
            // 
            this.txtDanismanNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDanismanNo.Location = new System.Drawing.Point(596, 78);
            this.txtDanismanNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDanismanNo.Name = "txtDanismanNo";
            this.txtDanismanNo.Size = new System.Drawing.Size(119, 29);
            this.txtDanismanNo.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(401, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 29);
            this.label7.TabIndex = 65;
            this.label7.Text = "Danisman No:";
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.IndianRed;
            this.btnara.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnara.ForeColor = System.Drawing.Color.Transparent;
            this.btnara.Location = new System.Drawing.Point(331, 202);
            this.btnara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(97, 33);
            this.btnara.TabIndex = 67;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // FrmDanisman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(848, 800);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.txtDanismanNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gbKullanici);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnUygula);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDanisman";
            this.Text = "FrmDanisman";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gbKullanici.ResumeLayout(false);
            this.gbKullanici.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RadioButton rdbKitap;
        private RadioButton rdbYayinevi;
        private RadioButton rdbYazar;
        private RadioButton rdbKullanici;
        private Label label2;
        private TextBox txt1;
        private TextBox txt2;
        private Label label3;
        private TextBox txt3;
        private Label label4;
        private TextBox txt4;
        private Label label5;
        private TextBox txt5;
        private Label label6;
        private DataGridView dataGridView1;
        private Button btnUygula;
        private Button btnListele;
        private TextBox txt6;
        private Label label8;
        private Label label10;
        private TextBox txt7;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnGuncelleme;
        private Button btnSilme;
        private Button btnEkleme;
        private GroupBox gbKullanici;
        private RadioButton rdbOgrenci;
        private RadioButton rdbAkademisyen;
        private RadioButton rdbMisafir;
        private TextBox txt8;
        private Label label11;
        private Button btnKiralama;
        private TextBox txtDanismanNo;
        private Label label7;
        private Button btnArama;
        private Button btnara;
    }
}