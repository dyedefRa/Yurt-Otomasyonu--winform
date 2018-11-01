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
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }
        public string id;
        sqlbaglantim bgl = new sqlbaglantim();

        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            label1.Text = id;
            txtID.Text = label1.Text;
            try
            {
                SqlCommand komut = new SqlCommand("Select * from Ogrenci where Ogrid = '" + Convert.ToInt32(label1.Text) + "'", bgl.baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    txtOgrAd.Text = oku[1].ToString();
                    txtOgrSoyad.Text = oku[2].ToString();
                    mskOgrTc.Text = oku[3].ToString();
                    mskOgrTel.Text = oku[4].ToString();
                    mskOgrDogum.Text = oku[5].ToString();
                    cmbOgrBolum.Text = oku[6].ToString();
                    txtOgrMail.Text = oku[7].ToString();
                    cmbOgrOdaNo.Text = oku[8].ToString();
                    txtVeliAdSoyad.Text = oku[9].ToString();
                    mskVelitel.Text = oku[10].ToString();
                    rchAdres.Text = oku[11].ToString();
                    
                }
               


            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu.Lütfen daha sonra tekrar deneyiniz...");
            }


            // Bolumlerı comboboxa gectık
            SqlCommand komut2 = new SqlCommand("Select * from Bolumler", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();

            while(oku2.Read())
            {
                cmbOgrBolum.Items.Add(oku2[1].ToString());
            }

            //odaları combo boxa cektık
            SqlCommand komut3 = new SqlCommand("Select * from Odalar", bgl.baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();

            while(oku3.Read())
            {

                cmbOgrOdaNo.Items.Add(oku3[1]) ;
            }


            bgl.baglanti().Close();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Update Ogrenci set OgrAd= '" + txtOgrAd.Text + "' ,OgrSoyad ='" + txtOgrSoyad.Text + "' , OgrTC ='" + mskOgrTc.Text.ToString() + "' , OgrTelefon='" + mskOgrTel.Text.ToString() + "',OgrDogum ='" + mskOgrDogum.Text.ToString() + "',OgrBolum =  '" + cmbOgrBolum.Text + "',OgrMail = '" + txtOgrMail.Text.ToString() + "',OgrOdaNo = '" + cmbOgrOdaNo.Text + "',OgrVeliAdSoyad = '" + txtVeliAdSoyad.Text + "' ,OgrVeliTelefon = '" + mskVelitel.Text + "',OgrVeliAdres = '" + rchAdres.Text + "' where Ogrid = " + Convert.ToInt32(label1.Text) + " ", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme başarıyla tamamlandı...");
                this.Hide();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu...Lütfen daha sonra tekrar deneyiniz...");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Delete from Ogrenci where Ogrid = @s1", bgl.baglanti());
                komut.Parameters.AddWithValue("@s1", txtID.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

               
            }
            catch (Exception)
            {

                MessageBox.Show("Sistemde hata oluştu.Lütfen daha sonra tekrar deneyiniz...");
            }

            //ODA KONT AZALTMA
            SqlCommand komut2 = new SqlCommand("Update Odalar set OdaAktif=OdaAktif-1 where OdaNo =@v1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@v1", cmbOgrOdaNo.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıtlardan başarıyla silindi...");
            this.Hide();
        }
    }
}
