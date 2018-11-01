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
    public partial class FrmPersonelGuncelle : Form
    {
        public FrmPersonelGuncelle()
        {
            InitializeComponent();
        }
        sqlbaglantim bgl = new sqlbaglantim();

        private void FrmPersonelGuncelle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtkayitDataSet11.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter3.Fill(this.yurtkayitDataSet11.Personel);
           
          
         

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Insert into Personel (PersonelAdSoyad,PersonelGorevi) values (@p1,@p2)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtPerAd.Text);
                komut.Parameters.AddWithValue("@p2", txtPerGorev.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                this.personelTableAdapter3.Fill(this.yurtkayitDataSet11.Personel);
                MessageBox.Show("Sisteme başarıyla eklendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde hata oluştu. Lütfen daha sonra tekrar deneyiniz...");

            }
            Sıfırla();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            txtPerId.Text = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            txtPerAd.Text = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            txtPerGorev.Text = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Delete from Personel where Personleid=@k1", bgl.baglanti());
                komut.Parameters.AddWithValue("@k1", txtPerId.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                this.personelTableAdapter3.Fill(this.yurtkayitDataSet11.Personel);
                MessageBox.Show("Silme işlemi başarıyla tamamlandı...");

            }
            catch (Exception)
            {

                MessageBox.Show("Sistemde sorun oluştu .Lütfen silmek istediğiniz ismi tekrardan seçiniz...");
            }
            Sıfırla();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Update Personel set PersonelAdSoyad = @u1 , PersonelGorevi = @u2 where Personleid=@u3", bgl.baglanti());
                komut.Parameters.AddWithValue("@u1", txtPerAd.Text);
                komut.Parameters.AddWithValue("@u2", txtPerGorev.Text);
                komut.Parameters.AddWithValue("@u3", txtPerId.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                this.personelTableAdapter3.Fill(this.yurtkayitDataSet11.Personel);
                MessageBox.Show("Güncelleme işlemi başarıyla tamamlandı.");

            }
            catch (Exception)
            {

                MessageBox.Show("Sistemde sorun oluştu .Lütfen bilgilerinizi kontrol edip daha sonra tekrar deneyiniz...");
            }
            Sıfırla();


        }
        private void Sıfırla()
        {
            txtPerAd.Clear();
            txtPerGorev.Clear();
            txtPerId.Clear();
        }
    }
}
