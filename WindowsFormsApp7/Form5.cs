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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

        }


        public static string GetW(int x)
        {
            string abc = "qwertyuiopasdfghjklzxcvbnm";


            string pass = "";
            Random r = new Random();
            while (pass.Length < x)
            {
                pass += abc[r.Next(abc.Length)];
            }
            return pass;
        }
        public static string GetN(int n)
        {


            string abc = "123456789";
            string pass = "";
            Random r = new Random();
            while (pass.Length < n)
            {
                pass += abc[r.Next(abc.Length)];
            }
            return pass;
        }

        public static string GetC(int c)
        {
            string abc = "!@#$%^&*()";


            string pass = "";
            Random r = new Random();
            while (pass.Length < c)
            {
                pass += abc[r.Next(abc.Length)];
            }
            return pass;
        }

        public static string GetBW(int bw)
        {
            string abc = "qwertyuiopasdfghjklzxcvbnm";
            abc = abc.ToUpper();

            string pass = "";
            Random r = new Random();
            while (pass.Length < bw)
            {
                pass += abc[r.Next(abc.Length)];
            }
            return pass;
        }

        public static string Shuffle(string s)
        {
            Random rand = new Random();
            char b;
            char[] chars = s.ToCharArray();
            for (int i = chars.Length - 1; i > 0; i--)
            {

                int j = rand.Next(i);
                b = chars[j];
                chars[j] = chars[i];
                chars[i] = b;
            }

            return new string(chars);
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
                MySqlCommand mySqlDataAdapter = new MySqlCommand("DELETE FROM user WHERE id = " + id, connection);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
                    dataGridView1.Rows[index].Cells[4].Value == null
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


                string server = "localhost";
                string database = "clinic";
                string uid = "root";
                string password = "root";
                string connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                MySqlConnection connection = new MySqlConnection(connectionstring);
                DataSet dataSet = new DataSet();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("INSERT INTO `user` (`ID`, `Name`, `Keyd`, `Type`, `Root`) VALUES ('" + id + "', '" + name + "', '" + value + "','" + date + "','" + root + "');", connection);
                mySqlDataAdapter.Fill(dataSet);
                Console.Read();
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
                    dataGridView1.Rows[index].Cells[4].Value == null
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


                string server = "localhost";
                string database = "clinic";
                string uid = "root";
                string password = "root";
                string connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                MySqlConnection connection = new MySqlConnection(connectionstring);
                DataSet dataSet = new DataSet();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("UPDATE `user` SET `ID` = '" + id + "', `Name` = '" + name + "', `Keyd` = '" + value + "', `Type` ='" + date + "', `Root` ='" + root + "' WHERE `user`.`ID` = " + id, connection);
                mySqlDataAdapter.Fill(dataSet);
                Console.Read();
                MessageBox.Show("Строка изменена", "Внимание!");
                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show("Изменение не выполнено\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Form5_Load(object sender, EventArgs e)
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
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM `user`", connection);
                mySqlDataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
                connection.Close();

            }
            catch (Exception ex) { MessageBox.Show("Загрузка не завершенна\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form11 f2 = new Form11();
            f2.Show();
            f2.Location = this.Location;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = GetW(5);
            string number = GetN(5);
            string chars = GetC(5);
            string BigWord = GetBW(5);

            string pass = word + number + chars + BigWord;

            textBox1.Text = Shuffle(pass);
        }

        private void button6_Click(object sender, EventArgs e)
        { string f = ""; 
          
            switch (comboBox1.Text)
            {
                case "":
                    f = "111";
                    break;
                case "Главный врач":
                    f = "1";
                    break;
                case "Терапевт":
                    f = "2";
                    break;
                case "ЛОР":
                    f = "3";
                    break;
                case "Аллерголог":
                    f = "4";
                    break;
                case "Венеролог":
                    f = "5";
                    break;
               
            } 
            string  searchValue = f;

            if (searchValue == "")
            {
                MessageBox.Show("введите данные для поиска", "ошибка");
            }
            else if (searchValue != "")
            {
                bool found = false;

                int rowIndex = -1;
           
                foreach (DataGridViewRow row in dataGridView1.Rows)
        
        {
                    rowIndex = row.Index;
                    if (row.Cells[4].Value != null && row.Cells[4].Value.ToString().Equals(searchValue))
                    {
                        rowIndex = row.Index;
                        dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Pink;
                        found = true;
                        //break;
                    }
                    else
                    {
                        dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
                    }
                }
                if (found == true)
                    MessageBox.Show("данные найдены!", "готово");
                else
                {
                    MessageBox.Show("данные не найдены!", "готово");

                }

            }

        }
    }

    public class TestsUserMenu
    {
        [SetUp]
        public void Setup()
        {
            Form5 f1 = new Form5();
            f1.Show(null);
        }

        [TearDown]
        public void TearDown()
        {
            Form5 f1 = new Form5();
            f1.Close();
            f1.Dispose();
        }
        [Test]
        public void GoBackFormTest()
        {
            Form5 f1 = new Form5();
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
                Form5 f1 = new Form5();
                string server = "localhost";
                string database = "clinic";
                string uid = "root";
                string password = "root";
                string connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                MySqlConnection connection = new MySqlConnection(connectionstring);


                DataSet dataSet = new DataSet();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM `user`", connection);
                mySqlDataAdapter.Fill(dataSet);
                f1.dataGridView1.DataSource = dataSet.Tables[0];
                connection.Close();

            }
            catch (Exception ex) { MessageBox.Show("Загрузка не завершенна\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        [Test]
        public void GeneratorTest()
        {
            Form5 f1 = new Form5();
            string word = Form5.GetW(5);
            string number = Form5.GetN(5);
            string chars = Form5.GetC(5);
            string BigWord = Form5.GetBW(5);

            string pass = word + number + chars + BigWord;
            int f = 0;
            f1.textBox1.Text = Form5.Shuffle(pass);
            if (f1.textBox1.Text != "")
            {
                f = 1;
            }
            Assert.AreEqual(1, f);
        }
        [Test]
        public void AddValueTest()
        {
            for (int i = 1; i <= 4; i++)
            {
                Form7 f1 = new Form7();

                string server = "localhost";
                string database = "test_clinic";
                string uid = "root";
                string password = "root";
                string connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                MySqlConnection connection = new MySqlConnection(connectionstring);

                MySqlCommand command1 = new MySqlCommand("SELECT ID FROM `user_values` where ID=" + i, connection);
                MySqlCommand command2 = new MySqlCommand("SELECT Name FROM `user_values` where ID=" + i, connection);
                MySqlCommand command3 = new MySqlCommand("SELECT Keyd FROM `user_values` where ID=" + i, connection);
                MySqlCommand command4 = new MySqlCommand("SELECT Type FROM `user_values` where ID=" + i, connection);
                MySqlCommand command5 = new MySqlCommand("SELECT Root FROM `user_values` where ID=" + i, connection);
                DataSet dataSet = new DataSet();
                connection.Open();

                int id = Convert.ToInt32(command1.ExecuteScalar());
                string name = Convert.ToString(command2.ExecuteScalar());
                string value = Convert.ToString(command3.ExecuteScalar());
                string date = Convert.ToString(command4.ExecuteScalar());
                int root = Convert.ToInt32(command5.ExecuteScalar());
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("INSERT INTO `user` (`ID`, `Name`, `Keyd`, `Type`, `Root`) VALUES ('" + id + "', '" + name + "', '" + value + "','" + date + "','" + root + "');", connection);
                mySqlDataAdapter.Fill(dataSet);

                MessageBox.Show("Строка добавлена", "Внимание!");
                connection.Close();

            }
        }
    }
    public class ChiefTest
    {
        class Chief
        {
            string server;
            string database;
            string uid;
            string password;
            string connectionstring;

            public Chief()
            {
                this.server = "localhost";
                this.database = "Test_clinic";
                this.uid = "root";
                this.password = "root";
                this.connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            }

            public void AddUser()
            {

                for (int i = 1; i <= 4; i++)
                {
                    Form7 f1 = new Form7();

                    string server = "localhost";
                    string database = "test_clinic";
                    string uid = "root";
                    string password = "root";
                    string connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                    MySqlConnection connection = new MySqlConnection(connectionstring);


                    MySqlCommand command2 = new MySqlCommand("SELECT Name FROM `user_values` where ID=" + i, connection);
                    MySqlCommand command3 = new MySqlCommand("SELECT Keyd FROM `user_values` where ID=" + i, connection);
                    MySqlCommand command4 = new MySqlCommand("SELECT Type FROM `user_values` where ID=" + i, connection);
                    MySqlCommand command5 = new MySqlCommand("SELECT Root FROM `user_values` where ID=" + i, connection);
                    DataSet dataSet = new DataSet();
                    connection.Open();


                    string name = Convert.ToString(command2.ExecuteScalar());
                    string value = Convert.ToString(command3.ExecuteScalar());
                    string date = Convert.ToString(command4.ExecuteScalar());
                    int root = Convert.ToInt32(command5.ExecuteScalar());
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("INSERT INTO `user` ( `Name`, `Keyd`, `Type`, `Root`) VALUES ('" + name + "', '" + value + "','" + date + "','" + root + "');", connection);
                    mySqlDataAdapter.Fill(dataSet);

                    MessageBox.Show("Строка добавлена", "Внимание!");
                    connection.Close();

                }
            }
            public void DelUser()
            {
                for (int i = 1; i <= 5; i = i + 2)
                {

                    MySqlConnection connection = new MySqlConnection(connectionstring);

                    MySqlCommand mySqlDataAdapter = new MySqlCommand("DELETE FROM user WHERE id = " + i, connection);

                    connection.Open();

                    mySqlDataAdapter.ExecuteNonQuery();
                    MessageBox.Show("Строка удалена", "Внимание!");

                    connection.Close();
                }
            }
        }
        Chief chief = new Chief();
        [SetUp]
        public void Setup()
        {
            Form5 f1 = new Form5();
            f1.Show(null);
        }

        [TearDown]
        public void TearDown()
        {
            Form5 f1 = new Form5();
            f1.Close();
            f1.Dispose();
        }
        [Test]
        public void ChiefAddUser()
        {
            chief.AddUser();
        }

        [Test]
        public void ChiefDelUser()
        {
            chief.DelUser();
        }

    }
}
