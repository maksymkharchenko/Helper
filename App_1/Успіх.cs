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
    public partial class Успіх : Form
    {
        public Успіх()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Успіх f2 = new Успіх();
            Меню f3 = new Меню();
            f3.Show();
            f2.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Hide();
                Успіх f2 = new Успіх();
                Form1 f1 = new Form1();
                f1.Show();
                f2.Close();
            }
        }
    }
}
