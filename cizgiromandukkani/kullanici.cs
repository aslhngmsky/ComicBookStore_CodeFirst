using cizgiromandukkani.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cizgiromandukkani
{
    public partial class kullanici : Form
    {
        public kullanici()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
        if (tbadi.Text == "a" && tbsoyadi.Text == "a")
        {
            MessageBox.Show("satın aldınız!!");
            this.Close();
        }
        else
        {
            MessageBox.Show("hatalı giriş");
        }
          
        }
    }
}
