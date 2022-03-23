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

namespace WindowsFormsApp7
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
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
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT problem, ID FROM `problems`", connection);
                connection.Open();
                mySqlDataAdapter.Fill(dataSet);
                comboBox1.DataSource = dataSet.Tables[0];
                comboBox1.DisplayMember = "problem";
                comboBox1.ValueMember = "ID";
                connection.Close();

            }
            catch (Exception ex) { MessageBox.Show("Загрузка не завершена\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
            f2.Location = this.Location;
            this.Hide();
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
                DataSet dataSet = new DataSet();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("INSERT INTO `"+comboBox3.Text+"` ( `Name`, `disease`, `Email`) VALUES ('" + textBox1.Text + "', '" + comboBox1.Text + "', '" + textBox2.Text + "');", connection);
                MySqlDataAdapter mySqlDataAdapter2 = new MySqlDataAdapter("INSERT INTO `request` ( `Name`, `disease`, `Email`,`type`) VALUES ('" + textBox1.Text + "', '" + comboBox1.Text + "', '" + textBox2.Text + "', '" + comboBox3.Text + "');", connection);
                mySqlDataAdapter.Fill(dataSet);
                mySqlDataAdapter2.Fill(dataSet);
                MessageBox.Show("Строка добавлена", "Внимание!");
                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show("Добавление не выполнено\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
