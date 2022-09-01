using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Оплата f5 = new Оплата();
            Form6 f6 = new Form6();
            f5.Show();
            f6.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Меню f3 = new Меню();
            Form6 f6 = new Form6();
            f3.Show();
            f6.Close();
        }
    }
}
