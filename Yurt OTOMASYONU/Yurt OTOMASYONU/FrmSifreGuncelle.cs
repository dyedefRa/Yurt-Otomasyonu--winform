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
    public partial class FrmSifreGuncelle : Form
    {
        public FrmSifreGuncelle()
        {
            InitializeComponent();
        }
        sqlbaglantim bgl = new sqlbaglantim();

        private void FrmSifreGuncelle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtkayitDataSet7.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter2.Fill(this.yurtkayitDataSet7.Admin);
           

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKADI.Text != "" && txtSifre.Text != "")
            {
                try
                {
                    SqlCommand komut = new SqlCommand("Insert into Admin (YoneticiAd,YoneticiSifre) values (@y1,@y2)", bgl.baglanti());
                    komut.Parameters.AddWithValue("@y1", txtKADI.Text);
                    komut.Parameters.AddWithValue("@y2", txtSifre.Text);
                    komut.ExecuteReader();
                    bgl.baglanti().Close();
                    this.adminTableAdapter2.Fill(this.yurtkayitDataSet7.Admin);
                    MessageBox.Show("Yeni yönetici kimliğiniz , sisteme başarıyla eklendi. Kullanıcı adınız : " + txtKADI.Text + " şifreniz : " + txtSifre.Text + "");
                }
                catch (Exception)
                {

                    MessageBox.Show("Sistemde bir sorun oluştu. Lütfen bilgilerinizi tekrar kontrol ediniz...");
                }
            }
            else
            {
                MessageBox.Show("Lütfen ilgili alanları doldurunuz..");
            }
            txtKADI.Clear();
            txtSifre.Clear();
            txtYoneticiID.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(txtKADI.Text != "" &&  txtSifre.Text != "")
            {
                if(groupBox1.Visible == true)
                {
                    groupBox1.Visible = false;
                }
               else 
                {
                    groupBox1.Visible = true;
                }
            }
           else
            {
                MessageBox.Show("Lütfen şifresini güncellemek istediğiniz yönetici kimliğini seçiniz...");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if(txtyeniSifre.Text==txtyenisifre2.Text )
            {
                if(txtyeniSifre.TextLength>=6  && txtyeniSifre.TextLength <= 10)
                {
                    try
                    {

                        SqlCommand komut = new SqlCommand("Update Admin set  YoneticiSifre = @u2 where Yoneticiid = @u3", bgl.baglanti());
                        komut.Parameters.AddWithValue("@u2", txtyeniSifre.Text);
                        komut.Parameters.AddWithValue("@u3", txtYoneticiID.Text);
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        this.adminTableAdapter2.Fill(this.yurtkayitDataSet7.Admin);
                        MessageBox.Show("Yönetici ID = " + txtYoneticiID.Text + " olan yöneticinin şifresi = " + txtyeniSifre.Text + " olarak değiştirildi...");


                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Sistemde bir hata oluştu. Lütfen daha sonra tekrar deneyiniz...");
                    }
                }

                else
                {
                    MessageBox.Show("Şifreniz 6 ile 10 karakter arasında olmalıdır...");
                }



            }
            else
            {
                MessageBox.Show("Yeni şifre bölümünde uyuşmazlık var.Lütfen yeni şifreleri tekrardan yazınız...");
            }
            groupBox1.Visible = false;
            txtKADI.Clear();
            txtSifre.Clear();
            txtYoneticiID.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilalan = dataGridView1.SelectedCells[0].RowIndex;
            txtYoneticiID.Text = dataGridView1.Rows[secilalan].Cells[0].Value.ToString();
            txtKADI.Text = dataGridView1.Rows[secilalan].Cells[1].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilalan].Cells[2].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (txtYoneticiID.Text =="")
            {
                MessageBox.Show("Lütfen silmek istediğiniz yönetici kimliğini seçiniz... ");

            }
            else
            {
                try
                {
                    SqlCommand komut = new SqlCommand(" Delete  from Admin where Yoneticiid = @s1 ", bgl.baglanti());
                    komut.Parameters.AddWithValue("@s1", txtYoneticiID.Text);

                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show(txtKADI.Text + " adlı yönetici kimliği sistemden başarılı bir şekilde çıkartılmıştır.");

                    this.adminTableAdapter2.Fill(this.yurtkayitDataSet7.Admin);

                }
                catch (Exception)
                {

                    MessageBox.Show("Sistemde bir sorun oluştu. Lütfen silmek istediğiniz yönetici kiliğini seçiniz...");
                }
                txtKADI.Clear();
                txtSifre.Clear();
                txtYoneticiID.Clear();
            }
        }
    }
}
