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
    public partial class FrmGelirIstatislik : Form
    {
        public FrmGelirIstatislik()
        {
            InitializeComponent();
        }
        sqlbaglantim bgl = new sqlbaglantim();
      
        private void FrmGelirIstatislik_Load(object sender, EventArgs e)
        {
            /*          int x;
                        SqlCommand komut = new SqlCommand("Select OdemeMiktar from Kasa", bgl.baglanti());
                        SqlDataReader oku = komut.ExecuteReader();

                        while(oku.Read())
                        {
                            x += Convert.ToInt32(oku[0]);
                        }
                        lblkasapara.Text = x.ToString() + " TL";
                        bgl.baglanti().Close();
*/



            // ODEMEMIKTARINI TOPLATTIK
            SqlCommand komut = new SqlCommand("Select Sum(OdemeMiktar) from Kasa", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();

            while(oku.Read())
            {
                lblkasapara.Text = oku[0].ToString();
            }
           





            //TEKRARSIZ ODEMELERIN GELMESINI ISTIYORUZ..(MART 2017Ler bı tane olarak yazsın ) =DISTINCT
            SqlCommand komut2 = new SqlCommand("select distinct (OdemeAy) from Kasa", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                cmbAy.Items.Add(oku2[0]);
            }

            bgl.baglanti().Close();



            //Grafiklere veritabanından verı cekme Odemeay ile odememıktarı toplamını odemeaya gore grupla
            SqlCommand komut5 = new SqlCommand("select OdemeAy, Sum(OdemeMiktar) from Kasa group by OdemeAy", bgl.baglanti());
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(oku5[0], oku5[1]);
            }
            bgl.baglanti().Close();

        }

        private void cmbAy_SelectedIndexChanged(object sender, EventArgs e)
        {// comboBoxa seçilen ayın toplam parası label4 e yazsın.
            SqlCommand komut3 = new SqlCommand("Select Sum(OdemeMiktar) from Kasa where OdemeAy= @p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbAy.Text);
            SqlDataReader oku3 = komut3.ExecuteReader();
            if(oku3.Read())
            {
                label4.Text = oku3[0].ToString() + " TL";
            }
            bgl.baglanti().Close();



           
        }
    }
    }
