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
    public partial class Меню : Form
    {
        public Меню()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
              Hide();
            Form1 f1 = new Form1();
            Меню f3 = new Меню();
            f1.Show();
            f3.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Комунальні_послуги f7 = new Комунальні_послуги();
            Меню f3 = new Меню();
            f7.Show();
            f3.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form6 f6 = new Form6();
            Меню f3 = new Меню();
            f6.Show();
            f3.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Онлайн_гаманці f4 = new Онлайн_гаманці();
            Меню f3 = new Меню();
            f4.Show();
            f3.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Налаштування f2 = new Налаштування(); 
            Меню f3 = new Меню();
            f2.Show();
            f3.Close();
        }
    }
}
