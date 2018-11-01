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
    public partial class FrmGider : Form
    {
        public FrmGider()
        {
            InitializeComponent();
        }
        sqlbaglantim bgl = new sqlbaglantim();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand komut = new SqlCommand(" Insert into Giderler (Elektrik,Su,Dogalgaz,internet,Gida,Personel,Diger) values (@g1,@g2,@g3,@g4,@g5,@g6,@g7)", bgl.baglanti());
                komut.Parameters.AddWithValue("@g1", textBox1.Text);
                komut.Parameters.AddWithValue("@g2", textBox2.Text);
                komut.Parameters.AddWithValue("@g3", textBox3.Text);
                komut.Parameters.AddWithValue("@g4", textBox4.Text);
                komut.Parameters.AddWithValue("@g5", textBox5.Text);
                komut.Parameters.AddWithValue("@g6", textBox6.Text);
                komut.Parameters.AddWithValue("@g7", textBox7.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Giderler ilgili bölüme başarıyla eklendi...");

            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu lütfen daha sonra tekrar deneyiniz...");
              
            }

        }
    }
}
