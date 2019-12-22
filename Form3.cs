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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void closeForm()
        {
            this.Dispose();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void reapeat_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 signin = new Form2();
            signin.ShowDialog();
            this.closeForm();
        }
    }
}
