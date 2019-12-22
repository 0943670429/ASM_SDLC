using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //pass.text = "";

            // pass.text = string.Empty;
            password.Clear();
            username.Clear();
            username.Focus();
        }
        public void closeForm()
        {
            this.Dispose();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = "root";
            pass = "password";

            if ((password.Text == pass) && (username.Text == user))
            {
                MessageBox.Show("Hello guys");
            }
            else
            {
                MessageBox.Show("please check your information");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 signup = new Form3();
            signup.ShowDialog();
            this.closeForm();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button3;
        }
    }
}
