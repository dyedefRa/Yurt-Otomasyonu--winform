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
    public partial class FrmOgrKayit : Form
    {
        public FrmOgrKayit()
        {
            InitializeComponent();
        }
        sqlbaglantim bgl = new sqlbaglantim();
        

        private void FrmOgrKayit_Load(object sender, EventArgs e)
        {   //Bolumlerı dırek sqlden cektık
         
            SqlCommand komut = new SqlCommand("Select BolumAd from Bolumler", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();

            while(oku.Read())
            {
                cmbOgrBolum.Items.Add(oku[0]);
            }
            bgl.baglanti().Close();


            //Boş odaları cekıyorum
            
            SqlCommand komut2 = new SqlCommand("select Odano from odalar where OdaKapasite != OdaAktif", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while(oku2.Read())
            {
                cmbOgrOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                SqlCommand komutkaydet = new SqlCommand("Insert into Ogrenci (OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres)values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@p1", txtOgrAd.Text);
                komutkaydet.Parameters.AddWithValue("@p2", txtOgrSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p3", mskOgrTc.Text);
                komutkaydet.Parameters.AddWithValue("@p4", mskOgrTel.Text);
                komutkaydet.Parameters.AddWithValue("@p5", mskOgrDogum.Text);
                komutkaydet.Parameters.AddWithValue("@p6", cmbOgrBolum.Text);
                komutkaydet.Parameters.AddWithValue("@p7", txtOgrMail.Text);
                komutkaydet.Parameters.AddWithValue("@p8", cmbOgrOdaNo.Text);
                komutkaydet.Parameters.AddWithValue("@p9", txtVeliAdSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p10", mskVelitel.Text);
                komutkaydet.Parameters.AddWithValue("@p11", rchAdres.Text);
               

                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt başarıyla eklendi...");



                // Label12.TExtine İd cekmek(borclara ekleyebılmek ıcın asagıdakı...)))
                SqlCommand komut = new SqlCommand("Select Ogrid from Ogrenci", bgl.baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    label12.Text = oku[0].ToString();
                }
                bgl.baglanti().Close();





                // Ögrenci kaydoldugunda butona tıkladıgında Borclar tablona eklensın 
                SqlCommand kaydetkomutu2 = new SqlCommand("Insert into Borclar (Ogrid,OgrAd,OgrSoyad) values (@b1,@b2,@b3)", bgl.baglanti());
                kaydetkomutu2.Parameters.AddWithValue("@b1", label12.Text);
                kaydetkomutu2.Parameters.AddWithValue("@b2", txtOgrAd.Text);
                kaydetkomutu2.Parameters.AddWithValue("@b3", txtOgrSoyad.Text);
                kaydetkomutu2.ExecuteNonQuery();
                bgl.baglanti().Close();
               
                //OGRENCI ODA KONT ARTTIRMA

                SqlCommand komutoda = new SqlCommand("Update Odalar set OdaAktif= OdaAktif+1 where OdaNo=@o1", bgl.baglanti());
                komutoda.Parameters.AddWithValue("@o1", cmbOgrOdaNo.Text);
                komutoda.ExecuteReader();
                bgl.baglanti().Close();
                this.Hide();
                
            }
            catch (Exception)
            {

                MessageBox.Show("Kayıt işlemin sorun oluştu...Lütfen yeniden deneyiniz");
            }


            



        } 
    }
}
