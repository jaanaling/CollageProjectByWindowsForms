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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f2 = new Form5();
            f2.Show();
            f2.Location = this.Location;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f2 = new Form4();
            f2.Show();
            f2.Location = this.Location;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            f2.Show();
            f2.Location = this.Location;
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
            f2.Location = this.Location;
            this.Hide();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }

    public class TestsСhiefMenu
    {
        [SetUp]
        public void Setup()
        {


            Form11 f1 = new Form11();
            f1.Show(null);

        }

        [TearDown]
        public void TearDown()
        {
            Form11 f1 = new Form11();
            f1.Close();
            f1.Dispose();
        }
        [Test]
        public void Go_To_user_form_Test()
        {
            Form11 f1 = new Form11();
         
            Form5 f2 = new Form5();
            f2.Show();
            f2.Location = f1.Location;
            f1.Hide();
            Assert.Pass();
        }
        [Test]
        public void Go_To_referencet_form_Test()
        {
            Form11 f1 = new Form11();
            Form4 f2 = new Form4();
            f2.Show();
            f2.Location = f1.Location;
            f1.Hide();
            Assert.Pass();
        }
        [Test]
        public void Go_To_ticket_form_Test()
        {
            Form11 f1 = new Form11();
            Form3 f2 = new Form3();
            f2.Show();
            f2.Location = f1.Location;
            f1.Hide();
            Assert.Pass();
        }
        [Test]
        public void Go_To_Back_form_Test()
        {
            Form11 f1 = new Form11();
            Form1 f2 = new Form1();
            f2.Show();
            f2.Location = f1.Location;
            f1.Hide();
            Assert.Pass();
        }
    }
}
