using cizgiromandukkani.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cizgiromandukkani
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
       tabloOlustur x = new tabloOlustur();
        private void btnkitapekle_Click(object sender, EventArgs e)
        {
               
                urun y = new urun();
                y.urunadi = tbkitapadi.Text;
                y.fiyat = Convert.ToInt32(tbkitapfiyat.Text);
                y.stok = Convert.ToInt32(tbstok.Text);
                y.kategoriID = Convert.ToInt32(comboBox1.SelectedValue);
                x.urun.Add(y);

                try
                {
                    x.SaveChanges();
                    MessageBox.Show("Kitap Eklendi.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Eklenmedi ");
                }
            
        }

        private void admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cizgiromanDBDataSet.kategoris' table. You can move, or remove it, as needed.
            this.kategorisTableAdapter.Fill(this.cizgiromanDBDataSet.kategoris);
            dataGridView1.DataSource = x.urun.ToList();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {

           int kitapID=Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string kitapadii = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            var sil = x.urun.Where(y => y.urunID == kitapID).FirstOrDefault();
            x.urun.Remove(sil);
            x.SaveChanges();
            MessageBox.Show("kitap silindi");
            foreach (Control item in Controls)//TEXTBOX İÇLERİ SİLİNİR
            {
                if (item is TextBox) item.Text = "";
            }
            dataGridView1.DataSource = x.urun.ToList();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int kitapID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var guncelle = x.urun.Where(y => y.urunID == kitapID).FirstOrDefault();
            guncelle.urunadi = tbkitapadi.Text;
            guncelle.kategoriID = Convert.ToInt32(comboBox1.SelectedValue); ;
            guncelle.fiyat = Convert.ToInt32(tbkitapfiyat.Text);
            guncelle.stok = Convert.ToInt32(tbstok.Text);
            x.SaveChanges();
            MessageBox.Show("kitap güncellendi");
            foreach (Control item in Controls)
            {
                if (item is TextBox) item.Text = "";
            }
            dataGridView1.DataSource = x.urun.ToList();

        }
    }
}
