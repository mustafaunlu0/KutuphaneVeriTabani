using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneUygulamasi
{
    public partial class FrmYonetici : Form
    {
        Boolean personelYakini = false;
        Boolean personelIletisim = false;
        public FrmYonetici()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=kutuphanedb; user Id=postgres; password=123");
        private void tumVerileriTemizle()
        {
            lbl1.Hide();
            lbl2.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            txtAd.Hide();
            txtSoyad.Hide();
            txtId.Hide();
            txt1.Hide();
            txt2.Hide();
            rdbDanisman.Hide();
            rdbGuvenlik.Hide();
            rdbTemizlik.Hide();
        }
        private void tumVerileriGoster()
        {
            lbl1.Show();
            lbl2.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            txtAd.Show();
            txtSoyad.Show();
            txtId.Show();
            txt1.Show();
            txt2.Show();
            rdbDanisman.Show();
            rdbGuvenlik.Show();
            rdbTemizlik.Show();
        }

        private void FrmYonetici_Load(object sender, EventArgs e)
        {

        }

        private void rdbTemizlik_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Text = "Blok:";
            lbl2.Hide();
            txt2.Hide();
        }

        private void rdbGuvenlik_CheckedChanged(object sender, EventArgs e)
        {

            lbl1.Text = "Kapi No:";
            lbl2.Hide();
            txt2.Hide();
        }

        private void rdbDanisman_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Show();
            lbl2.Show();
            txt2.Show();
            lbl1.Text = "Blok:";
            lbl2.Text = "Kat:";
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (rdbDanisman.Checked && !personelYakini && !personelIletisim)
            {
                NpgsqlCommand komut1 = new NpgsqlCommand("Select * from danismanpersonel", baglanti);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut1);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                
            }
            else if (rdbGuvenlik.Checked && !personelYakini && !personelIletisim)
            {
                NpgsqlCommand komut1 = new NpgsqlCommand("Select * from guvenlikpersonel", baglanti);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut1);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                
            }
            else if (rdbTemizlik.Checked && !personelYakini && !personelIletisim)
            {
                NpgsqlCommand komut1 = new NpgsqlCommand("Select * from temizlikpersonel", baglanti);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut1);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                
            }
            else if (personelYakini)
            {
                NpgsqlCommand komut1 = new NpgsqlCommand("Select * from personelyakiniview", baglanti);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut1);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (personelIletisim)
            {
                NpgsqlCommand komut1 = new NpgsqlCommand("Select * from personeliletisimview", baglanti);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut1);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                NpgsqlCommand komut1 = new NpgsqlCommand("Select * from personel", baglanti);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut1);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            rdbDanisman.Checked = false;
            rdbGuvenlik.Checked = false;
            rdbTemizlik.Checked = false;
            baglanti.Close();


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();


            if (rdbDanisman.Checked)
            {
                NpgsqlCommand komut3 = new NpgsqlCommand("select * from insert_danisman(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);
                komut3.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
                komut3.Parameters.AddWithValue("@p2", txtAd.Text);
                komut3.Parameters.AddWithValue("@p3", txtSoyad.Text);
                komut3.Parameters.AddWithValue("@p4", 'D');
                komut3.Parameters.AddWithValue("@p5", txt1.Text);
                komut3.Parameters.AddWithValue("@p6", int.Parse(txt2.Text));
                komut3.Parameters.AddWithValue("@p7", 1);
                komut3.Parameters.AddWithValue("@p8", true);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut3);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }

            else if (rdbGuvenlik.Checked)
            {
                NpgsqlCommand komut4 = new NpgsqlCommand("select * from insert_guvenlik(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                komut4.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
                komut4.Parameters.AddWithValue("@p2", txtAd.Text);
                komut4.Parameters.AddWithValue("@p3", txtSoyad.Text);
                komut4.Parameters.AddWithValue("@p4", 'G');
                komut4.Parameters.AddWithValue("@p5", int.Parse(txt1.Text));
                komut4.Parameters.AddWithValue("@p6", 1);
                komut4.Parameters.AddWithValue("@p7", true);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut4);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (rdbTemizlik.Checked)
            {
                NpgsqlCommand komut5 = new NpgsqlCommand("select * from insert_temizlik(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                komut5.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
                komut5.Parameters.AddWithValue("@p2", txtAd.Text);
                komut5.Parameters.AddWithValue("@p3", txtSoyad.Text);
                komut5.Parameters.AddWithValue("@p4", 'T');
                komut5.Parameters.AddWithValue("@p5", txt1.Text);
                komut5.Parameters.AddWithValue("@p6", 1);
                komut5.Parameters.AddWithValue("@p7", true);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut5);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (personelYakini)
            {
                //personel yakını dolduran fonkiyon yazılacak

                NpgsqlCommand komut6 = new NpgsqlCommand("select * from insert_personelyakini(@p1,@p2,@p3)", baglanti);
                komut6.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
                komut6.Parameters.AddWithValue("@p2", txtAd.Text);
                komut6.Parameters.AddWithValue("@p3", int.Parse(txtSoyad.Text));
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut6);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                personelYakini = false;
            }
            if (personelIletisim)
            {
                //personel iletişim fonksisyonu yazılacak


                NpgsqlCommand komut6 = new NpgsqlCommand("select * from insert_personeliletisim(@p1,@p2,@p3,@p4)", baglanti);
                komut6.Parameters.AddWithValue("@p1", txtId.Text);
                komut6.Parameters.AddWithValue("@p2", txtAd.Text);
                komut6.Parameters.AddWithValue("@p3", int.Parse(txtSoyad.Text));
                komut6.Parameters.AddWithValue("@p4", txt1.Text);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut6);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                personelIletisim = false;
            }
            MessageBox.Show("İşlem başarıyla gerçekleşti!");
            rdbDanisman.Checked = false;
            rdbGuvenlik.Checked = false;
            rdbTemizlik.Checked = false;
            baglanti.Close();

        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            baglanti.Open();


            if (rdbDanisman.Checked)
            {               
                    NpgsqlCommand komutDeleteDanisman = new NpgsqlCommand("select * from delete_danisman(@p1)", baglanti);
                    komutDeleteDanisman.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(komutDeleteDanisman);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                MessageBox.Show("Silme işlemi başarıyla gerçekleşti!");
            }
            else if (rdbGuvenlik.Checked)
            {
                NpgsqlCommand komutDeleteGuvenlik = new NpgsqlCommand("select * from delete_guvenlik(@p1)", baglanti);
                komutDeleteGuvenlik.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komutDeleteGuvenlik);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                MessageBox.Show("Silme işlemi başarıyla gerçekleşti!");
            }
            else if (rdbTemizlik.Checked)
            {
                NpgsqlCommand komutDeleteTemizlik = new NpgsqlCommand("select * from delete_temizlik(@p1)", baglanti);
                komutDeleteTemizlik.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komutDeleteTemizlik);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                MessageBox.Show("Silme işlemi başarıyla gerçekleşti!");
            }
            else
            {
                MessageBox.Show("Lütfen silinecek personelin tipini işaretleyiniz!");
            }
            rdbDanisman.Checked = false;
            rdbGuvenlik.Checked = false;
            rdbTemizlik.Checked = false;
            baglanti.Close();
        }

        private void btnPersonelYakini_Click(object sender, EventArgs e)
        {
            tumVerileriTemizle();
            txtId.Show();
            txtAd.Show();
            txtSoyad.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label6.Show();
            label2.Text = "Yakın No:";
            label3.Text = "Yakın Tel:";
            label4.Text = "Personel Id:";
            label6.Text = "Personel Yakını";
            personelYakini = true;
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            tumVerileriGoster();
            label2.Text = "Personel Id:";
            label3.Text = "Personel Adı:";
            label4.Text = "Personel Soyadı:";
            label6.Text = "Personel Bilgileri";
            lbl1.Text = "Blok:";
        }

        private void btnPersonelletisim_Click(object sender, EventArgs e)
        {
            tumVerileriTemizle();
            txtId.Show();
            txtAd.Show();
            txtSoyad.Show();
            txt1.Show();
            lbl1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label6.Show();
            lbl1.Text = "Adres";
            label2.Text = "Personel TC:";
            label3.Text = "Personel Tel:";
            label4.Text = "Personel Id:";
            label6.Text = "Personel İletişim";
            personelIletisim = true;
        }
    }
}
