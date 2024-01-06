using projeSınıf;

namespace calısan
{
    public partial class calis : Form
    {
        public calis()
        {
            InitializeComponent();
            genelBilgi entity = new genelBilgi();
            lbl_adsoyad.Text = entity.ad + " " + entity.soyad;
            lbl_maas.Text = entity.maas.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
            btn_izin.Visible = true;
        }
    }
}