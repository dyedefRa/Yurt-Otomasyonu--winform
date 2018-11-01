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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }
        sqlbaglantim bgl = new sqlbaglantim();

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtkayitDataSet.Bolumler' table. You can move, or remove it, as needed.
            this.bolumlerTableAdapter.Fill(this.yurtkayitDataSet.Bolumler);

            /* 
             baglan.Open();

             SqlDataAdapter da = new SqlDataAdapter("select * from Bolumler", baglan);
             DataSet ds = new DataSet();
             da.Fill(ds);

             dataGridView1.DataSource = ds.Tables[0];*/

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            try
            {
               
                SqlCommand komut = new SqlCommand("Insert into Bolumler (BolumAd) values (@p2)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p2", textBox2.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show(textBox2.Text + "  bölümü başarıyla eklendi..");

                this.bolumlerTableAdapter.Fill(this.yurtkayitDataSet.Bolumler);

            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu. Lütfen tekrar deneyiniz..");
            }
            Clearla();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilialan].Cells[0].Value.ToString().Trim();
            textBox2.Text = dataGridView1.Rows[secilialan].Cells[1].Value.ToString().Trim();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand komut = new SqlCommand("Delete from Bolumler where bolumid = '" + textBox1.Text.ToString() + "'", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show(textBox2.Text + "  bölümü başarıyla silindi...");
                this.bolumlerTableAdapter.Fill(this.yurtkayitDataSet.Bolumler);

            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu...Lütfen sonra tekrar deneyin.");
            }
            Clearla();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
             
                SqlCommand komut = new SqlCommand("Update  Bolumler set BolumAd = @p1 where Bolumid = @p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", textBox2.Text);
                komut.Parameters.AddWithValue("@p2", textBox1.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme başarılı bir şekilde yapıldı..");

                this.bolumlerTableAdapter.Fill(this.yurtkayitDataSet.Bolumler);


            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu.. Lütfen sonra tekrar deneyin.");
            }
            Clearla();
        }

        public void Clearla()
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
