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
    public partial class Онлайн_гаманці : Form
    {
        public Онлайн_гаманці()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Онлайн_гаманці f3 = new Онлайн_гаманці();
            WebMoney f4 = new WebMoney();
            f4.Show();
            f3.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Онлайн_гаманці f3 = new Онлайн_гаманці();
            Qiwi f5 = new Qiwi();
            f5.Show();
            f3.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Онлайн_гаманці f3 = new Онлайн_гаманці();
            PayPal f6 = new PayPal();
            f6.Show();
            f3.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Онлайн_гаманці f3 = new Онлайн_гаманці();
            Меню f2 = new Меню();
            f2.Show();
            f3.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Онлайн_гаманці f2 = new Онлайн_гаманці();
            Form1 f1 = new Form1();
            f1.Show();
            f2.Close();
        }
    }
}
