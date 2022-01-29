using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cizgiromandukkani.Entities;
using System.Data.SqlClient;

namespace cizgiromandukkani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-37V5P3S;Initial Catalog=cizgiromanDB;Integrated Security=True");
        int kac = 0;
        tabloOlustur t = new tabloOlustur();
     
        private void Form1_Load(object sender, EventArgs e)
        {
           baglanti.Open();
           SqlCommand komut1 = new SqlCommand("select * from uruns where urunID=3", baglanti);
           SqlDataReader dr1 = komut1.ExecuteReader(); 
             if (dr1.Read()){
                label2.Text = dr1["stok"].ToString();
                label5.Text = dr1["fiyat"].ToString();
            }baglanti.Close();
             baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from uruns where urunID=2", baglanti);
            SqlDataReader dr = komut.ExecuteReader();         
            if (dr.Read())
            {
                label1.Text = dr["stok"].ToString();
                 label4.Text = dr["fiyat"].ToString();
            }baglanti.Close();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from uruns where urunID=6", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader(); 
             if (dr2.Read()){
                 {  
                     label3.Text = dr2["stok"].ToString();                
                     label6.Text = dr2["fiyat"].ToString();
                 } baglanti.Close();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {  
           
            kullanici k = new kullanici();
            k.Show();
            SqlCommand komut = new SqlCommand("select * from uruns where urunID=2", baglanti);
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();         
            if (dr.Read())          
            kac =Convert.ToInt32(dr["stok"])-1;
            label1.Text=kac.ToString();
            baglanti.Close();
            t.SaveChanges();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kullanici k = new kullanici();
            k.Show();
            SqlCommand komut1 = new SqlCommand("select * from uruns where urunID=3", baglanti);
            baglanti.Open();
            SqlDataReader dr1 = komut1.ExecuteReader();
            if (dr1.Read())
            kac = Convert.ToInt32(dr1["stok"]) - 1;
            label2.Text = kac.ToString();
            baglanti.Close();

            t.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kullanici k = new kullanici();
            k.Show();
            SqlCommand komut2 = new SqlCommand("select * from uruns where urunID=6", baglanti);
            baglanti.Open();
            SqlDataReader dr2 = komut2.ExecuteReader();
            if (dr2.Read())
            kac = Convert.ToInt32(dr2["stok"]) - 1;
            label3.Text = kac.ToString();
            baglanti.Close();

            t.SaveChanges();
        }
    }
}
