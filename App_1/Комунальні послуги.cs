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
    public partial class Комунальні_послуги : Form
    {
        public Комунальні_послуги()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Оплата f5 = new Оплата();
            Комунальні_послуги f6 = new Комунальні_послуги();
            f5.Show();
            f6.Close();
        }

        private void listOfServicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.listOfServicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Комунальні_послуги_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.ListOfServices". При необходимости она может быть перемещена или удалена.
            this.listOfServicesTableAdapter.Fill(this.database1DataSet.ListOfServices);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Меню f5 = new Меню();
            Комунальні_послуги f6 = new Комунальні_послуги();
            f5.Show();
            f6.Close();
        }
    }
}
