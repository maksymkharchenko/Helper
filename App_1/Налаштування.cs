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
    public partial class Налаштування : Form
    {
        public Налаштування()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Налаштування f2 = new Налаштування();
            Зміна_логіну f7 = new Зміна_логіну();
            f7.Show();
            f2.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Налаштування f2 = new Налаштування();
            Зміна_E_mail f8 = new Зміна_E_mail();
            f8.Show();
            f2.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Налаштування f2 = new Налаштування();
            Зміна_паролю f9 = new Зміна_паролю();
            f9.Show();
            f2.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Налаштування f2 = new Налаштування();
            Зміна_платіжних_даних f10 = new Зміна_платіжних_даних();
            f10.Show();
            f2.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Меню f3 = new Меню();
            Налаштування f2 = new Налаштування();
            f3.Show();
            f2.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                Hide();
                Налаштування f2 = new Налаштування();
                Form1 f1 = new Form1();
                f1.Show();
                f2.Close();
            }
        }
    }
}
