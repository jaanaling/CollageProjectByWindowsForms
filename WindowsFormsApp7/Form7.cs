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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
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
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT office, ID FROM `offices`", connection);
                connection.Open();
                mySqlDataAdapter.Fill(dataSet);
                comboBox2.DataSource = dataSet.Tables[0];
                comboBox2.DisplayMember = "office";
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
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT Email, ID FROM `" + Form6.Type() + "`", connection);
                connection.Open();
                mySqlDataAdapter.Fill(dataSet);
                comboBox1.DataSource = dataSet.Tables[0];
                comboBox1.DisplayMember = "Email";
                comboBox1.ValueMember = "ID";
                connection.Close();

            }
            catch (Exception ex) { MessageBox.Show("Загрузка не завершена\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                string server = "localhost";
                string database = "clinic";
                string uid = "root";
                string password = "root";
                string connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                MySqlConnection connection = new MySqlConnection(connectionstring);
                DataSet dataSet = new DataSet();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("INSERT INTO `ticket` ( `Name`, `office`, `time`, `email`) VALUES ('" + textBox1.Text + "', '" +  comboBox2.Text + "','" + dateTimePicker1.Text + "','" + comboBox1.Text + "');", connection);
                mySqlDataAdapter.Fill(dataSet);
                Console.Read();
                MessageBox.Show("Строка добавлена", "Внимание!");
                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show("Добавление не выполнено\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
}

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f2 = new Form6();
            f2.Show();
            f2.Location = this.Location;
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
