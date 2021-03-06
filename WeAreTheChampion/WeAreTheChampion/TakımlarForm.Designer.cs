
namespace WeAreTheChampion
{
    partial class Takımlar
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
            this.btnTakimiSil = new System.Windows.Forms.Button();
            this.dgvTakim = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTakımAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRenk4 = new System.Windows.Forms.Label();
            this.lblRenk3 = new System.Windows.Forms.Label();
            this.lblRenk2 = new System.Windows.Forms.Label();
            this.lblRenk1 = new System.Windows.Forms.Label();
            this.dgvRenkler = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTakımOlustur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakim)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenkler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTakimiSil
            // 
            this.btnTakimiSil.Location = new System.Drawing.Point(31, 439);
            this.btnTakimiSil.Name = "btnTakimiSil";
            this.btnTakimiSil.Size = new System.Drawing.Size(586, 38);
            this.btnTakimiSil.TabIndex = 68;
            this.btnTakimiSil.Text = "SİL";
            this.btnTakimiSil.UseVisualStyleBackColor = true;
            this.btnTakimiSil.Click += new System.EventHandler(this.btnTakimiSil_Click);
            // 
            // dgvTakim
            // 
            this.dgvTakim.AllowUserToAddRows = false;
            this.dgvTakim.AllowUserToDeleteRows = false;
            this.dgvTakim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTakim.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTakim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTakim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvTakim.Location = new System.Drawing.Point(31, 270);
            this.dgvTakim.Name = "dgvTakim";
            this.dgvTakim.ReadOnly = true;
            this.dgvTakim.RowHeadersVisible = false;
            this.dgvTakim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTakim.Size = new System.Drawing.Size(586, 163);
            this.dgvTakim.TabIndex = 66;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Id";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Takım Adı";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Renk1";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Renk2";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Renk3";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Renk4";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // txtTakımAd
            // 
            this.txtTakımAd.Location = new System.Drawing.Point(77, 30);
            this.txtTakımAd.Name = "txtTakımAd";
            this.txtTakımAd.Size = new System.Drawing.Size(166, 20);
            this.txtTakımAd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Takım Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblRenk4);
            this.groupBox1.Controls.Add(this.lblRenk3);
            this.groupBox1.Controls.Add(this.lblRenk2);
            this.groupBox1.Controls.Add(this.lblRenk1);
            this.groupBox1.Controls.Add(this.dgvRenkler);
            this.groupBox1.Controls.Add(this.btnTakımOlustur);
            this.groupBox1.Controls.Add(this.txtTakımAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 237);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Takm Bilgileri";
            // 
            // lblRenk4
            // 
            this.lblRenk4.BackColor = System.Drawing.Color.Black;
            this.lblRenk4.Location = new System.Drawing.Point(553, 30);
            this.lblRenk4.Name = "lblRenk4";
            this.lblRenk4.Size = new System.Drawing.Size(27, 151);
            this.lblRenk4.TabIndex = 75;
            this.lblRenk4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblRenk4_MouseClick);
            // 
            // lblRenk3
            // 
            this.lblRenk3.BackColor = System.Drawing.Color.Black;
            this.lblRenk3.Location = new System.Drawing.Point(520, 30);
            this.lblRenk3.Name = "lblRenk3";
            this.lblRenk3.Size = new System.Drawing.Size(27, 151);
            this.lblRenk3.TabIndex = 74;
            this.lblRenk3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblRenk3_MouseClick);
            // 
            // lblRenk2
            // 
            this.lblRenk2.BackColor = System.Drawing.Color.Black;
            this.lblRenk2.Location = new System.Drawing.Point(487, 30);
            this.lblRenk2.Name = "lblRenk2";
            this.lblRenk2.Size = new System.Drawing.Size(27, 151);
            this.lblRenk2.TabIndex = 73;
            this.lblRenk2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblRenk2_MouseClick);
            // 
            // lblRenk1
            // 
            this.lblRenk1.BackColor = System.Drawing.Color.Black;
            this.lblRenk1.Location = new System.Drawing.Point(454, 30);
            this.lblRenk1.Name = "lblRenk1";
            this.lblRenk1.Size = new System.Drawing.Size(27, 151);
            this.lblRenk1.TabIndex = 72;
            this.lblRenk1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblRenk1_MouseClick);
            // 
            // dgvRenkler
            // 
            this.dgvRenkler.AllowUserToAddRows = false;
            this.dgvRenkler.AllowUserToDeleteRows = false;
            this.dgvRenkler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRenkler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRenkler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRenkler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            this.dgvRenkler.Location = new System.Drawing.Point(280, 30);
            this.dgvRenkler.MultiSelect = false;
            this.dgvRenkler.Name = "dgvRenkler";
            this.dgvRenkler.ReadOnly = true;
            this.dgvRenkler.RowHeadersVisible = false;
            this.dgvRenkler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRenkler.Size = new System.Drawing.Size(163, 151);
            this.dgvRenkler.TabIndex = 71;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Id";
            this.Column2.HeaderText = "Id";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ColorName";
            this.Column1.HeaderText = "Renkler";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // btnTakımOlustur
            // 
            this.btnTakımOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTakımOlustur.Location = new System.Drawing.Point(6, 198);
            this.btnTakımOlustur.Name = "btnTakımOlustur";
            this.btnTakımOlustur.Size = new System.Drawing.Size(569, 33);
            this.btnTakımOlustur.TabIndex = 70;
            this.btnTakımOlustur.Text = "TAKIMI OLUŞTUR";
            this.btnTakımOlustur.UseVisualStyleBackColor = true;
            this.btnTakımOlustur.Click += new System.EventHandler(this.btnTakımOlustur_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Renkleri Görmek İçin Tıklamanız Yeterli Olacaktır.";
            // 
            // Takımlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 499);
            this.Controls.Add(this.btnTakimiSil);
            this.Controls.Add(this.dgvTakim);
            this.Controls.Add(this.groupBox1);
            this.Name = "Takımlar";
            this.Text = "Takımlar";
            this.Load += new System.EventHandler(this.Takımlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakim)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenkler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTakimiSil;
        private System.Windows.Forms.DataGridView dgvTakim;
        private System.Windows.Forms.TextBox txtTakımAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTakımOlustur;
        private System.Windows.Forms.Label lblRenk4;
        private System.Windows.Forms.Label lblRenk3;
        private System.Windows.Forms.Label lblRenk2;
        private System.Windows.Forms.Label lblRenk1;
        private System.Windows.Forms.DataGridView dgvRenkler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label label2;
    }
}