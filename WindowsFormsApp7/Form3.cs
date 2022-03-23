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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
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
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM `reference`", connection);
                mySqlDataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
                connection.Close();
              
            }
            catch (Exception ex) { MessageBox.Show("Загрузка не завершенна\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                int index = dataGridView1.SelectedRows[0].Index;

                //Проверяем данные
                if (dataGridView1.Rows[index].Cells[0].Value == null ||
                    dataGridView1.Rows[index].Cells[1].Value == null ||
                    dataGridView1.Rows[index].Cells[2].Value == null ||
                    dataGridView1.Rows[index].Cells[3].Value == null ||
                    dataGridView1.Rows[index].Cells[4].Value == null ||
                    dataGridView1.Rows[index].Cells[5].Value == null

                   )

                {
                    MessageBox.Show("Строка пустая", "Внимание!");
                    return;
                }


                String id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                String name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                String value = dataGridView1.Rows[index].Cells[2].Value.ToString();
                String date = dataGridView1.Rows[index].Cells[3].Value.ToString();
                String root = dataGridView1.Rows[index].Cells[4].Value.ToString();
                String time = dataGridView1.Rows[index].Cells[5].Value.ToString();

                string server = "localhost";
                string database = "clinic";
                string uid = "root";
                string password = "root";
                string connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                MySqlConnection connection = new MySqlConnection(connectionstring);
                DataSet dataSet = new DataSet();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("INSERT INTO `reference` (`ID`, `Name_doc`, `Name`, `disease`, `time_beginning`, `time_end`) VALUES ('" + id + "', '" + name + "', '" + value + "','" + date + "','" + root + "','" + time + "');", connection);
                mySqlDataAdapter.Fill(dataSet);
             
                MessageBox.Show("Строка добавлена", "Внимание!");
                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show("Добавление не выполнено\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.SelectedRows[0].Index;


                //Проверяем данные
                if (dataGridView1.Rows[index].Cells[0].Value == null ||
                    dataGridView1.Rows[index].Cells[1].Value == null ||
                    dataGridView1.Rows[index].Cells[2].Value == null ||
                    dataGridView1.Rows[index].Cells[3].Value == null ||
                    dataGridView1.Rows[index].Cells[4].Value == null ||
                    dataGridView1.Rows[index].Cells[5].Value == null

                   )

                {
                    MessageBox.Show("Строка пустая", "Внимание!");
                    return;
                }


                String id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                String name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                String value = dataGridView1.Rows[index].Cells[2].Value.ToString();
                String date = dataGridView1.Rows[index].Cells[3].Value.ToString();
                String root = dataGridView1.Rows[index].Cells[4].Value.ToString();
                String time = dataGridView1.Rows[index].Cells[5].Value.ToString();


                string server = "localhost";
                string database = "clinic";
                string uid = "root";
                string password = "root";
                string connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                MySqlConnection connection = new MySqlConnection(connectionstring);
                DataSet dataSet = new DataSet();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("UPDATE `reference` SET `ID` = '" + id + "', `Name_doc` = '" + name + "', `Name` = '" + value + "', `disease` ='" + date + "', `time_beginning` ='" + root + "', `time_end` ='" +time + "' WHERE `reference`.`ID` = " + id, connection);
                mySqlDataAdapter.Fill(dataSet);
                Console.Read();
                MessageBox.Show("Строка изменена", "Внимание!");
                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show("Изменение не выполнено\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
                MySqlCommand mySqlDataAdapter = new MySqlCommand("DELETE FROM reference WHERE id = " + id, connection);
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

        private void button5_Click(object sender, EventArgs e)
        {
            Form11 f2 = new Form11();
            f2.Show();
            f2.Location = this.Location;
            this.Hide();
        }
    }
    public class TestsReferenceMenu
    {
        [SetUp]
        public void Setup()
        {
            Form3 f1 = new Form3();
            f1.Show(null);
        }

        [TearDown]
        public void TearDown()
        {
            Form3 f1 = new Form3();
            f1.Close();
            f1.Dispose();
        }
        [Test]
        public void GoBackFormTest()
        {
            Form3 f1 = new Form3();
            Form11 f2 = new Form11();
            f2.Show();
            f2.Location = f1.Location;
            f1.Hide();

            Assert.Pass();
        }
        [Test]
        public void FormLoadTest()
        {
            try
            {
                Form3 f1 = new Form3();
                string server = "localhost";
                string database = "clinic";
                string uid = "root";
                string password = "root";
                string connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                MySqlConnection connection = new MySqlConnection(connectionstring);


                DataSet dataSet = new DataSet();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM `reference`", connection);
                mySqlDataAdapter.Fill(dataSet);
                f1.dataGridView1.DataSource = dataSet.Tables[0];
                connection.Close();

            }
            catch (Exception ex) { MessageBox.Show("Загрузка не завершенна\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
