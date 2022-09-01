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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || maskedTextBox1.Text == "")
                MessageBox.Show("Не заповнені обов'язкові поля");

            else if (textBox1.Text.Length < 5 || maskedTextBox1.Text.Length < 5)
            {
                MessageBox.Show("Мінімальний розмір логіну та паролю 5 символів");
                return;
            }


            string LoginUser = textBox1.Text;
            string PasswordUser = maskedTextBox1.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = GetAdapter();


            MySqlCommand command = new MySqlCommand("select * from reg where Login = @uL and Password = @uP ", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = maskedTextBox1.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Авторизовано");

                Hide();
                Меню f2 = new Меню();
                Form1 f1 = new Form1();
                f2.Show();
                f1.Close();
            }
            else
                MessageBox.Show("Користувач не існує");

        }

        private static MySqlDataAdapter GetAdapter()
        {
            return new MySqlDataAdapter();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Реєстрація f2 = new Реєстрація();
            Form1 f1 = new Form1();
            f2.Show();
            f1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 f1 = new Form1();
            f1.Close();
            this.Close();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}


