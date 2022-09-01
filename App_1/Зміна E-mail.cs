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
    public partial class Зміна_E_mail : Form
    {
        public Зміна_E_mail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Успіх_ f2 = new Успіх_();
            Зміна_E_mail f8 = new Зміна_E_mail();
            f2.Show();
            f8.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Налаштування f2 = new Налаштування();
            Зміна_E_mail f8 = new Зміна_E_mail();
            f2.Show();
            f8.Close();
        }
    }
}
