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
    public partial class Color : Form
    {
        WeAreTheChampionsContext db;

        public Color(WeAreTheChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
            RenkleriListele();
            FormuResetle();
            this.dgvRenkler.Columns[0].Visible = false;
            this.dgvRenkler.Columns[2].Visible = false;
            this.dgvRenkler.Columns[3].Visible = false;
            this.dgvRenkler.Columns[4].Visible = false;
        }
        private void FormuResetle()
        {
            txtRenkAdı.Clear();
            gbBackGround.BackColor = System.Drawing.Color.White;
            lblRed.Text = "000";
            lblGreen.Text = "000";
            lblBlue.Text = "000";
            sbRed.Value = sbRed.Minimum;
            sbGreen.Value = sbGreen.Minimum;
            sbBlue.Value = sbBlue.Minimum;
        }

        private void RenkleriListele()
        {
            dgvRenkler.DataSource = db.Colors.ToList();
        }

        private void sbRed_Scroll(object sender, ScrollEventArgs e)
        {
            
            lblRed.Text = sbRed.Value.ToString();
            gbBackGround.BackColor = System.Drawing.Color.FromArgb(sbRed.Value, sbGreen.Value, sbBlue.Value);
            lblRed.Text = sbRed.Value.ToString();
        }
        private void sbGreen_Scroll(object sender, ScrollEventArgs e)
        {

            lblGreen.Text = sbGreen.Value.ToString();
            gbBackGround.BackColor = System.Drawing.Color.FromArgb(sbRed.Value, sbGreen.Value, sbBlue.Value);
            lblGreen.Text = sbGreen.Value.ToString();
        }
        private void sbBlue_Scroll(object sender, ScrollEventArgs e)
        {

            lblBlue.Text = sbBlue.Value.ToString();
            gbBackGround.BackColor = System.Drawing.Color.FromArgb(sbRed.Value, sbGreen.Value, sbBlue.Value);
            lblBlue.Text = sbBlue.Value.ToString();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string colorName = txtRenkAdı.Text.Trim();
            if (colorName == "")
            {
                MessageBox.Show("Lütfen Oluşturulacak Renk Adını Giriniz");
                return;
            }

            db.Colors.Add(new Moldels.Color()
            {
                ColorName=txtRenkAdı.Text.Trim(),
                Red = (byte)sbRed.Value,
                Green = (byte)sbGreen.Value,
                Blue = (byte)sbBlue.Value,
            }); ;
            db.SaveChanges();
            RenkleriListele();
            FormuResetle();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            int seciliSatir = (int)dgvRenkler.SelectedRows[0].Cells[0].Value;
            var sil = db.Colors.Where(x => x.Id == seciliSatir).FirstOrDefault();
            db.Colors.Remove(sil);
            db.SaveChanges();
            RenkleriListele();
            FormuResetle();

        }


        private void dgvRenkler_MouseClick(object sender, MouseEventArgs e)
        {
            int secilen = (int)dgvRenkler.SelectedRows[0].Cells[0].Value;

            foreach (var item in db.Colors)
            {
                if (secilen == item.Id)
                {
                    sbRed.Value = item.Red;
                    lblRed.Text = item.Red.ToString();
                    sbGreen.Value = item.Green;
                    lblGreen.Text = item.Green.ToString();
                    sbBlue.Value = item.Blue;
                    lblBlue.Text = item.Blue.ToString();
                    gbBackGround.BackColor = System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue);
                    lblRenkAktar.BackColor = System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue);
                }
            }

            gbBackGround.BackColor = System.Drawing.Color.White;
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int secilen = (int)dgvRenkler.SelectedRows[0].Cells[0].Value;

            var guncelle = db.Colors.Find(secilen);

            guncelle.Red = (byte)sbRed.Value;
            guncelle.Green = (byte)sbGreen.Value;
            guncelle.Blue = (byte)sbBlue.Value;

            foreach (var item in db.Colors)
            {
                if (secilen==item.Id)
                {
                    lblRenkAktar.BackColor = System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue);
                }
            }

            db.SaveChanges();
            RenkleriListele();
        }
    }
}
