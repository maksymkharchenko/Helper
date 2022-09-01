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
    public partial class Qiwi : Form
    {
        public Qiwi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Оплата f5 = new Оплата();
            Qiwi f6 = new Qiwi();
            f5.Show();
            f6.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Меню f7 = new Меню();
            Qiwi f6 = new Qiwi();
            f7.Show();
            f6.Close();
        }
    }
}
