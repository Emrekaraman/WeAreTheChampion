
namespace WeAreTheChampion
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMaclar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeciliyiSil = new System.Windows.Forms.Button();
            this.btnYeniKarsilasma = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiTakimlar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRenkler = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOyuncular = new System.Windows.Forms.ToolStripMenuItem();
            this.pbHorse1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaclar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHorse1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaclar
            // 
            this.dgvMaclar.AllowUserToAddRows = false;
            this.dgvMaclar.AllowUserToDeleteRows = false;
            this.dgvMaclar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMaclar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaclar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMaclar.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaclar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvMaclar.Location = new System.Drawing.Point(35, 73);
            this.dgvMaclar.Name = "dgvMaclar";
            this.dgvMaclar.ReadOnly = true;
            this.dgvMaclar.RowHeadersVisible = false;
            this.dgvMaclar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaclar.Size = new System.Drawing.Size(724, 229);
            this.dgvMaclar.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Takim1";
            this.Column2.HeaderText = "Takım 1";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Takim2";
            this.Column3.HeaderText = "Takım 2";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Tarih";
            this.Column4.HeaderText = "Tarih";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Skor1";
            this.Column5.HeaderText = "Skore 1";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Skor2";
            this.Column6.HeaderText = "Skore 2";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Durum";
            this.Column7.HeaderText = "Durum";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // btnSeciliyiSil
            // 
            this.btnSeciliyiSil.Location = new System.Drawing.Point(35, 308);
            this.btnSeciliyiSil.Name = "btnSeciliyiSil";
            this.btnSeciliyiSil.Size = new System.Drawing.Size(135, 23);
            this.btnSeciliyiSil.TabIndex = 10;
            this.btnSeciliyiSil.Text = "SECİLİYİ SİL";
            this.btnSeciliyiSil.UseVisualStyleBackColor = true;
            this.btnSeciliyiSil.Click += new System.EventHandler(this.btnSeciliyiSil_Click);
            // 
            // btnYeniKarsilasma
            // 
            this.btnYeniKarsilasma.Location = new System.Drawing.Point(602, 44);
            this.btnYeniKarsilasma.Name = "btnYeniKarsilasma";
            this.btnYeniKarsilasma.Size = new System.Drawing.Size(157, 23);
            this.btnYeniKarsilasma.TabIndex = 8;
            this.btnYeniKarsilasma.Text = "+ YENİ  KARŞILAŞMA";
            this.btnYeniKarsilasma.UseVisualStyleBackColor = true;
            this.btnYeniKarsilasma.Click += new System.EventHandler(this.btnYeniKarsilasma_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTakimlar,
            this.tsmiRenkler,
            this.tsmiOyuncular});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiTakimlar
            // 
            this.tsmiTakimlar.Name = "tsmiTakimlar";
            this.tsmiTakimlar.Size = new System.Drawing.Size(63, 20);
            this.tsmiTakimlar.Text = "Takımlar";
            this.tsmiTakimlar.Click += new System.EventHandler(this.tsmiTakimlar_Click);
            // 
            // tsmiRenkler
            // 
            this.tsmiRenkler.Name = "tsmiRenkler";
            this.tsmiRenkler.Size = new System.Drawing.Size(58, 20);
            this.tsmiRenkler.Text = "Renkler";
            this.tsmiRenkler.Click += new System.EventHandler(this.tsmiRenkler_Click);
            // 
            // tsmiOyuncular
            // 
            this.tsmiOyuncular.Name = "tsmiOyuncular";
            this.tsmiOyuncular.Size = new System.Drawing.Size(74, 20);
            this.tsmiOyuncular.Text = "Oyuncular";
            this.tsmiOyuncular.Click += new System.EventHandler(this.tsmiOyuncular_Click);
            // 
            // pbHorse1
            // 
            this.pbHorse1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbHorse1.Image = global::WeAreTheChampion.Properties.Resources.futbol1;
            this.pbHorse1.Location = new System.Drawing.Point(458, 308);
            this.pbHorse1.Name = "pbHorse1";
            this.pbHorse1.Size = new System.Drawing.Size(313, 142);
            this.pbHorse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHorse1.TabIndex = 12;
            this.pbHorse1.TabStop = false;
            this.pbHorse1.Tag = "3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMaclar);
            this.Controls.Add(this.btnSeciliyiSil);
            this.Controls.Add(this.btnYeniKarsilasma);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pbHorse1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaclar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHorse1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaclar;
        private System.Windows.Forms.Button btnSeciliyiSil;
        private System.Windows.Forms.Button btnYeniKarsilasma;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiTakimlar;
        private System.Windows.Forms.ToolStripMenuItem tsmiRenkler;
        private System.Windows.Forms.ToolStripMenuItem tsmiOyuncular;
        private System.Windows.Forms.PictureBox pbHorse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

