using cal�san;
using muhasebe;
using projeS�n�f;

namespace login
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
           
        kullanici kullanici1 = new kullanici();
        private void btn_giris_Click(object sender, EventArgs e)
        {

            calis calisan1 = new calis();
            hesap muhasebe1 = new hesap();
            if (txt_username.Text == kullanici1.kullaniciadi && txt_pass.Text == kullanici1.sifre)
            {
                if(kullanici1.yetki == "muhasebe")
                {
                    this.Hide();
                    muhasebe1.Show();
                }
                if(kullanici1.yetki == "calisan")
                {
                    this.Hide();
                    calisan1.Show();
                }
            }
            else
            {
                MessageBox.Show("Kullanc� ad� veya �ifre hatal�");
            }
        }


    }
}