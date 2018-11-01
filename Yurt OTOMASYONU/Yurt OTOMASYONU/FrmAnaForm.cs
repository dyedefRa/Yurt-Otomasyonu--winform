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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void radio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"http://media.netd.com.tr/S2/HLS_LIVE/radyodreamturk/index.m3u8";
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtkayitDataSet1.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.yurtkayitDataSet1.Ogrenci);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();

        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MsPaint");
        }

        private void radio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"http://sc.powergroup.com.tr:80/PowerTurkAkustik/mpeg/128/home";
        }

        private void radio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"http://kralpopwmp.radyotvonline.com:80";
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrKayit ogrkayit = new FrmOgrKayit();
            ogrkayit.Show();
        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrListe ogrliste = new FrmOgrListe();
            ogrliste.Show();
        }

        private void bölümEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler bg = new FrmBolumler();
            bg.Show();
        }

        private void bölümDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler bg = new FrmBolumler();
            bg.Show();
        }

        private void ödemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOdemeler od = new FrmOdemeler();
            od.Show();
        }

        private void giderListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderlerListesi gr = new FrmGiderlerListesi();
            gr.Show();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGider fm = new FrmGider();
            fm.Show();
        }

        private void gelirİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGelirIstatislik fg = new FrmGelirIstatislik();
            fg.Show();
        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSifreGuncelle fm = new FrmSifreGuncelle();
            fm.Show();
        }

        private void personelDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonelGuncelle fg = new FrmPersonelGuncelle();
            fg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ogrenciTableAdapter.Fill(this.yurtkayitDataSet1.Ogrenci);
        }

        private void notEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNotekle fr = new FrmNotekle();
            fr.Show();
        }

        private void öğrenciRaporlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrenciRapor sa = new FrmOgrenciRapor();
            sa.Show();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yazılım öğrenmeye yeni başlayan bir kişinin ilk otomasyon projesidir...Yaklaşık iki gün sürdü.[05:30 02.11.2017](ABÖ); ");
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
