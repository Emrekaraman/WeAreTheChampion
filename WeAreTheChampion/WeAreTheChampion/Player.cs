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
    public partial class Player : Form
    {
        WeAreTheChampionsContext db;
        public Player(WeAreTheChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
            KisileriListele();
            FormuResetle();
        }     
        private void FormuResetle()
        {
            txtPlayer.Clear();
            cboPlayerTakım.SelectedIndex = -1;
        }

        private void KisileriListele()
        {
            dgvPlayer.Rows.Clear();

            foreach (var item in db.Players)
            {
                dgvPlayer.Rows.Add(item.PlayerName);
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cboPlayerTakım.SelectedIndex < 0 || txtPlayer.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
                return;
            }
            string playerName = txtPlayer.Text.Trim();
            var team = cboPlayerTakım.SelectedIndex + 1;
            db.Players.Add(new Moldels.Player()
            {
                PlayerName = playerName,
                TeamId = team,
            });
            db.SaveChanges();
            KisileriListele();
            FormuResetle();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            string seciliSatir = dgvPlayer.CurrentRow.Cells[0].Value.ToString();
            var sil = db.Players.Where(x => x.PlayerName == seciliSatir).FirstOrDefault();
            db.Players.Remove(sil);
            db.SaveChanges();
            KisileriListele();
            FormuResetle();
        }
        private void cboPlayerTakım_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboFiltreTakım.Items.Clear();
            foreach (var item in db.Teams)
            {
                cboFiltreTakım.Items.Add(item.TeamName);
            }
        }

        private void Player_Load(object sender, EventArgs e)
        {
            foreach (var item in db.Teams)
            {
                cboPlayerTakım.Items.Add(item.TeamName);
                cboFiltreTakım.Items.Add(item.TeamName);
            }
        }

        private void cboFiltreTakım_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvFiltre.Rows.Clear();
            int id = 0;
            string takim = "";
            foreach (var item in db.Teams)
            {
                if (cboFiltreTakım.Text == item.TeamName)
                {
                    id = item.Id;
                    takim = item.TeamName;
                }
            }
            foreach (var item in db.Players)
            {
                if (id == item.TeamId)
                {
                    dgvFiltre.Rows.Add(item.PlayerName);
                }
            }
        }
    }
}

