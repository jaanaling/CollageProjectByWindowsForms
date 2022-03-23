using MySql.Data.MySqlClient;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form6 : Form
    {

        public Form6()
        {
            InitializeComponent();

        }
        static public string Type()
        {
            string type = "";
            int r = Form2.root;

            switch (r)
            {
                case 2:
                    type = "терапевт";
                    break;
                case 3:
                    type = "ЛОР";
                    break;
                case 4:
                    type = "Аллерголог";
                    break;
                case 5:
                    type = "Венеролог";
                    break;
            }
            return type;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                string server = "localhost";
                string database = "clinic";
                string uid = "root";
                string password = "root";
                string connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                MySqlConnection connection = new MySqlConnection(connectionstring);


                DataSet dataSet = new DataSet();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM `"+Type()+"`", connection);
                mySqlDataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
                connection.Close();

            }
            catch (Exception ex) { MessageBox.Show("Загрузка не завершенна\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 f2 = new Form10();
            f2.Show();
            f2.Location = this.Location;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id1 = dataGridView1.CurrentRow.Index;
                String id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                string server = "localhost";
                string database = "clinic";
                string uid = "root";
                string password = "root";
                string connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                MySqlConnection connection = new MySqlConnection(connectionstring);
                DataSet dataSet = new DataSet();
                MySqlCommand mySqlDataAdapter = new MySqlCommand("DELETE FROM `" + Type() + "` WHERE id = " + id, connection);
                //mySqlDataAdapter.Delete(dataSet);
                connection.Open();
                mySqlDataAdapter.ExecuteNonQuery();
                MessageBox.Show("Строка удалена", "Внимание!");
                connection.Close();
                dataGridView1.Rows.Remove(dataGridView1.Rows[id1]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Удаление не выполнено\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f2 = new Form7();
            f2.Show();
            f2.Location = this.Location;
            this.Hide();
        }
    }









    public class TestsRequestMenu
    {
        [SetUp]
        public void Setup()
        {
            Form6 f1 = new Form6();
            f1.Show(null);
        }

        [TearDown]
        public void TearDown()
        {
            Form6 f1 = new Form6();
            f1.Close();
            f1.Dispose();
        }
        [Test]
        public void GoBackFormTest()
        {
            Form6 f1 = new Form6();
            Form10 f2 = new Form10();
            f2.Show();
            f2.Location = f1.Location;
            f1.Hide();

            Assert.Pass();
        }
        [Test]
        public void GoTicketFormTest()
        {
            Form6 f1 = new Form6();
            Form7 f2 = new Form7();
            f2.Show();
            f2.Location = f1.Location;
            f1.Hide();

            Assert.Pass();
        }
        [NUnit.Framework.Test]
        public void FormLoadTest()
        {
            try
            {
                Form6 f1 = new Form6();
                string server = "localhost";
                string database = "clinic";
                string uid = "root";
                string password = "root";
                string connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                MySqlConnection connection = new MySqlConnection(connectionstring);


                DataSet dataSet = new DataSet();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM `request`", connection);
                mySqlDataAdapter.Fill(dataSet);
                f1.dataGridView1.DataSource = dataSet.Tables[0];
                connection.Close();

            }
            catch (Exception ex) { MessageBox.Show("Загрузка не завершенна\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
