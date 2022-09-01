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
    public partial class Реєстрація : Form
    {
        public Реєстрація()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkUser())
                return;

            string verif = textBox2.Text;
            if (textBox3.Text == "" || textBox2.Text == "" || textBox1.Text == "" || maskedTextBox1.Text == "" || maskedTextBox1.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Не заповнені обов'язкові поля");
                return;
            }
            else if (maskedTextBox1.Text != maskedTextBox2.Text)
            {
                MessageBox.Show("Пароль не збігається");
                return;
            }
            else if (!verif.Contains('@'))
            {
                MessageBox.Show("Невірний формат е-мейлу");
                return;
            }
            else if (textBox3.Text.Length < 5 || maskedTextBox1.Text.Length < 5)
            {
                MessageBox.Show("Мінімальний розмір логіну та паролю 5 символів");
                return;
            }



            DB db = new DB();
            db.OpenConnection();


            MySqlCommand command = new MySqlCommand("Insert into reg values (@ID, @EMail, @Login, @Password, @PasswordConfirm,@Name, @Surname)", db.GetConnection());
            command.Parameters.Add("@ID", MySqlDbType.Int32);
            command.Parameters.Add("@EMail", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = maskedTextBox1.Text;
            command.Parameters.Add("@PasswordConfirm", MySqlDbType.VarChar).Value = maskedTextBox2.Text;
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@Surname", MySqlDbType.VarChar).Value = textBox4.Text;



            if (command.ExecuteNonQuery() == 1)

            {


                Hide();
                Реєстрація f2 = new Реєстрація();
                Меню f1 = new Меню();
                f1.Show();
                f2.Close();
            }
            else
                MessageBox.Show("Помилка з'єднання з сервером");


            Boolean checkUser()
            {
                DB db1 = new DB();


                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();


                MySqlCommand command1 = new MySqlCommand("select * from reg where Login = @uL  ", db1.GetConnection());
                command1.Parameters.Add("@uL", MySqlDbType.VarChar).Value = textBox3.Text;

                adapter.SelectCommand = command1;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {

                    MessageBox.Show("Користувач вже існує");

                    return true;
                }

                else



                    MessageBox.Show("Зареєстровано");
                db1.CloseConnection();
                return false;



            }

            db.CloseConnection();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Реєстрація f2 = new Реєстрація();
            Form1 f1 = new Form1();
            f1.Show();
            f2.Close();
        }
    }
}
