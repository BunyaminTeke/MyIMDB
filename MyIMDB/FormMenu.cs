using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyIMDB
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        string kAdi = "admin";
        string sifre = "admin";
        bool gorunurmu = false;
        private void FormMenu_Click(object sender, EventArgs e)
        {
            label4.Parent = this;
            label3.Parent = this;



        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == kAdi && textBox2.Text == sifre)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                label4.Visible = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void viewpassword_Click(object sender, EventArgs e)
        {
            if (gorunurmu == true)
            {
                viewpassword.Image = Image.FromFile("C:\\Users\\tekeb\\Desktop\\Yeni klasör (3)\\noviewicon.png");
                textBox2.UseSystemPasswordChar = false;
                gorunurmu = false;
            }
            else
            {
                viewpassword.Image = Image.FromFile("C:\\Users\\tekeb\\Desktop\\Yeni klasör (3)\\viewicon.png");
                textBox2.UseSystemPasswordChar = true;
                gorunurmu = true;
            }
        }
    }
}
