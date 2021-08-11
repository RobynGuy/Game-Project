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

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dodge the possums to avoid losing lives, if your lives get to 0 you lose. Shoot rubbish bags at the possums to gain points. If you get to 300 points you win.                                                                                    Controls: Press A to turn left and press D to turn right. Left click the mouse/trackpad to shoot. Move the mouse to move the bin","Instructions");
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
