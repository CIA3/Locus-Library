using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library01
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {       














            Member_Login Src = new Member_Login();
            this.Hide();
            Src.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Member_Login Src = new Member_Login();
            this.Hide();
            Src.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
