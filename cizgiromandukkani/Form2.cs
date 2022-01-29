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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (tbadi.Text == "a" && tbsoyadi.Text == "a")
             {
                 admin a = new admin();
                 a.Show();
                 this.Close();
             }
             else
             {
                 MessageBox.Show("hatalı girişş");
             }
        }
    }
}
