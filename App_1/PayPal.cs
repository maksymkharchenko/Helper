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
    public partial class PayPal : Form
    {
        public PayPal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Оплата f5 = new Оплата();
            PayPal f6 = new PayPal();
            f5.Show();
            f6.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Меню f7 = new Меню();
            PayPal f6 = new PayPal();
            f7.Show();
            f6.Close();
        }
    }
}
