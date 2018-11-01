using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Yurt_OTOMASYONU
{
    public partial class FrmGiderGuncelle : Form
    {
        public FrmGiderGuncelle()
        {
            InitializeComponent();
        }

        sqlbaglantim bgl = new sqlbaglantim();

        public string elektrik, su, dogalgaz, internet, personel, diger, gida, id;

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGiderlerListesi fgl = new FrmGiderlerListesi();
            fgl.Show();
            this.Hide();
        }
        DialogResult dr = new DialogResult();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Update Giderler set Elektrik=@g1,Su=@g2,Dogalgaz=@g3,internet=@g4,Gida=@g5,Personel=@g6,Diger=@g7 where Odemeid= '" + textBox8.Text.ToString()+"'", bgl.baglanti());
                komut.Parameters.AddWithValue("@g1", textBox1.Text);
                komut.Parameters.AddWithValue("@g2", textBox2.Text);
                komut.Parameters.AddWithValue("@g3", textBox3.Text);
                komut.Parameters.AddWithValue("@g4", textBox4.Text);
                komut.Parameters.AddWithValue("@g5", textBox5.Text);
                komut.Parameters.AddWithValue("@g6", textBox6.Text);
                komut.Parameters.AddWithValue("@g7", textBox7.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                dr = MessageBox.Show("Güncelleme başarıyla tamamlandı...Bu sayfadan çıkmak ister misiniz?", "Güncelleme işlemi gerçekleştirildi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr==DialogResult.Yes)
                {
                    this.Hide();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu lütfen daha sonra tekrar deneyiniz...");
            }

        }

        private void FrmGiderGuncelle_Load(object sender, EventArgs e)
        {
            textBox8.Text = id;
            textBox1.Text = elektrik;
            textBox2.Text = su;
            textBox3.Text = dogalgaz;
            textBox4.Text = internet;
            textBox5.Text = gida;
            textBox6.Text = personel;
            textBox7.Text = diger;
        }
    }
}
