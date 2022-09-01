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
    public partial class Успіх_ : Form
    {
        public Успіх_()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Успіх_ f2 = new Успіх_();
            Меню f8 = new Меню();
            f8.Show();
            f2.Close();
        }
    }
}
