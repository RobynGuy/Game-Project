using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Project
{
    public partial class Form2 : Form
    {
        
        string playerName;

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public string _textBox1
        {
            get { return txtName.Text; }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            playerName = txtName.Text;


            if (Regex.IsMatch(playerName, @"^[a-zA-Z]+$"))//checks playerName for letters
            {
                //if playerName valid (only letters) 
                MessageBox.Show("Starting");

                Form1 frm = new Form1();
                frm._textBox = _textBox1;
                frm.Show();
                this.Hide();
            }
            else
            {
                //invalid playerName, clear txtName and focus on it to try again
                MessageBox.Show("please enter a name using letters only!");
                txtName.Clear();

                txtName.Focus();
            }

        }
    }
}
