using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneUygulamasi
{
    public partial class FrmDanisman : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=kutuphanedb; user Id=postgres; password=123");
        Boolean sayac = false;
        Boolean silmeIslem = false;
        Boolean kitapGuncelleme = false;
        Boolean yazarGuncelleme = false;
        Boolean yayineviGuncelleme = false;
        Boolean kullaniciGuncelleme = false;
        

        public FrmDanisman()
        {
            InitializeComponent();
            rdbKitap.Checked=true;
            ekBilgiGizle();
            gbKullanici.Hide();
            btnara.Hide();
        }
        private void ekBilgiGizle()
        {
            label8.Hide();     
            label10.Hide();
            label11.Hide();
            txt6.Hide();
            txt7.Hide();
            txt8.Hide();
        }

        private void ekBilgiGoster()
        {
            label8.Show();
            label10.Show();
            txt6.Show();
            txt7.Show();
        }

        private void tumVerileriGoster()
        {
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label8.Show();
            label10.Show();
            label11.Show();
            txt1.Show();
            txt2.Show();
            txt3.Show();
            txt4.Show();
            txt5.Show();
            txt6.Show();
            txt7.Show();
            txt8.Show();
            gbKullanici.Hide();
        }
        private void tumVerileriGizle()
        {

            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label8.Hide();
            label10.Hide();
            label11.Hide();
            txt1.Hide();
            txt2.Hide();
            txt3.Hide();
            txt4.Hide();
            txt5.Hide();
            txt6.Hide();
            txt7.Hide();
            txt8.Hide();
            
        }

        private void rdbYayinevi_CheckedChanged(object sender, EventArgs e)
        {
            tumVerileriGoster();
            ekBilgiGizle();
                label6.Show();
                label5.Show();
                txt4.Show();
                txt5.Show();
                label2.Text = "Yayınevi Kodu:";
                label3.Text = "Yayınevi Adi:";
                label4.Text = "Yayınevi Tel No:";
                label5.Text = "Yayınevi Web:";
                label6.Text = "Yayınevi Mail:";
            
        }

        private void rdbKitap_CheckedChanged(object sender, EventArgs e)
        {
            tumVerileriGoster();
            ekBilgiGizle();
            label5.Show();
            txt4.Show();
            label6.Show();
            txt5.Show();
            label2.Text = "ISBN:";
            label3.Text = "Başlık:";
            label4.Text = "Baskı No:";
            label5.Text = "Danışman No:";
            label6.Text = "Yayınevi No:";
      



        }

        private void rdbYazar_CheckedChanged(object sender, EventArgs e)
        {
            tumVerileriGoster();
            ekBilgiGizle();
            label5.Show();
            txt4.Show();
            label2.Text = "Yazar No";
            label3.Text = "ISBN:";
            label4.Text = "Yazar Adı:";
            label5.Text = "Yazar Soyadı:";
            label6.Text = "Yazar Mail:";
        }

        private void rdbKullanici_CheckedChanged(object sender, EventArgs e)
        {
            tumVerileriGoster();
            ekBilgiGizle();
            label5.Show();
            txt4.Show();
            label2.Text = "Kullanıcı Id:";
            label3.Text = "Kullanıcı Adı:";
            label4.Text = "Kullanıcı Soyadı:";
            label5.Text = "Kullanıcı Tipi:";
            label6.Hide();
            txt5.Hide();

        }

        private void btnEkleme_Click(object sender, EventArgs e)
        {
            btnara.Hide();
            if (rdbKitap.Checked)
            {
                tumVerileriGoster();
                ekBilgiGoster();
                label11.Hide();
                txt8.Hide();
                label8.Text = "Bölüm Kodu:";
               
                label10.Text = "Fiyat:";

            }
            else if (rdbKullanici.Checked)
            {
                tumVerileriGoster();
                ekBilgiGoster();
                gbKullanici.Show();
                label6.Hide();
                txt5.Hide();
                label10.Text = "Kullanıcı Tel:";
                txt7.Show();
                label8.Text = "TC No:";
                
            }
            else if (rdbYayinevi.Checked)
            {
                tumVerileriGoster();
                ekBilgiGizle();
                label6.Show();
                label5.Show();
                txt4.Show();
                txt5.Show();
                label2.Text = "Yayınevi Kodu:";
                label3.Text = "Yayınevi Adi:";
                label4.Text = "Yayınevi Tel No:";
                label5.Text = "Yayınevi Web:";
                label6.Text = "Yayınevi Mail:";
            }
            else if (rdbYazar.Checked)
            {

                tumVerileriGoster();
                ekBilgiGizle();
                label5.Show();
                txt4.Show();
                label2.Text = "Yazar No";
                label3.Text = "ISBN:";
                label4.Text = "Yazar Adı:";
                label5.Text = "Yazar Soyadı:";
                label6.Text = "Yazar Mail:";
            }
            
        }

        private void btnUygula_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (rdbKitap.Checked && !sayac && !silmeIslem && !kitapGuncelleme)
            {
                NpgsqlCommand komut = new NpgsqlCommand("select * from insert_kitap(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);
                komut.Parameters.AddWithValue("@p1", txt1.Text);
                komut.Parameters.AddWithValue("@p2", txt2.Text);
                komut.Parameters.AddWithValue("@p3", int.Parse(txt3.Text));
                komut.Parameters.AddWithValue("@p4", int.Parse(txt4.Text));
                komut.Parameters.AddWithValue("@p5", int.Parse(txt5.Text));
                komut.Parameters.AddWithValue("@p6", true);
                komut.Parameters.AddWithValue("@p7", int.Parse(txt6.Text));
                komut.Parameters.AddWithValue("@p8", int.Parse(txt7.Text));

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (rdbYazar.Checked && !silmeIslem && !yazarGuncelleme)
            {
                NpgsqlCommand komuty = new NpgsqlCommand("select * from insert_yazar(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                komuty.Parameters.AddWithValue("@p1", int.Parse(txt1.Text));
                komuty.Parameters.AddWithValue("@p2", txt2.Text);
                komuty.Parameters.AddWithValue("@p3", txt3.Text);
                komuty.Parameters.AddWithValue("@p4", txt4.Text);
                komuty.Parameters.AddWithValue("@p5", txt5.Text);
                komuty.Parameters.AddWithValue("@p6", true);
                komuty.Parameters.AddWithValue("@p7", int.Parse(txtDanismanNo.Text));
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komuty);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (rdbYayinevi.Checked && !silmeIslem && !yayineviGuncelleme)
            {
                NpgsqlCommand komutye = new NpgsqlCommand("select * from insert_yayinevi(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                komutye.Parameters.AddWithValue("@p1", int.Parse(txt1.Text));
                komutye.Parameters.AddWithValue("@p2", txt2.Text);
                komutye.Parameters.AddWithValue("@p3", txt3.Text);
                komutye.Parameters.AddWithValue("@p4", txt4.Text);
                komutye.Parameters.AddWithValue("@p5", txt5.Text);
                komutye.Parameters.AddWithValue("@p6", true);
                komutye.Parameters.AddWithValue("@p7", int.Parse(txtDanismanNo.Text));
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komutye);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }          
            if (rdbKullanici.Checked && rdbAkademisyen.Checked && !silmeIslem && !kullaniciGuncelleme)
            {
                NpgsqlCommand komutk = new NpgsqlCommand("select * from insert_akademisyen(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti);
                komutk.Parameters.AddWithValue("@p1", int.Parse(txt1.Text));
                komutk.Parameters.AddWithValue("@p2", txt2.Text);
                komutk.Parameters.AddWithValue("@p3", txt3.Text);
                komutk.Parameters.AddWithValue("@p4", txt4.Text);
                komutk.Parameters.AddWithValue("@p5", txt6.Text);
                komutk.Parameters.AddWithValue("@p6", txt7.Text);
                komutk.Parameters.AddWithValue("@p7", true);
                komutk.Parameters.AddWithValue("@p8", txt8.Text);
                komutk.Parameters.AddWithValue("@p9", int.Parse(txtDanismanNo.Text));
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komutk);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }           
            if (rdbKullanici.Checked && rdbOgrenci.Checked)
            {
                NpgsqlCommand komuto = new NpgsqlCommand("select * from insert_ogrenci(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti);
                komuto.Parameters.AddWithValue("@p1", int.Parse(txt1.Text));
                komuto.Parameters.AddWithValue("@p2", txt2.Text);
                komuto.Parameters.AddWithValue("@p3", txt3.Text);
                komuto.Parameters.AddWithValue("@p4", txt4.Text);
                komuto.Parameters.AddWithValue("@p5", txt6.Text);
                komuto.Parameters.AddWithValue("@p6", txt7.Text);
                komuto.Parameters.AddWithValue("@p7", true);
                komuto.Parameters.AddWithValue("@p8", txt8.Text);
                komuto.Parameters.AddWithValue("@p9", int.Parse(txtDanismanNo.Text));
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komuto);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if(rdbKullanici.Checked && rdbMisafir.Checked)
            {
                NpgsqlCommand komutm = new NpgsqlCommand("select * from insert_misafir(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);
                komutm.Parameters.AddWithValue("@p1", int.Parse(txt1.Text));
                komutm.Parameters.AddWithValue("@p2", txt2.Text);
                komutm.Parameters.AddWithValue("@p3", txt3.Text);
                komutm.Parameters.AddWithValue("@p4", txt4.Text);
                komutm.Parameters.AddWithValue("@p5", txt6.Text);
                komutm.Parameters.AddWithValue("@p6", txt7.Text);
                komutm.Parameters.AddWithValue("@p7", true);
                komutm.Parameters.AddWithValue("@p8", int.Parse(txtDanismanNo.Text));
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komutm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (rdbKitap.Checked && sayac)
            {
                NpgsqlCommand komutod = new NpgsqlCommand("select * from kitap_odunc(@p1,@p2,@p3)", baglanti);
                komutod.Parameters.AddWithValue("@p1", txt1.Text);
                komutod.Parameters.AddWithValue("@p2", int.Parse(txt2.Text));
                komutod.Parameters.AddWithValue("@p3", txt3.Text);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komutod);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                sayac = false;
            }
            if(rdbKitap.Checked && silmeIslem)
            {
                NpgsqlCommand komutsil = new NpgsqlCommand("select * from delete_kitap(@p1)", baglanti);
                komutsil.Parameters.AddWithValue("@p1", txt1.Text);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komutsil);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                silmeIslem = false;
            }
            if(rdbYayinevi.Checked && silmeIslem)
            {
                NpgsqlCommand komutsil = new NpgsqlCommand("select * from delete_yayinevi(@p1)", baglanti);
                komutsil.Parameters.AddWithValue("@p1", int.Parse(txt1.Text));
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komutsil);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                silmeIslem = false;
            }
            if(rdbYazar.Checked && silmeIslem)
            {
                NpgsqlCommand komutsil = new NpgsqlCommand("select * from delete_yazar(@p1)", baglanti);
                komutsil.Parameters.AddWithValue("@p1", int.Parse(txt1.Text));
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komutsil);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                silmeIslem = false;
            }
            if(rdbKullanici.Checked && silmeIslem)
            {
                NpgsqlCommand komutsil = new NpgsqlCommand("select * from delete_kullanici(@p1)", baglanti);
                komutsil.Parameters.AddWithValue("@p1", int.Parse(txt1.Text));
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komutsil);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                silmeIslem = false;
            }
            if (rdbKitap.Checked && kitapGuncelleme)
            {
                NpgsqlCommand komutguncelle = new NpgsqlCommand("select * from kitapupdateleme(@p1,@p2,@p3,@p4)", baglanti);
                komutguncelle.Parameters.AddWithValue("@p1", txt1.Text);
                komutguncelle.Parameters.AddWithValue("@p2", txt2.Text);
                komutguncelle.Parameters.AddWithValue("@p3", int.Parse(txt3.Text));
                komutguncelle.Parameters.AddWithValue("@p4", int.Parse(txt4.Text));
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komutguncelle);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                kitapGuncelleme = false;
            }
            if (rdbYazar.Checked && yazarGuncelleme)
            {
                NpgsqlCommand komutguncelle = new NpgsqlCommand("select * from yazarupdateleme(@p1,@p2,@p3,@p4)", baglanti);
                komutguncelle.Parameters.AddWithValue("@p1", int.Parse(txt1.Text));
                komutguncelle.Parameters.AddWithValue("@p2", txt2.Text);
                komutguncelle.Parameters.AddWithValue("@p3", txt3.Text);
                komutguncelle.Parameters.AddWithValue("@p4", txt4.Text);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komutguncelle);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                yazarGuncelleme = false;
            }
            if (rdbYayinevi.Checked && yayineviGuncelleme)
            {
                NpgsqlCommand komutguncelle = new NpgsqlCommand("select * from yayineviupdateleme(@p1,@p2,@p3,@p4)", baglanti);
                komutguncelle.Parameters.AddWithValue("@p1", int.Parse(txt1.Text));
                komutguncelle.Parameters.AddWithValue("@p2", txt2.Text);
                komutguncelle.Parameters.AddWithValue("@p3", txt3.Text);
                komutguncelle.Parameters.AddWithValue("@p4", txt4.Text);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komutguncelle);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                yazarGuncelleme = false;
            }
            if (rdbKullanici.Checked && kullaniciGuncelleme)
            {
                NpgsqlCommand komutguncelle = new NpgsqlCommand("select * from kullaniciupdateleme(@p1,@p2,@p3,@p4)", baglanti);
                komutguncelle.Parameters.AddWithValue("@p1", int.Parse(txt1.Text));
                komutguncelle.Parameters.AddWithValue("@p2", txt2.Text);
                komutguncelle.Parameters.AddWithValue("@p3", txt3.Text);
                komutguncelle.Parameters.AddWithValue("@p4", txt4.Text);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komutguncelle);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                kullaniciGuncelleme = false;
            }
            txtTemizle();
            baglanti.Close();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (rdbKitap.Checked)
            {
                NpgsqlCommand komut1 = new NpgsqlCommand("Select * from kitapbaglanti", baglanti);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut1);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (rdbYazar.Checked)
            {
                NpgsqlCommand komut2 = new NpgsqlCommand("Select * from yazarbaglanti", baglanti);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut2);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (rdbYayinevi.Checked)
            {
                NpgsqlCommand komut3 = new NpgsqlCommand("Select * from yayinevibaglanti", baglanti);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut3);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (rdbKullanici.Checked)
            {

                NpgsqlCommand komut4 = new NpgsqlCommand("Select * from kullaniciakademisyen", baglanti);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut4);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            txtTemizle();
            baglanti.Close();
        }

        private void rdbAkademisyen_CheckedChanged(object sender, EventArgs e)
        {
            tumVerileriGoster();
            gbKullanici.Show();
            label11.Text = "Fakülte:";
            label11.Show();
            txt8.Show();
        }

        private void rdbOgrenci_CheckedChanged(object sender, EventArgs e)
        {
            tumVerileriGoster();
            gbKullanici.Show();
            label11.Text = "Bölüm:";
            label11.Show();
            txt8.Show();

        }

        private void rdbMisafir_CheckedChanged(object sender, EventArgs e)
        {
            tumVerileriGoster();
            gbKullanici.Show();
            label11.Hide();
            txt8.Hide();
        }

        private void btnKiralama_Click(object sender, EventArgs e)
        {
            btnara.Hide();

            if (rdbKitap.Checked)
            {
                tumVerileriGoster();
                ekBilgiGizle();
                label5.Hide();
                label6.Hide();
                txt4.Hide();
                txt5.Hide();
                label3.Text = "Kullanici Id:";
                label4.Text = "Alınan Tarih:";
                sayac = true;

            }

            
        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
            btnara.Hide();
            if (rdbKitap.Checked)
            {
                tumVerileriGoster();
                ekBilgiGizle();
                label5.Hide();
                label6.Hide();
                label3.Hide();
                label4.Hide();
                txt2.Hide();
                txt3.Hide();
                txt4.Hide();
                txt5.Hide();
                label2.Text = "ISBN:";

                silmeIslem = true;
            }
            if (rdbYayinevi.Checked)
            {
                tumVerileriGoster();
                ekBilgiGizle();
                label5.Hide();
                label6.Hide();
                label3.Hide();
                label4.Hide();
                txt2.Hide();
                txt3.Hide();
                txt4.Hide();
                txt5.Hide();
                label2.Text = "Yayınevi Kodu:";
                silmeIslem = true;

            }
            if (rdbYazar.Checked)
            {
                tumVerileriGoster();
                ekBilgiGizle();
                label5.Hide();
                label6.Hide();
                label3.Hide();
                label4.Hide();
                txt2.Hide();
                txt3.Hide();
                txt4.Hide();
                txt5.Hide();
                label2.Text = "Yazar No:";
                silmeIslem = true;

            }
            if (rdbKullanici.Checked)
            {
                tumVerileriGoster();
                ekBilgiGizle();
                label5.Hide();
                label6.Hide();
                label3.Hide();
                label4.Hide();
                txt2.Hide();
                txt3.Hide();
                txt4.Hide();
                txt5.Hide();
                label2.Text = "Kullanıcı No:";
                silmeIslem = true;
            }
        }
        private void txtTemizle()
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
            txt5.Clear();
            txt6.Clear();
            txt7.Clear();
            txt8.Clear();
        }

        private void btnGuncelleme_Click(object sender, EventArgs e)
        {
            btnara.Hide();
            if (rdbKitap.Checked)
            {
                tumVerileriGizle();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                txt1.Show();
                txt2.Show();
                txt3.Show();
                txt4.Show();
                label4.Text = "Bölüm Kodu:";
                label5.Text = "Fiyat:";
                kitapGuncelleme = true;
            }
            if (rdbYazar.Checked)
            {
                tumVerileriGizle();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                txt1.Show();
                txt2.Show();
                txt3.Show();
                txt4.Show();
                label2.Text = "Yazar No:";
                label3.Text = "Yazar Adı:";
                label4.Text = "Yazar Soyadı:";
                label5.Text = "Yazar Mail:";
                yazarGuncelleme = true;
            }
            if (rdbYayinevi.Checked)
            {

                tumVerileriGizle();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                txt1.Show();
                txt2.Show();
                txt3.Show();
                txt4.Show();
                label2.Text = "Yayınevi No:";
                label3.Text = "Yayınevi Adı:";
                label4.Text = "Yayınevi Tel:";
                label5.Text = "Yayınevi Mail:";
                yayineviGuncelleme = true;
            }
            if (rdbKullanici.Checked)
            {

                tumVerileriGizle();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                txt1.Show();
                txt2.Show();
                txt3.Show();
                txt4.Show();
                label2.Text = "Kullanici Id:";
                label3.Text = "Kullanici Adı:";
                label4.Text = "Kullanici Soyadı:";
                label5.Text = "Kullanici Tel:";
                kullaniciGuncelleme = true;
            }
           
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            btnara.Show();
            if (rdbKitap.Checked)
            {
                tumVerileriGizle();
                label2.Show();
                txt1.Show();
                label2.Text = "ISBN:";
            }
            if (rdbYayinevi.Checked)
            {
                tumVerileriGizle();
                label2.Show();
                txt1.Show();
                label2.Text = "Yayınevi No:";
            }
            if (rdbYazar.Checked)
            {
                tumVerileriGizle();
                label2.Show();
                txt1.Show();
                label2.Text = "Yazar No:";
            }
            if (rdbKullanici.Checked)
            {
                tumVerileriGizle();
                label2.Show();
                txt1.Show();
                label2.Text = "Kullanıcı Id:";
            }
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (rdbKitap.Checked)
            {
                NpgsqlCommand komutarama = new NpgsqlCommand("select * from kitaparama(@p1)", baglanti);
                komutarama.Parameters.AddWithValue("@p1", (txt1.Text));
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komutarama);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
            if (rdbYazar.Checked)
            {
                NpgsqlCommand komutarama = new NpgsqlCommand("select * from yazararama(@p1)", baglanti);
                komutarama.Parameters.AddWithValue("@p1",int.Parse((txt1.Text)));
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komutarama);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
            if (rdbYayinevi.Checked)
            {

                NpgsqlCommand komutarama = new NpgsqlCommand("select * from yayineviarama(@p1)", baglanti);
                komutarama.Parameters.AddWithValue("@p1", int.Parse((txt1.Text)));
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komutarama);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (rdbKullanici.Checked)
            {
                NpgsqlCommand komutarama = new NpgsqlCommand("select * from kullaniciarama(@p1)", baglanti);
                komutarama.Parameters.AddWithValue("@p1", int.Parse((txt1.Text)));
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komutarama);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            txt1.Clear();
            baglanti.Close();

        }
    }
}
