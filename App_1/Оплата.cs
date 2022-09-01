using MySql.Data.MySqlClient;
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
    public partial class Оплата : Form
    {
        public Оплата()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                string verif = textBox4.Text;
                if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("Не заповнені обов'язкові поля");
                    return;
                }
                else if (!verif.Contains('/'))
                {
                    MessageBox.Show("Невірний формат дати");
                    return;
                }
                else if (textBox2.Text.Length < 3)
                {
                    MessageBox.Show("Мінімальний розмір CVV 3 символи");
                    return;
                }
                else if (textBox1.Text.Length < 16)
                {
                    MessageBox.Show("Мінімальний розмір карти 16 символів");
                    return;
                }
            }

            DB db = new DB();



            MySqlCommand command = new MySqlCommand("insert into Cards values (@ID,@Number,@Name,@EndDate,@CVV)", db.GetConnection());
            command.Parameters.Add("@ID", MySqlDbType.Int32);
            command.Parameters.Add("@Number", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@EndDate", MySqlDbType.VarChar).Value = textBox4.Text;
            command.Parameters.Add("@CVV", MySqlDbType.VarChar).Value = textBox3.Text;


            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                Hide();
                Оплата f2 = new Оплата();
                Успіх f1 = new Успіх();
                f1.Show();
                f2.Close();
            }
            else
                MessageBox.Show("Помилка з'єднання з сервером");




            db.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Hide();
                Form1 f1 = new Form1();
                Меню f3 = new Меню();
                f1.Show();
                f3.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            {
                char number = e.KeyChar;
                if (!Char.IsDigit(number) && number != 8 && number !=32)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 65 || e.KeyChar >= 90) && number != 8 && number != 32)
            {
                e.Handled = true;
            }





        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            {
                char number = e.KeyChar;
                if (  (e.KeyChar <= 46 || e.KeyChar >= 57) && number != 92 && number != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }   }



