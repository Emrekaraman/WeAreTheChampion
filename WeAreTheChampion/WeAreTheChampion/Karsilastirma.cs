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
    public partial class Karşılaştırma : Form
    {
        WeAreTheChampionsContext db;
        Team DisSaha;
        Team IcSaha;

        public Karşılaştırma(WeAreTheChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
            cboIcSaha.SelectedIndex = -1;
        }
        private void cboIcSaha_SelectedIndexChanged(object sender, EventArgs e)
        {          
            string renk1 = "";
            string renk2 = "";
            string renk3 = "";
            string renk4 = "";
            lblIcSaha1.Visible = false;
            lblIcSaha2.Visible = false;
            lblIcSaha3.Visible = false;
            lblIcSaha4.Visible = false;
            cboDisSaha.Items.Clear();

            foreach (var item in db.Teams)
            {
                if (cboIcSaha.Text != item.TeamName)
                {
                    cboDisSaha.Items.Add(item.TeamName);
                }
                else if (cboIcSaha.Text==item.TeamName)
                {
                    renk1 = item.RenkAdi1;
                    renk2 = item.RenkAdi2;
                    renk3 = item.RenkAdi3;
                    renk4 = item.RenkAdi4;
                }
            }
            foreach (var item in db.Colors)
            {
                if (renk1==item.ColorName)
                {
                    lblIcSaha1.Visible = true;
                    lblIcSaha1.BackColor = System.Drawing.Color.FromArgb(item.Red,item.Green,item.Blue);
                }
                else if (renk2 == item.ColorName)
                {
                    lblIcSaha2.Visible = true;
                    lblIcSaha2.BackColor = System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue);
                }
                else if (renk3 == item.ColorName)
                {
                    lblIcSaha3.Visible = true;
                    lblIcSaha3.BackColor = System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue);
                }
                else if (renk4 == item.ColorName)
                {
                    lblIcSaha4.Visible = true;
                    lblIcSaha4.BackColor = System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue);
                }
            }              
        }
   
        private void Karşılaştırma_Load(object sender, EventArgs e)
        {
            cboIcSaha.DataSource = db.Teams.ToList();
            cboIcSaha.DisplayMember = "TeamName";
            cboIcSaha.ValueMember = "Id";
            cboIcSaha.SelectedIndex = -1;
        }

        private void btnKarsilastirmaEkle_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            int durum = 0;
            foreach (var item in db.Teams)
            {
                if (cboIcSaha.Text == item.TeamName)
                {
                    a = item.Id;
                }
                else if (cboDisSaha.Text == item.TeamName)
                {
                    b = item.Id;
                }
            }
            if (nudIcSahaScore.Value == nudDisSahaScore.Value)
            {
                durum = 0;
            }
            else if (nudIcSahaScore.Value > nudDisSahaScore.Value)
            {
                durum = 1;
            }
            else if (nudIcSahaScore.Value < nudDisSahaScore.Value)
            {
                durum = 2;
            }
            Match match = new Match();
            match.MatchTime = dtpTarih.Value;
            match.IcSahaId = a;
            match.IcSahalar = IcSaha;
            match.DısSahaId = b;
            match.DısSahalar = DisSaha;
            match.Score1 = (int)nudIcSahaScore.Value;
            match.Score2 = (int)nudDisSahaScore.Value;
            match.Durumlar = durum;

            db.Matchs.Add(match);
            db.SaveChanges();
            VerileriYukle();
            this.Close();
        }

        private void VerileriYukle()
        {
            int id = 1;
            int takim1Id = 0;
            int takim2Id = 0;
            string tarih = "";
            int score1 = 0;
            int score2 = 0;
            int durum = 0;
            string takimAdi1 = "";
            string takimAdi2 = "";
            string durumum = "";

            foreach (var item in db.Matchs)
            {
                if (id == item.Id)
                {
                    takim1Id = item.IcSahaId;
                    takim2Id = item.DısSahaId;
                    tarih = item.MatchTime.ToString();
                    score1 = (int)item.Score1;
                    score2 = (int)item.Score2;
                    durum = item.Durumlar;
                }
                id++;
            }

            foreach (var item in db.Teams)
            {
                if (takim1Id == item.Id)
                {
                    takimAdi1 = item.TeamName;
                }
                else if (takim2Id == item.Id)
                {
                    takimAdi2 = item.TeamName;
                }
            }

            if (durum == 0)
            {
                durumum = "Berabere";
            }
            else if (durum == 1)
            {
                durumum = "Takım1 Win";
            }
            else if (durum == 2)
            {
                durumum = "Takım2 Win";
            }
            db.Veriler.Add(new Veri()
            {
                Takim1 = takimAdi1,
                Takim2 = takimAdi2,
                Tarih = tarih,
                Skor1 = score1,
                Skor2 = score2,
                Durum = durumum
            });

            db.SaveChanges();
        }

        private void cboDisSaha_SelectedIndexChanged(object sender, EventArgs e)
        {

            string renk1 = "";
            string renk2 = "";
            string renk3 = "";
            string renk4 = "";
            lblDisSaha1.Visible = false;
            lblDisSaha2.Visible = false;
            lblDisSaha3.Visible = false;
            lblDisSaha4.Visible = false;
            foreach (var item in db.Teams)
            {
                
                if (cboDisSaha.Text == item.TeamName)
                {
                    renk1 = item.RenkAdi1;
                    renk2 = item.RenkAdi2;
                    renk3 = item.RenkAdi3;
                    renk4 = item.RenkAdi4;
                }
            }

            foreach (var item in db.Colors)
            {
                if (renk1 == item.ColorName)
                {
                    lblDisSaha1.Visible = true;
                    lblDisSaha1.BackColor = System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue);
                }
                else if (renk2 == item.ColorName)
                {
                    lblDisSaha2.Visible = true;
                    lblDisSaha2.BackColor = System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue);
                }
                else if (renk3 == item.ColorName)
                {
                    lblDisSaha3.Visible = true;
                    lblDisSaha3.BackColor = System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue);
                }
                else if (renk4 == item.ColorName)
                {
                    lblDisSaha4.Visible = true;
                    lblDisSaha4.BackColor = System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue);
                }
            }
        }
    }
}
