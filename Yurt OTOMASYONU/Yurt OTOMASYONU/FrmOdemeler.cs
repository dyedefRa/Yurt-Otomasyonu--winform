using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace Yurt_OTOMASYONU
{
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }

        sqlbaglantim bgl = new sqlbaglantim();

        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtkayitDataSet2.Borclar' table. You can move, or remove it, as needed.
            this.borclarTableAdapter.Fill(this.yurtkayitDataSet2.Borclar);
            for (int i = 2017;i <=2050;i++)
            {
                comboBox2.Items.Add(i);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            lblID.Text = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            lblAd.Text = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            lblSoyad.Text = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            lbKalanBorç.Text = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();


        }
        string arananögrenciid;
        private void button2_Click(object sender, EventArgs e)
        {
            arananögrenciid = Interaction.InputBox("Lütfen aradığınız öğrencinin ID numarasını giriniz..", "Öğrenci Arama(Sayı Giriniz)", "", Screen.PrimaryScreen.Bounds.Width / 2 - 50, Screen.PrimaryScreen.Bounds.Height / 2 - 50);

            lblID.Text = arananögrenciid.ToString();



            try
            {
                SqlCommand komut = new SqlCommand("Select * from Borclar where Ogrid = '" + lblID.Text + "'", bgl.baglanti());


                SqlDataReader oku = komut.ExecuteReader();

                if (oku.Read())
                {
                    lblID.Text = oku[0].ToString();
                    lblAd.Text = oku[1].ToString();
                    lblSoyad.Text = oku[2].ToString();
                    lbKalanBorç.Text = oku[3].ToString();
                }

                else
                {
                    lblID.Text = "---";
                    lblAd.Text = "---";
                    lblSoyad.Text = "---";
                    lbKalanBorç.Text = "---";
                    MessageBox.Show("ID'si :  " + arananögrenciid.ToString() + " olan bir öğrenci sistemde bulunmamaktadır...");
                }
                bgl.baglanti().Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu. Lütfen sonra tekrar deneyiniz...");
                lblID.Text = "---";
            }
       
        }
        int x;
        DialogResult dr = new DialogResult();

        private void button1_Click(object sender, EventArgs e)
        { 

            if (lblAd.Text != "---")
            {


                if (comboBox1.Text != ""  && comboBox2.Text != "")
                {

                    dr = MessageBox.Show("ID Numarası : " + lblID.Text + " olan " + lblAd.Text.ToUpper() + "  " + lblSoyad.Text.ToUpper() + " adlı kişiden  "
                            + textBox2.Text.ToString() + " TL  ödeme alınacak. Onaylıyor musunuz ?", "Önemli Uyarı!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        { // girilen degerle olan degerı cıkartıyoruz yenı degerı labellara yazıyoruz. labeldan cektım.
                            x = Convert.ToInt32(lbKalanBorç.Text) - Convert.ToInt32(textBox2.Text);
                            SqlCommand komut = new SqlCommand("Update Borclar set OgrKalanBorc ='" + x + "' where Ogrid=" + Convert.ToInt32(lblID.Text) + "", bgl.baglanti());
                            komut.ExecuteNonQuery();
                            bgl.baglanti().Close();
                            this.borclarTableAdapter.Fill(this.yurtkayitDataSet2.Borclar);

                            MessageBox.Show("ID Numarası : " + lblID.Text + " olan " + lblAd.Text.ToUpper() + "  " +
                                  lblSoyad.Text.ToUpper() + " adlı kişiden  " + textBox2.Text.ToString() + " TL  ödeme alındı.");
                            lbKalanBorç.Text = x.ToString(); // burada yazıyorum.

                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Hata oluştu..Lütfen bilgileri kontrol edip tekrar deneyiniz(Alınan tutarda sorun olabilir)...");
                        }
                    }

                    SqlCommand komut2 = new SqlCommand("Insert into Kasa (OdemeAy,OdemeMiktar) values (@o1,@o2)", bgl.baglanti());
                    komut2.Parameters.AddWithValue("@o1", comboBox1.Text + " " + comboBox2.Text);
                    komut2.Parameters.AddWithValue("@o2", textBox2.Text);
                    komut2.ExecuteNonQuery();
                    bgl.baglanti().Close();
                }
                else
                {
                    MessageBox.Show("Lütfen kaydedilecek tarihi ve borç bölümünü eksiksiz doldurunuz ");

                }
            }
            else
            {
                MessageBox.Show("Lütfen öğrenci seçiniz");
            }

            

               



            }
        }
    }

