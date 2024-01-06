using projeSýnýf;

namespace muhasebe
{
    public partial class hesap : Form
    {
        public hesap()
        {
            InitializeComponent();
        }
        muhasebeci entity = new muhasebeci();
        private void btn_karhesap_Click(object sender, EventArgs e)
        {
            int kar = int.Parse(txt_gelir.Text) - int.Parse(txt_gider.Text);
            label4.Text = kar.ToString();

        }

        private void btn_aylýk_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
        }

        private void btn_bilgi_Click(object sender, EventArgs e)
        {
            lbl_adsoyad.Text = entity.ad +" "+ entity.soyad;
            lbl_yas.Text = entity.yas;
            lbl_tel.Text = entity.tel;
            txt_maas.Text = entity.maas.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(entity);
        }
    }
}