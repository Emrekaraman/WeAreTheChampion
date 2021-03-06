using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampion.Moldels;

namespace WeAreTheChampion
{
    public partial class Form1 : Form
    {
        WeAreTheChampionsContext db = new WeAreTheChampionsContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void tsmiTakimlar_Click(object sender, EventArgs e)
        {
            var frmTakımlar = new Takımlar(db);
            frmTakımlar.ShowDialog();
        }

        private void tsmiRenkler_Click(object sender, EventArgs e)
        {
            var frmColor = new Color(db);
            frmColor.ShowDialog();
        }

        private void tsmiOyuncular_Click(object sender, EventArgs e)
        {
            var frmOyuncular = new Player(db);
            frmOyuncular.ShowDialog();
        }

        private void btnYeniKarsilasma_Click(object sender, EventArgs e)
        {
            var frmKarsilastirma = new Karşılaştırma(db);
            frmKarsilastirma.ShowDialog();
         
            TakimlariListele();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TakimlariListele();
        }

        private void TakimlariListele()
        {
            dgvMaclar.Rows.Clear();

            foreach (var item in db.Veriler)
            {
                dgvMaclar.Rows.Add(item.Id, item.Takim1, item.Takim2, item.Tarih, item.Skor1, item.Skor2, item.Durum);
            }
        }

        private void btnSeciliyiSil_Click(object sender, EventArgs e)
        {
            int id = (int)dgvMaclar.CurrentRow.Cells[0].Value;
            var sil = db.Veriler.Where(x => x.Id == id).FirstOrDefault();

            if (dgvMaclar.Rows.Count >-1)
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Seçilen Veri Silinsin Mi?", "Emin Misiniz.", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    db.Veriler.Remove(sil);
                    db.SaveChanges();
                }
            }

            TakimlariListele();
        }
    }
}
