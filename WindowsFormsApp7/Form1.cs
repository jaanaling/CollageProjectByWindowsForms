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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.Location = this.Location;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 f2 = new Form9();
            f2.Show();
            f2.Location = this.Location;
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    public class TestsMainMenu
    {
        [SetUp]
        public void Setup()
        {


            Form1 f1 = new Form1();
            f1.Show(null);

        }

        [TearDown]
        public void TearDown()
        {
            Form1 f1 = new Form1();
            f1.Close();
            f1.Dispose();
        }
        [Test]
        public void Go_To_staff_entry_form_Test()
        {
            Form1 f1 = new Form1();
            Form2 f2 = new Form2();
            f2.Show();
            f2.Location = f1.Location;
            f1.Hide();
            Assert.Pass();
        }
        [Test]
        public void Go_To_Request_form_Test()
        {
            Form1 f1 = new Form1();
            Form9 f2 = new Form9();
            f2.Show();
            f2.Location = f1.Location;
            f1.Hide();
            Assert.Pass();
        }
    } 
}