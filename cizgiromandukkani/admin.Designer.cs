namespace cizgiromandukkani
{
    partial class admin
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
            this.components = new System.ComponentModel.Container();
            this.tbkitapfiyat = new System.Windows.Forms.TextBox();
            this.tbkitapadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnkitapekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.kategorisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cizgiromanDBDataSet = new cizgiromandukkani.cizgiromanDBDataSet();
            this.tbstok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kategorisTableAdapter = new cizgiromandukkani.cizgiromanDBDataSetTableAdapters.kategorisTableAdapter();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kategorisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cizgiromanDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbkitapfiyat
            // 
            this.tbkitapfiyat.Location = new System.Drawing.Point(194, 144);
            this.tbkitapfiyat.Name = "tbkitapfiyat";
            this.tbkitapfiyat.Size = new System.Drawing.Size(100, 20);
            this.tbkitapfiyat.TabIndex = 7;
            // 
            // tbkitapadi
            // 
            this.tbkitapadi.Location = new System.Drawing.Point(194, 108);
            this.tbkitapadi.Name = "tbkitapadi";
            this.tbkitapadi.Size = new System.Drawing.Size(100, 20);
            this.tbkitapadi.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kitap Fiyatı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kitap Adı : ";
            // 
            // btnkitapekle
            // 
            this.btnkitapekle.Location = new System.Drawing.Point(322, 165);
            this.btnkitapekle.Name = "btnkitapekle";
            this.btnkitapekle.Size = new System.Drawing.Size(113, 30);
            this.btnkitapekle.TabIndex = 6;
            this.btnkitapekle.Text = "Kitap Ekle";
            this.btnkitapekle.UseVisualStyleBackColor = true;
            this.btnkitapekle.Click += new System.EventHandler(this.btnkitapekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Yeni Kitap Kategorisini Ekle:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.kategorisBindingSource;
            this.comboBox1.DisplayMember = "kategoriadi";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(194, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "kategoriID";
            // 
            // kategorisBindingSource
            // 
            this.kategorisBindingSource.DataMember = "kategoris";
            this.kategorisBindingSource.DataSource = this.cizgiromanDBDataSet;
            // 
            // cizgiromanDBDataSet
            // 
            this.cizgiromanDBDataSet.DataSetName = "cizgiromanDBDataSet";
            this.cizgiromanDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbstok
            // 
            this.tbstok.Location = new System.Drawing.Point(194, 171);
            this.tbstok.Name = "tbstok";
            this.tbstok.Size = new System.Drawing.Size(100, 20);
            this.tbstok.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Stok : ";
            // 
            // kategorisTableAdapter
            // 
            this.kategorisTableAdapter.ClearBeforeFill = true;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(159, 202);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 12;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(257, 202);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(75, 23);
            this.btnguncelle.TabIndex = 13;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(484, 214);
            this.dataGridView1.TabIndex = 14;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 494);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.tbstok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbkitapfiyat);
            this.Controls.Add(this.tbkitapadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnkitapekle);
            this.Controls.Add(this.label1);
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YÖNETİCİ PANELİ";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kategorisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cizgiromanDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbkitapfiyat;
        private System.Windows.Forms.TextBox tbkitapadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnkitapekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbstok;
        private System.Windows.Forms.Label label4;
        private cizgiromanDBDataSet cizgiromanDBDataSet;
        private System.Windows.Forms.BindingSource kategorisBindingSource;
        private cizgiromanDBDataSetTableAdapters.kategorisTableAdapter kategorisTableAdapter;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}