﻿using System;
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
    public partial class Зміна_паролю : Form
    {
        public Зміна_паролю()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Успіх_ f2 = new Успіх_();
            Зміна_паролю f8 = new Зміна_паролю();
            f2.Show();
            f8.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Налаштування f2 = new Налаштування();
            Зміна_паролю f9 = new Зміна_паролю();
            f2.Show();
            f9.Close();
        }
    }
}
