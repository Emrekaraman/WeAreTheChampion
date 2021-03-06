
namespace WeAreTheChampion
{
    partial class Karşılaştırma
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
            this.cboIcSaha = new System.Windows.Forms.ComboBox();
            this.cboDisSaha = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudIcSahaScore = new System.Windows.Forms.NumericUpDown();
            this.nudDisSahaScore = new System.Windows.Forms.NumericUpDown();
            this.btnKarsilastirmaEkle = new System.Windows.Forms.Button();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIcSaha1 = new System.Windows.Forms.Label();
            this.lblIcSaha2 = new System.Windows.Forms.Label();
            this.lblIcSaha4 = new System.Windows.Forms.Label();
            this.lblIcSaha3 = new System.Windows.Forms.Label();
            this.lblDisSaha4 = new System.Windows.Forms.Label();
            this.lblDisSaha3 = new System.Windows.Forms.Label();
            this.lblDisSaha2 = new System.Windows.Forms.Label();
            this.lblDisSaha1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudIcSahaScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDisSahaScore)).BeginInit();
            this.SuspendLayout();
            // 
            // cboIcSaha
            // 
            this.cboIcSaha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIcSaha.FormattingEnabled = true;
            this.cboIcSaha.Location = new System.Drawing.Point(27, 109);
            this.cboIcSaha.Name = "cboIcSaha";
            this.cboIcSaha.Size = new System.Drawing.Size(92, 21);
            this.cboIcSaha.TabIndex = 1;
            this.cboIcSaha.SelectedIndexChanged += new System.EventHandler(this.cboIcSaha_SelectedIndexChanged);
            // 
            // cboDisSaha
            // 
            this.cboDisSaha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDisSaha.FormattingEnabled = true;
            this.cboDisSaha.Location = new System.Drawing.Point(386, 109);
            this.cboDisSaha.Name = "cboDisSaha";
            this.cboDisSaha.Size = new System.Drawing.Size(88, 21);
            this.cboDisSaha.TabIndex = 2;
            this.cboDisSaha.SelectedIndexChanged += new System.EventHandler(this.cboDisSaha_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "İç Saha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dış Saha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(222, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Karşılaşma \r\nTarih-Saat";
            // 
            // nudIcSahaScore
            // 
            this.nudIcSahaScore.Location = new System.Drawing.Point(180, 142);
            this.nudIcSahaScore.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudIcSahaScore.Name = "nudIcSahaScore";
            this.nudIcSahaScore.Size = new System.Drawing.Size(51, 20);
            this.nudIcSahaScore.TabIndex = 5;
            // 
            // nudDisSahaScore
            // 
            this.nudDisSahaScore.Location = new System.Drawing.Point(301, 142);
            this.nudDisSahaScore.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudDisSahaScore.Name = "nudDisSahaScore";
            this.nudDisSahaScore.Size = new System.Drawing.Size(51, 20);
            this.nudDisSahaScore.TabIndex = 5;
            // 
            // btnKarsilastirmaEkle
            // 
            this.btnKarsilastirmaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKarsilastirmaEkle.Location = new System.Drawing.Point(67, 250);
            this.btnKarsilastirmaEkle.Name = "btnKarsilastirmaEkle";
            this.btnKarsilastirmaEkle.Size = new System.Drawing.Size(372, 145);
            this.btnKarsilastirmaEkle.TabIndex = 6;
            this.btnKarsilastirmaEkle.Text = "+";
            this.btnKarsilastirmaEkle.UseVisualStyleBackColor = true;
            this.btnKarsilastirmaEkle.Click += new System.EventHandler(this.btnKarsilastirmaEkle_Click);
            // 
            // dtpTarih
            // 
            this.dtpTarih.CustomFormat = "MMMMdd,yyyy | hh:mm";
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTarih.Location = new System.Drawing.Point(180, 86);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(170, 20);
            this.dtpTarih.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "SCORE";
            // 
            // lblIcSaha1
            // 
            this.lblIcSaha1.BackColor = System.Drawing.Color.Black;
            this.lblIcSaha1.Location = new System.Drawing.Point(4, 2);
            this.lblIcSaha1.Name = "lblIcSaha1";
            this.lblIcSaha1.Size = new System.Drawing.Size(145, 18);
            this.lblIcSaha1.TabIndex = 80;
            // 
            // lblIcSaha2
            // 
            this.lblIcSaha2.BackColor = System.Drawing.Color.Black;
            this.lblIcSaha2.Location = new System.Drawing.Point(4, 21);
            this.lblIcSaha2.Name = "lblIcSaha2";
            this.lblIcSaha2.Size = new System.Drawing.Size(145, 18);
            this.lblIcSaha2.TabIndex = 81;
            // 
            // lblIcSaha4
            // 
            this.lblIcSaha4.BackColor = System.Drawing.Color.Black;
            this.lblIcSaha4.Location = new System.Drawing.Point(4, 59);
            this.lblIcSaha4.Name = "lblIcSaha4";
            this.lblIcSaha4.Size = new System.Drawing.Size(145, 18);
            this.lblIcSaha4.TabIndex = 83;
            // 
            // lblIcSaha3
            // 
            this.lblIcSaha3.BackColor = System.Drawing.Color.Black;
            this.lblIcSaha3.Location = new System.Drawing.Point(4, 40);
            this.lblIcSaha3.Name = "lblIcSaha3";
            this.lblIcSaha3.Size = new System.Drawing.Size(145, 18);
            this.lblIcSaha3.TabIndex = 82;
            // 
            // lblDisSaha4
            // 
            this.lblDisSaha4.BackColor = System.Drawing.Color.Black;
            this.lblDisSaha4.Location = new System.Drawing.Point(357, 59);
            this.lblDisSaha4.Name = "lblDisSaha4";
            this.lblDisSaha4.Size = new System.Drawing.Size(145, 18);
            this.lblDisSaha4.TabIndex = 87;
            this.lblDisSaha4.Visible = false;
            // 
            // lblDisSaha3
            // 
            this.lblDisSaha3.BackColor = System.Drawing.Color.Black;
            this.lblDisSaha3.Location = new System.Drawing.Point(357, 40);
            this.lblDisSaha3.Name = "lblDisSaha3";
            this.lblDisSaha3.Size = new System.Drawing.Size(145, 18);
            this.lblDisSaha3.TabIndex = 86;
            this.lblDisSaha3.Visible = false;
            // 
            // lblDisSaha2
            // 
            this.lblDisSaha2.BackColor = System.Drawing.Color.Black;
            this.lblDisSaha2.Location = new System.Drawing.Point(357, 21);
            this.lblDisSaha2.Name = "lblDisSaha2";
            this.lblDisSaha2.Size = new System.Drawing.Size(145, 18);
            this.lblDisSaha2.TabIndex = 85;
            this.lblDisSaha2.Visible = false;
            // 
            // lblDisSaha1
            // 
            this.lblDisSaha1.BackColor = System.Drawing.Color.Black;
            this.lblDisSaha1.Location = new System.Drawing.Point(357, 2);
            this.lblDisSaha1.Name = "lblDisSaha1";
            this.lblDisSaha1.Size = new System.Drawing.Size(145, 18);
            this.lblDisSaha1.TabIndex = 84;
            this.lblDisSaha1.Visible = false;
            // 
            // Karşılaştırma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 442);
            this.Controls.Add(this.lblDisSaha4);
            this.Controls.Add(this.lblDisSaha3);
            this.Controls.Add(this.lblDisSaha2);
            this.Controls.Add(this.lblDisSaha1);
            this.Controls.Add(this.lblIcSaha4);
            this.Controls.Add(this.lblIcSaha3);
            this.Controls.Add(this.lblIcSaha2);
            this.Controls.Add(this.lblIcSaha1);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.btnKarsilastirmaEkle);
            this.Controls.Add(this.nudDisSahaScore);
            this.Controls.Add(this.nudIcSahaScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDisSaha);
            this.Controls.Add(this.cboIcSaha);
            this.Name = "Karşılaştırma";
            this.Text = "Karşılaştırma";
            this.Load += new System.EventHandler(this.Karşılaştırma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudIcSahaScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDisSahaScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboIcSaha;
        private System.Windows.Forms.ComboBox cboDisSaha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudIcSahaScore;
        private System.Windows.Forms.NumericUpDown nudDisSahaScore;
        private System.Windows.Forms.Button btnKarsilastirmaEkle;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIcSaha1;
        private System.Windows.Forms.Label lblIcSaha2;
        private System.Windows.Forms.Label lblIcSaha4;
        private System.Windows.Forms.Label lblIcSaha3;
        private System.Windows.Forms.Label lblDisSaha4;
        private System.Windows.Forms.Label lblDisSaha3;
        private System.Windows.Forms.Label lblDisSaha2;
        private System.Windows.Forms.Label lblDisSaha1;
    }
}