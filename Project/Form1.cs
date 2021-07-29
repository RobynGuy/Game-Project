using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Project
{
    public partial class Form1 : Form
    {
        Graphics g; //declare a graphics object called g so we can draw on the Form
        Player player = new Player(); //create an instance of the Spaceship Class called spaceship
        string move;

        bool turnLeft, turnRight;

        //declare a list  missiles from the Missile class
        List<Projectile> projectiles = new List<Projectile>();

        List<Opposition> oppositions = new List<Opposition>();

        List<Opposition2> oppositions2 = new List<Opposition2>();
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                int displacement = 30 + (i * 170);
                oppositions.Add(new Opposition(displacement));
                oppositions2.Add(new Opposition2(displacement));
            }
           
           
        }

        public string _textBox
        {
            set { label7.Text = value; }
        }

        Random i = new Random();

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            player.movePlayer(e.X, e.Y);
        }

        private void tmrPlayer_Tick(object sender, EventArgs e)
        {
          

         
        }
        //this used to be five btw ^^^ yw homie G
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { turnLeft = true; }
            if (e.KeyData == Keys.Right) { turnRight = true; }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { turnLeft = false; }
            if (e.KeyData == Keys.Right) { turnRight = false; }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                projectiles.Add(new Projectile(player.playerRec, player.rotationAngle));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                projectiles.Add(new Projectile(player.playerRec, player.rotationAngle));
            }
        }

        private void tmrShoot_Tick(object sender, EventArgs e)
        {
            foreach (Opposition p in oppositions)
            {

                foreach (Projectile m in projectiles)
                {
                    if (p.oppositionRec.IntersectsWith(m.projectileRec))
                    {
                        p.x = -20;// relocate planet to the top of the form

                        projectiles.Remove(m);
                        break;
                    }
                }
                if (turnRight)
                {
                    move = "right";
                    player.rotationAngle += 5;

                }
                if (turnLeft)
                {
                    move = "left";
                    player.rotationAngle -= 5;

                }
               
                if (player.y > (this.ClientSize.Height - player.height))
                {  
                    player.y = this.ClientSize.Height - player.height;
                }  
                if (player.x > (this.ClientSize.Width - player.width))
                {
                    player.x = this.ClientSize.Width - player.width;
                }   
                if (player.x < 0)
                {
                    player.x = 0;
                }
            }
            foreach (Opposition2 h in oppositions2)
            {


                foreach (Projectile m in projectiles)
                {
                    if (m.projectileRec.Y > (this.ClientSize.Height) || (m.projectileRec.Y < 0) || (m.projectileRec.X > this.ClientSize.Width) || (m.projectileRec.X < 0))
                    {
                        projectiles.Remove(m);
                        break;
                    }
                    if (h.opposition2Rec.IntersectsWith(m.projectileRec))
                    {
                        h.x = 520;// relocate planet to the top of the form

                        projectiles.Remove(m);
                        break;
                    }
                }
               
            }
            this.Invalidate();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrShoot.Enabled = true;
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrShoot.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrShoot.Enabled = false;
            Application.Exit();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            g = e.Graphics;

            player.drawPlayer(g);


            foreach (Projectile m in projectiles)
            {
                m.drawProjectile(g);
                m.moveProjectile(g);
            }
            foreach (Opposition p in oppositions)
            {
                p.Draw(g);//Draw the planet
                p.MoveOpposition(g);//move the planet



                //if the planet reaches the bottom of the form relocate it back to the top
                if (p.x >= ClientSize.Width)
                {
                    p.x = -20;
                }
            }
            foreach (Opposition2 p in oppositions2)
            {
                p.Draw(g);//Draw the planet
                p.MoveOpposition2(g);//move the planet



                //if the planet reaches the bottom of the form relocate it back to the top
                if (p.x <= (ClientSize.Width - p.x)) 
                {
                    p.x = 500;
                    //its not the number I already tried a bunch of numbers but it doesn't work :/? But it has to be the number it works when i put it backwards.
                }

                //if (p.x <= (ClientSize.Width - p.x)) <--- this makes it to the centreline and then stops. 
            }
        }

       
    }

}
