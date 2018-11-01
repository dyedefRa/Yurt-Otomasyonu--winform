using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yurt_OTOMASYONU
{
    public partial class FrmGiderlerListesi : Form
    {
        public FrmGiderlerListesi()
        {
            InitializeComponent();
        }

        private void FrmGiderlerListesi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtkayitDataSet4.Giderler' table. You can move, or remove it, as needed.
            this.giderlerTableAdapter.Fill(this.yurtkayitDataSet4.Giderler);

            button1.Focus();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            FrmGiderGuncelle abow = new FrmGiderGuncelle();
            abow.id = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            abow.elektrik = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            abow.su = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
                abow.dogalgaz= dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            abow.internet= dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
            abow.gida= dataGridView1.Rows[secilialan].Cells[5].Value.ToString();
            abow.personel= dataGridView1.Rows[secilialan].Cells[6].Value.ToString();
            abow.diger= dataGridView1.Rows[secilialan].Cells[7].Value.ToString();
            abow.Show();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.giderlerTableAdapter.Fill(this.yurtkayitDataSet4.Giderler);
        }
    }
}
