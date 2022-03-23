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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form2.name;

            try
            {
                string server = "localhost";
                string database = "clinic";
                string uid = "root";
                string password = "root";
                string connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                MySqlConnection connection = new MySqlConnection(connectionstring);


                DataSet dataSet = new DataSet();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT disease, ID FROM `diseases`", connection);
                connection.Open();
                mySqlDataAdapter.Fill(dataSet);
                comboBox2.DataSource = dataSet.Tables[0];
                comboBox2.DisplayMember = "disease";
                comboBox2.ValueMember = "ID";
                connection.Close();

            }
            catch (Exception ex) { MessageBox.Show("Загрузка не завершена\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            try
            {
                string server = "localhost";
                string database = "clinic";
                string uid = "root";
                string password = "root";
                string connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                MySqlConnection connection = new MySqlConnection(connectionstring);


                DataSet dataSet = new DataSet();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT Name, ID FROM `request`", connection);
                connection.Open();
                mySqlDataAdapter.Fill(dataSet);
                comboBox1.DataSource = dataSet.Tables[0];
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "ID";
                connection.Close();

            }
            catch (Exception ex) { MessageBox.Show("Загрузка не завершена\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("INSERT INTO `reference` ( `Name_doc`, `Name`, `disease`, `time_beginning`, `time_end`) VALUES ('" + textBox1.Text + "', '" + comboBox1.Text + "', '" + comboBox2.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker1.Text +"');", connection);
                mySqlDataAdapter.Fill(dataSet);
          
                MessageBox.Show("Строка добавлена", "Внимание!");
                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show("Добавление не выполнено\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 f2 = new Form10();
            f2.Show();
            f2.Location = this.Location;
            this.Hide();
        }
    }
    }
