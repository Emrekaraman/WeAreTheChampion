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
    public partial class Takımlar : Form
    {
        WeAreTheChampionsContext db;

        public Takımlar(WeAreTheChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
            TakimleriListele();

        }
        string RenkAdi1 = "";
        string RenkAdi2 = "";
        string RenkAdi3 = "";
        string RenkAdi4 = "";
        private void btnTakımOlustur_Click(object sender, EventArgs e)
        {
            if (RenkAdi1 == "")
            {
                RenkAdi1 = "bos";
            }

            if (RenkAdi2 == "")
            {
                RenkAdi2 = "bos";
            }

            if (RenkAdi3 == "")
            {
                RenkAdi3 = "bos";
            }

            if (RenkAdi4 == "")
            {
                RenkAdi4 = "bos";
            }
            db.Teams.Add(new Team()
            {
                TeamName = txtTakımAd.Text.Trim(),
                RenkAdi1 = RenkAdi1,
                RenkAdi2 = RenkAdi2,
                RenkAdi3 = RenkAdi3,
                RenkAdi4 = RenkAdi4
            });
            db.SaveChanges();
            TakimleriListele();
            lblRenk1.BackColor = System.Drawing.Color.Black;
            lblRenk2.BackColor = System.Drawing.Color.Black;
            lblRenk3.BackColor = System.Drawing.Color.Black;
            lblRenk4.BackColor = System.Drawing.Color.Black;
        }

        private void TakimleriListele()
        {
            dgvTakim.Rows.Clear();

            foreach (var item in db.Teams)
            {
                dgvTakim.Rows.Add(item.Id, item.TeamName, item.RenkAdi1, item.RenkAdi2, item.RenkAdi3, item.RenkAdi4);
            }
        }

        private void btnTakimiSil_Click(object sender, EventArgs e)
        {
            int id = (int)dgvTakim.CurrentRow.Cells[0].Value;
            var sil = db.Teams.Where(x => x.Id == id).FirstOrDefault();

            if (dgvTakim.Rows.Count > -1)
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Seçilen Veri Silinsin Mi?", "Emin Misiniz.", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    db.Teams.Remove(sil);
                    db.SaveChanges();
                    TakimleriListele();
                }
            }


        }

        private void Takımlar_Load(object sender, EventArgs e)
        {
            dgvRenkler.Rows.Clear();

            foreach (var item in db.Colors)
            {
                dgvRenkler.Rows.Add(item.Id, item.ColorName);
            }
        }

        private void lblRenk1_MouseClick(object sender, MouseEventArgs e)
        {
            lblRenk1.BackColor = System.Drawing.Color.Black;
            int id = (int)dgvRenkler.SelectedRows[0].Cells[0].Value;

            foreach (var item in db.Colors)
            {
                if (lblRenk1.BackColor == System.Drawing.Color.Black)
                {
                    if (id == item.Id)
                    {
                        RenkAdi1 = item.ColorName;
                        lblRenk1.BackColor = System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue);
                    }
                }
            }
        }

        private void lblRenk2_MouseClick(object sender, MouseEventArgs e)
        {
            lblRenk2.BackColor = System.Drawing.Color.Black;
            int id = (int)dgvRenkler.SelectedRows[0].Cells[0].Value;

            foreach (var item in db.Colors)
            {
                if (lblRenk2.BackColor == System.Drawing.Color.Black)
                {
                    if (id == item.Id)
                    {
                        RenkAdi2 = item.ColorName;
                        lblRenk2.BackColor = System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue);
                    }
                }
            }
        }

        private void lblRenk3_MouseClick(object sender, MouseEventArgs e)
        {
            lblRenk3.BackColor = System.Drawing.Color.Black;
            int id = (int)dgvRenkler.SelectedRows[0].Cells[0].Value;

            foreach (var item in db.Colors)
            {
                if (lblRenk3.BackColor == System.Drawing.Color.Black)
                {
                    if (id == item.Id)
                    {
                        RenkAdi3 = item.ColorName;
                        lblRenk3.BackColor = System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue);
                    }
                }
            }
        }

        private void lblRenk4_MouseClick(object sender, MouseEventArgs e)
        {
            lblRenk4.BackColor = System.Drawing.Color.Black;
            int id = (int)dgvRenkler.SelectedRows[0].Cells[0].Value;

            foreach (var item in db.Colors)
            {
                if (lblRenk4.BackColor == System.Drawing.Color.Black)
                {
                    if (id == item.Id)
                    {
                        RenkAdi4 = item.ColorName;
                        lblRenk4.BackColor = System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue);
                    }
                }
            }
        }
    }
}

