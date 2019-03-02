namespace Rent_a_car_project
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbtc = new System.Windows.Forms.MaskedTextBox();
            this.txtkm = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtucret = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtcalisansoyad = new System.Windows.Forms.TextBox();
            this.txtcalısanad = new System.Windows.Forms.TextBox();
            this.txtalınankm = new System.Windows.Forms.TextBox();
            this.txtplaka = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnlistele = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verKmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alKmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblKiralamaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentaCarDataSet = new Rent_a_car_project.RentaCarDataSet();
            this.tbl_KiralamaTableAdapter = new Rent_a_car_project.RentaCarDataSetTableAdapters.Tbl_KiralamaTableAdapter();
            this.btntemizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKiralamaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaCarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbtc);
            this.groupBox1.Controls.Add(this.txtkm);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alıcı Bilgileri";
            // 
            // mtbtc
            // 
            this.mtbtc.Location = new System.Drawing.Point(126, 130);
            this.mtbtc.Mask = "00000000000";
            this.mtbtc.Name = "mtbtc";
            this.mtbtc.Size = new System.Drawing.Size(123, 27);
            this.mtbtc.TabIndex = 15;
            this.mtbtc.ValidatingType = typeof(int);
            // 
            // txtkm
            // 
            this.txtkm.Location = new System.Drawing.Point(126, 163);
            this.txtkm.Name = "txtkm";
            this.txtkm.Size = new System.Drawing.Size(123, 27);
            this.txtkm.TabIndex = 14;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(126, 99);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(123, 27);
            this.txtsoyad.TabIndex = 13;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(126, 66);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(123, 27);
            this.txtad.TabIndex = 12;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(126, 32);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(123, 27);
            this.txtid.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "VERİLEN KM:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "TC KİMLİK NO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "SOYAD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "AD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtucret);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtcalisansoyad);
            this.groupBox2.Controls.Add(this.txtcalısanad);
            this.groupBox2.Controls.Add(this.txtalınankm);
            this.groupBox2.Controls.Add(this.txtplaka);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(295, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 278);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Bilgileri";
            // 
            // txtucret
            // 
            this.txtucret.Location = new System.Drawing.Point(142, 171);
            this.txtucret.Name = "txtucret";
            this.txtucret.Size = new System.Drawing.Size(123, 27);
            this.txtucret.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(72, 174);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 19);
            this.label14.TabIndex = 22;
            this.label14.Text = "ÜCRET:";
            // 
            // txtcalisansoyad
            // 
            this.txtcalisansoyad.Location = new System.Drawing.Point(142, 140);
            this.txtcalisansoyad.Name = "txtcalisansoyad";
            this.txtcalisansoyad.Size = new System.Drawing.Size(123, 27);
            this.txtcalisansoyad.TabIndex = 21;
            // 
            // txtcalısanad
            // 
            this.txtcalısanad.Location = new System.Drawing.Point(142, 108);
            this.txtcalısanad.Name = "txtcalısanad";
            this.txtcalısanad.Size = new System.Drawing.Size(123, 27);
            this.txtcalısanad.TabIndex = 20;
            // 
            // txtalınankm
            // 
            this.txtalınankm.Location = new System.Drawing.Point(142, 74);
            this.txtalınankm.Name = "txtalınankm";
            this.txtalınankm.Size = new System.Drawing.Size(123, 27);
            this.txtalınankm.TabIndex = 14;
            // 
            // txtplaka
            // 
            this.txtplaka.Location = new System.Drawing.Point(142, 43);
            this.txtplaka.Name = "txtplaka";
            this.txtplaka.Size = new System.Drawing.Size(123, 27);
            this.txtplaka.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 19);
            this.label13.TabIndex = 12;
            this.label13.Text = "ÇALIŞAN SOYAD:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 19);
            this.label12.TabIndex = 11;
            this.label12.Text = "ÇALIŞAN AD:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "ALINAN KM:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "PLAKA:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btntemizle);
            this.groupBox3.Controls.Add(this.btnlistele);
            this.groupBox3.Controls.Add(this.btngüncelle);
            this.groupBox3.Controls.Add(this.btnsil);
            this.groupBox3.Controls.Add(this.btnekle);
            this.groupBox3.Location = new System.Drawing.Point(593, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 278);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(31, 177);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(133, 46);
            this.btnlistele.TabIndex = 3;
            this.btnlistele.Text = "LİSTELE";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(31, 126);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(133, 46);
            this.btngüncelle.TabIndex = 2;
            this.btngüncelle.Text = "GÜNCELLE";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(31, 76);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(133, 46);
            this.btnsil.TabIndex = 1;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(31, 26);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(133, 46);
            this.btnekle.TabIndex = 0;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(9, 295);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(784, 219);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "KAYITLAR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.aDDataGridViewTextBoxColumn,
            this.sOYADDataGridViewTextBoxColumn,
            this.tCDataGridViewTextBoxColumn,
            this.verKmDataGridViewTextBoxColumn,
            this.plakaDataGridViewTextBoxColumn,
            this.alKmDataGridViewTextBoxColumn,
            this.calAdDataGridViewTextBoxColumn,
            this.calSoyadDataGridViewTextBoxColumn,
            this.ucretDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblKiralamaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(778, 193);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            // 
            // aDDataGridViewTextBoxColumn
            // 
            this.aDDataGridViewTextBoxColumn.DataPropertyName = "AD";
            this.aDDataGridViewTextBoxColumn.HeaderText = "AD";
            this.aDDataGridViewTextBoxColumn.Name = "aDDataGridViewTextBoxColumn";
            // 
            // sOYADDataGridViewTextBoxColumn
            // 
            this.sOYADDataGridViewTextBoxColumn.DataPropertyName = "SOYAD";
            this.sOYADDataGridViewTextBoxColumn.HeaderText = "SOYAD";
            this.sOYADDataGridViewTextBoxColumn.Name = "sOYADDataGridViewTextBoxColumn";
            // 
            // tCDataGridViewTextBoxColumn
            // 
            this.tCDataGridViewTextBoxColumn.DataPropertyName = "TC";
            this.tCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.tCDataGridViewTextBoxColumn.Name = "tCDataGridViewTextBoxColumn";
            // 
            // verKmDataGridViewTextBoxColumn
            // 
            this.verKmDataGridViewTextBoxColumn.DataPropertyName = "VerKm";
            this.verKmDataGridViewTextBoxColumn.HeaderText = "VerKm";
            this.verKmDataGridViewTextBoxColumn.Name = "verKmDataGridViewTextBoxColumn";
            // 
            // plakaDataGridViewTextBoxColumn
            // 
            this.plakaDataGridViewTextBoxColumn.DataPropertyName = "Plaka";
            this.plakaDataGridViewTextBoxColumn.HeaderText = "Plaka";
            this.plakaDataGridViewTextBoxColumn.Name = "plakaDataGridViewTextBoxColumn";
            // 
            // alKmDataGridViewTextBoxColumn
            // 
            this.alKmDataGridViewTextBoxColumn.DataPropertyName = "AlKm";
            this.alKmDataGridViewTextBoxColumn.HeaderText = "AlKm";
            this.alKmDataGridViewTextBoxColumn.Name = "alKmDataGridViewTextBoxColumn";
            // 
            // calAdDataGridViewTextBoxColumn
            // 
            this.calAdDataGridViewTextBoxColumn.DataPropertyName = "CalAd";
            this.calAdDataGridViewTextBoxColumn.HeaderText = "CalAd";
            this.calAdDataGridViewTextBoxColumn.Name = "calAdDataGridViewTextBoxColumn";
            // 
            // calSoyadDataGridViewTextBoxColumn
            // 
            this.calSoyadDataGridViewTextBoxColumn.DataPropertyName = "CalSoyad";
            this.calSoyadDataGridViewTextBoxColumn.HeaderText = "CalSoyad";
            this.calSoyadDataGridViewTextBoxColumn.Name = "calSoyadDataGridViewTextBoxColumn";
            // 
            // ucretDataGridViewTextBoxColumn
            // 
            this.ucretDataGridViewTextBoxColumn.DataPropertyName = "Ucret";
            this.ucretDataGridViewTextBoxColumn.HeaderText = "Ucret";
            this.ucretDataGridViewTextBoxColumn.Name = "ucretDataGridViewTextBoxColumn";
            // 
            // tblKiralamaBindingSource
            // 
            this.tblKiralamaBindingSource.DataMember = "Tbl_Kiralama";
            this.tblKiralamaBindingSource.DataSource = this.rentaCarDataSet;
            // 
            // rentaCarDataSet
            // 
            this.rentaCarDataSet.DataSetName = "RentaCarDataSet";
            this.rentaCarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_KiralamaTableAdapter
            // 
            this.tbl_KiralamaTableAdapter.ClearBeforeFill = true;
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(31, 227);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(133, 46);
            this.btntemizle.TabIndex = 4;
            this.btntemizle.Text = "TEMİZLE";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(805, 526);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKiralamaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaCarDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtbtc;
        private System.Windows.Forms.TextBox txtkm;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtucret;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtcalisansoyad;
        private System.Windows.Forms.TextBox txtcalısanad;
        private System.Windows.Forms.TextBox txtalınankm;
        private System.Windows.Forms.TextBox txtplaka;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RentaCarDataSet rentaCarDataSet;
        private System.Windows.Forms.BindingSource tblKiralamaBindingSource;
        private RentaCarDataSetTableAdapters.Tbl_KiralamaTableAdapter tbl_KiralamaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verKmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alKmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucretDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btntemizle;
    }
}

