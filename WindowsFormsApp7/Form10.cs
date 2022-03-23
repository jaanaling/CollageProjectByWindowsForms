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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f2 = new Form6();
            f2.Show();
            f2.Location = this.Location;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 f2 = new Form8();
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

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
    public class TestsDoctorMenu
    {
        [SetUp]
        public void Setup()
        {


            Form10 f1 = new Form10();
            f1.Show(null);

        }

        [TearDown]
        public void TearDown()
        {
            Form10 f1 = new Form10();
            f1.Close();
            f1.Dispose();
        }
        [Test]
        public void Go_To_ticket_form_Test()
        {

            Form10 f1 = new Form10();
            Form6 f2 = new Form6();
            f2.Show();
            f2.Location = f1.Location;
            f1.Hide();

            Assert.Pass();
        }

        [Test]
        public void Go_To_reference_form_Test()
        {

            Form10 f1 = new Form10();
            Form8 f2 = new Form8();
            f2.Show();
            f2.Location = f1.Location;
            f1.Hide();

            Assert.Pass();
        }

        [Test]
        public void Go_Back_form_Test()
        {

            Form10 f1 = new Form10();
            Form2 f2 = new Form2();
            f2.Show();
            f2.Location = f1.Location;
            f1.Hide();

            Assert.Pass();
        }
    }
}
