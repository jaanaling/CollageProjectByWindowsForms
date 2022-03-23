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
    public partial class Form2 : Form
    {
        public static string name;
        public static int root;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string server = "localhost";
                string database = "clinic";
                string uid = "root";
                string password = "root";
                string connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                MySqlConnection connection = new MySqlConnection(connectionstring);

                MySqlCommand command = new MySqlCommand("SELECT Root FROM `user` where keyd='" + textBox1.Text + "'", connection);
                MySqlCommand command2 = new MySqlCommand("SELECT name FROM `user` where keyd='" + textBox1.Text + "'", connection);
                connection.Open();
                root = Convert.ToInt32(command.ExecuteScalar());
                name = Convert.ToString(command2.ExecuteScalar());
                connection.Close();

                if (root == 2 || root == 3 || root == 4 || root == 5)
                {
                    Form10 f2 = new Form10();
                    f2.Show();
                    f2.Location = this.Location;
                    this.Hide();
                }
                else if (root == 1)
                {
                    Form11 f2 = new Form11();
                    f2.Show();
                    f2.Location = this.Location;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Данные не верны");
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }

    public class TestsEntryMenu
    {
        [SetUp]
        public void Setup()
        {


            Form2 f1 = new Form2();
            f1.Show(null);

        }

        [TearDown]
        public void TearDown()
        {
            Form2 f1 = new Form2();
            f1.Close();
            f1.Dispose();
        }
        [Test]
        public void entry_chief_Test()
        {
            try
            {
                Form2 f1 = new Form2();
                string server = "localhost";
                string database = "clinic";
                string uid = "root";
                string password = "root";
                string connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                MySqlConnection connection = new MySqlConnection(connectionstring);

                MySqlCommand command = new MySqlCommand("SELECT Root FROM `user` where keyd='" + "ad" + "'", connection);
                connection.Open();
                int root = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();

                if (root == 1)
                {
                    Form10 f2 = new Form10();
                    f2.Show();
                    f2.Location = f1.Location;
                    f1.Hide();
                }
                else if (root == 2)
                {
                    Form11 f2 = new Form11();
                    f2.Show();
                    f2.Location = f1.Location;
                    f1.Hide();
                }
                else
                {
                    MessageBox.Show("Данные не верны");
                }
            }
            catch (Exception ex)
            {

            }
        }
        [Test]
        public void entry_dock_Test()
        {
            try
            {
                Form2 f1 = new Form2();
                string server = "localhost";
                string database = "clinic";
                string uid = "root";
                string password = "root";
                string connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                MySqlConnection connection = new MySqlConnection(connectionstring);

                MySqlCommand command = new MySqlCommand("SELECT Root FROM `user` where keyd='" + "w" + "'", connection);
                connection.Open();
                int root = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();

                if (root == 1)
                {
                    Form10 f2 = new Form10();
                    f2.Show();
                    f2.Location = f1.Location;
                    f1.Hide();
                }
                else if (root == 2)
                {
                    Form11 f2 = new Form11();
                    f2.Show();
                    f2.Location = f1.Location;
                    f1.Hide();
                }
                else
                {
                    MessageBox.Show("Данные не верны");
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
