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
    public partial class Member_Login : Form
    {
        public Member_Login()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 Src = new Form1();
            this.Hide();
            Src.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register Src = new Register();
            this.Hide();
            Src.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Library Src = new Library();
            this.Hide();
            Src.ShowDialog();
        }
    }
}
