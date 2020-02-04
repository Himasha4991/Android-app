using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThreeTierA

{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Hs_ID_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BL.insrtBL b2 = new BL.insrtBL();
                b2.insertData(Convert.ToInt32(this.textBox1.Text.Trim()), textBox2.Text.Trim(), Convert.ToInt32(this.textBox3.Text.Trim()), textBox4.Text.Trim());
                MessageBox.Show("added");
            }
            catch {
                MessageBox.Show("error");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
