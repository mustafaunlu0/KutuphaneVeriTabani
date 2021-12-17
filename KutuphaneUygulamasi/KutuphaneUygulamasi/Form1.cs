namespace KutuphaneUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string sifre = txtKullaniciSifre.Text;
            if(sifre.Equals("123") && rdbYonetici.Checked)
            {
                FrmYonetici frmYonetici = new FrmYonetici();
                frmYonetici.Show();
                this.Hide();

            }
            else if(sifre.Equals("321") && rdbDanisman.Checked)
            {
                FrmDanisman frmDanisman = new FrmDanisman();
                frmDanisman.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalý Giriþ!");
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }

}