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
        


        int score, lives;

        

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
               
            }
            for (int i = 0; i < 2; i++)
            {
                int displacement = 90 + (i * 170);
                
                oppositions2.Add(new Opposition2(displacement));
                

            }

        }



        public string _textBox
        {
            set { LblName.Text = value; }
        }

        

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
            if (e.KeyData == Keys.A) { turnLeft = true; }
            if (e.KeyData == Keys.D) { turnRight = true; }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A) { turnLeft = false; }
            if (e.KeyData == Keys.D) { turnRight = false; }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lives = 10;
            LblLives.Text = lives.ToString();
            score = 0;
            LblScore.Text = score.ToString();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                projectiles.Add(new Projectile(player.playerRec, player.rotationAngle));
                //get this to change the image
               
            }
        }



        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                projectiles.Add(new Projectile(player.playerRec, player.rotationAngle));
               
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
         
            AutoClosingMessageBox.Show("Waiting", "wait...", 3000);
            tmrShoot.Enabled = true;
            tmrScore.Enabled = true;
            score = 0;
            LblScore.Text = score.ToString();

            foreach (Opposition p in oppositions)
            {
                p.x = -40;
            }

            foreach (Opposition2 h in oppositions2)
            {
                h.x = 540;
            }

            // pass lives from LblLives Text property to lives variable

        }


        private void tmrShoot_Tick(object sender, EventArgs e)
        {



            foreach (Opposition p in oppositions)
            {

                if (player.playerRec.IntersectsWith(p.oppositionRec))
                {
                    //reset planet[i] back to top of panel
                    p.x = -40; // set  y value of planetRec
                    lives -= 1;// lose a life
                    LblLives.Text = lives.ToString();// display number of lives
                    CheckLives();
                }

                foreach (Projectile m in projectiles)
                {
                    if (m.projectileRec.Y > (this.ClientSize.Height) || (m.projectileRec.Y < 0) || (m.projectileRec.X > this.ClientSize.Width) || (m.projectileRec.X < 0))
                    {
                      

                        projectiles.Remove(m);
                        break;
                    }

                    if (p.oppositionRec.IntersectsWith(m.projectileRec))
                    {
                       
                        p.x = -40;// relocate planet to the top of the form

                        projectiles.Remove(m);
                        break;
                    }
                }
                
            }
            if (turnRight)
            {
                move = "right";
                player.rotationAngle += 10;

            }
            if (turnLeft)
            {
                move = "left";
                player.rotationAngle -= 10; 

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
            foreach (Opposition2 h in oppositions2)
            {

                if (player.playerRec.IntersectsWith(h.opposition2Rec))
                {
                    //reset planet[i] back to top of panel
                    h.x = 540; // set  y value of planetRec
                    lives -= 1;// lose a life
                    LblLives.Text = lives.ToString();// display number of lives
                    CheckLives();
                }

                foreach (Projectile m in projectiles)
                {
                    if (m.projectileRec.Y > (this.ClientSize.Height) || (m.projectileRec.Y < 0) || (m.projectileRec.X > this.ClientSize.Width) || (m.projectileRec.X < 0))
                    {

                        
                        projectiles.Remove(m);
                        break;
                    }
                    if (h.opposition2Rec.IntersectsWith(m.projectileRec))
                    {
                        h.x = 540;// relocate planet to the top of the form
                      
                        projectiles.Remove(m);
                        break;
                    }
                }
               
            }
            this.Invalidate();
        }


        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lives = 10;
            
            tmrShoot.Enabled = false;
            tmrScore.Enabled = false;

            foreach (Opposition p in oppositions)
            {
                p.x = -40;
            }

                foreach (Opposition2 h in oppositions2)
            {
                h.x = 540;
            }
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

        private void LblScore_Click(object sender, EventArgs e)
        {

        }

        private void LblName_Click(object sender, EventArgs e)
        {

        }

        private void LblName_MouseMove(object sender, MouseEventArgs e)
        {
          
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            g = e.Graphics;
            for (int i = 0; i < 7; i++)
            {
                // generate a random number from 5 to 20 and put it in rndmspeed

                //find the centre point of spaceRec
             

                //call the Planet class's drawPlanet method to draw the images


                player.drawPlayer(g);
            }

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
                    p.x = -40;
                }
            }
            foreach (Opposition2 p in oppositions2)
            {
                p.Draw(g);//Draw the planet
                p.MoveOpposition2(g);//move the planet



                //if the planet reaches the bottom of the form relocate it back to the top
                if (p.x <= 0) 
                {
                    p.x = 540;
                    //its not the number I already tried a bunch of numbers but it doesn't work :/? But it has to be the number it works when i put it backwards.
                }

                //if (p.x <= (ClientSize.Width - p.x)) <--- this makes it to the centreline and then stops. 
            }
        }

        private void endlessToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void tmrScore_Tick(object sender, EventArgs e)
        {
            foreach (Opposition p in oppositions)
            {

                foreach (Projectile m in projectiles)
                {
                  
                    if (p.oppositionRec.IntersectsWith(m.projectileRec))
                    {
                        score += 1;//update the score
                        LblScore.Text = score.ToString();
                        CheckScore();
                    }
                }

            }
         
            foreach (Opposition2 h in oppositions2)
            {
                foreach (Projectile m in projectiles)
                {
                   
                    if (h.opposition2Rec.IntersectsWith(m.projectileRec))
                    {
                       
                        score += 1;//update the score
                        LblScore.Text = score.ToString();
                        CheckScore();
                       
                    }
                }

            }
            this.Invalidate();
        }

        private void selectDifficultyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lives = 10;
            LblLives.Text = lives.ToString();
            LblDifficulty.Text = "Easy"; LblDifficulty.Refresh();

        }

        private void mnuDifficultyMedium_Click(object sender, EventArgs e)
        {
            lives = 5;
            LblLives.Text = lives.ToString();
            LblDifficulty.Text = "Medium"; LblDifficulty.Refresh();
           
        }

        private void mnuDifficultyHard_Click(object sender, EventArgs e)
        {
            lives = 1;
            LblLives.Text = lives.ToString();
            LblDifficulty.Text = "Hard"; LblDifficulty.Refresh();

        }

        private void CheckLives()
        {
            if (lives == 0)
            {
                
                tmrShoot.Enabled = false;
                tmrScore.Enabled = false;
                Form3 frm = new Form3();
                frm.Show();
                this.Hide();
                //change messagebox to a game over screen? with restart and 
                //close button

            }
        }


        private void CheckScore()
        {
            if (score == 300)
            {
                tmrShoot.Enabled = false;
                tmrScore.Enabled = false;
                Form4 frm = new Form4();
                frm.Show();
                this.Hide();
                //Switch to a win screen later??
            }
        }
    }



}
