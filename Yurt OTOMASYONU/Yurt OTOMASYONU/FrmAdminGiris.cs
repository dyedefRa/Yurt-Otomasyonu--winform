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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        sqlbaglantim bgl = new sqlbaglantim();
        private void button1_Click(object sender, EventArgs e)
        {



            SqlCommand komut = new SqlCommand("Select * from Admin where YoneticiAd =@p1 And YoneticiSifre=@p2 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                FrmAnaForm sa = new FrmAnaForm();
                sa.Show();
                this.Hide();
                MessageBox.Show("Giriş başarılı..Sisteme hoşgeldiniz...");
              
            }

            else
            {
                MessageBox.Show("Giriş başarısız.!! Lütfen bilgilerinizi tekrar kontrol ediniz...");
            }
            bgl.baglanti().Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}
