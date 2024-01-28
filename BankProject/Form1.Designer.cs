namespace BankProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAySonu = new System.Windows.Forms.TextBox();
            this.lblAySonu = new System.Windows.Forms.Label();
            this.cmbHasapTuru = new System.Windows.Forms.ComboBox();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHesapAc = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.cmbIslemtipi = new System.Windows.Forms.ComboBox();
            this.btnIslemYap = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.lblAccountStatus = new System.Windows.Forms.Label();
            this.lblAccountFiles = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAySonu);
            this.groupBox1.Controls.Add(this.lblAySonu);
            this.groupBox1.Controls.Add(this.cmbHasapTuru);
            this.groupBox1.Controls.Add(this.txtBakiye);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HESAP AÇMA İŞLEMLERİ";
            // 
            // txtAySonu
            // 
            this.txtAySonu.Location = new System.Drawing.Point(149, 199);
            this.txtAySonu.Name = "txtAySonu";
            this.txtAySonu.Size = new System.Drawing.Size(399, 27);
            this.txtAySonu.TabIndex = 4;
            // 
            // lblAySonu
            // 
            this.lblAySonu.AutoSize = true;
            this.lblAySonu.Location = new System.Drawing.Point(21, 206);
            this.lblAySonu.Name = "lblAySonu";
            this.lblAySonu.Size = new System.Drawing.Size(122, 20);
            this.lblAySonu.TabIndex = 3;
            this.lblAySonu.Text = "AY SONU BAKİYE";
            // 
            // cmbHasapTuru
            // 
            this.cmbHasapTuru.FormattingEnabled = true;
            this.cmbHasapTuru.Location = new System.Drawing.Point(149, 78);
            this.cmbHasapTuru.Name = "cmbHasapTuru";
            this.cmbHasapTuru.Size = new System.Drawing.Size(399, 28);
            this.cmbHasapTuru.TabIndex = 2;
            this.cmbHasapTuru.SelectedIndexChanged += new System.EventHandler(this.cmbHasapTuru_SelectedIndexChanged);
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(149, 166);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(399, 27);
            this.txtBakiye.TabIndex = 1;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(149, 124);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(399, 27);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(149, 41);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(399, 27);
            this.txtId.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "İLK BAKİYE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "AD SOYAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "HESAP TÜRÜ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "HESAP NO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnHesapAc
            // 
            this.btnHesapAc.Location = new System.Drawing.Point(149, 250);
            this.btnHesapAc.Name = "btnHesapAc";
            this.btnHesapAc.Size = new System.Drawing.Size(399, 29);
            this.btnHesapAc.TabIndex = 1;
            this.btnHesapAc.Text = "HESAP AÇ";
            this.btnHesapAc.UseVisualStyleBackColor = true;
            this.btnHesapAc.Click += new System.EventHandler(this.btnHesapAc_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "İŞLEM TİPİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "TUTAR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "İŞLEM NOTU";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(149, 101);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(399, 27);
            this.txtTutar.TabIndex = 8;
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(149, 143);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(399, 27);
            this.txtNot.TabIndex = 7;
            // 
            // cmbIslemtipi
            // 
            this.cmbIslemtipi.FormattingEnabled = true;
            this.cmbIslemtipi.Location = new System.Drawing.Point(149, 55);
            this.cmbIslemtipi.Name = "cmbIslemtipi";
            this.cmbIslemtipi.Size = new System.Drawing.Size(399, 28);
            this.cmbIslemtipi.TabIndex = 10;
            // 
            // btnIslemYap
            // 
            this.btnIslemYap.Location = new System.Drawing.Point(149, 183);
            this.btnIslemYap.Name = "btnIslemYap";
            this.btnIslemYap.Size = new System.Drawing.Size(399, 29);
            this.btnIslemYap.TabIndex = 11;
            this.btnIslemYap.Text = "İŞLEM YAP";
            this.btnIslemYap.UseVisualStyleBackColor = true;
            this.btnIslemYap.Click += new System.EventHandler(this.btnIslemYap_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIslemYap);
            this.groupBox2.Controls.Add(this.cmbIslemtipi);
            this.groupBox2.Controls.Add(this.txtNot);
            this.groupBox2.Controls.Add(this.txtTutar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(0, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 218);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NAKİT İŞLEMLER";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblAccountFiles);
            this.groupBox3.Controls.Add(this.lblTotalBalance);
            this.groupBox3.Location = new System.Drawing.Point(594, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 486);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "HESAP HAREKETLERİ";
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.Location = new System.Drawing.Point(6, 439);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Size = new System.Drawing.Size(292, 28);
            this.lblTotalBalance.TabIndex = 5;
            // 
            // lblAccountStatus
            // 
            this.lblAccountStatus.Location = new System.Drawing.Point(0, 512);
            this.lblAccountStatus.Name = "lblAccountStatus";
            this.lblAccountStatus.Size = new System.Drawing.Size(452, 28);
            this.lblAccountStatus.TabIndex = 4;
            // 
            // lblAccountFiles
            // 
            this.lblAccountFiles.Location = new System.Drawing.Point(15, 34);
            this.lblAccountFiles.Name = "lblAccountFiles";
            this.lblAccountFiles.Size = new System.Drawing.Size(283, 383);
            this.lblAccountFiles.TabIndex = 6;
            this.lblAccountFiles.Click += new System.EventHandler(this.label9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 562);
            this.Controls.Add(this.btnHesapAc);
            this.Controls.Add(this.lblAccountStatus);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnHesapAc;
        private ComboBox cmbHasapTuru;
        private TextBox txtBakiye;
        private TextBox txtAdSoyad;
        private TextBox txtId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtTutar;
        private TextBox txtNot;
        private ComboBox cmbIslemtipi;
        private Button btnIslemYap;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label lblAccountStatus;
        private Label lblAySonu;
        private TextBox txtAySonu;
        private Label lblTotalBalance;
        private Label lblAccountFiles;
    }
}