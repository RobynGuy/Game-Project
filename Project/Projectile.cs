using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace Project
{
   public partial class Projectile
    {

        public int x, y, width, height;
        public int projectileRotated;
        public double xSpeed, ySpeed;
      
        public Image projectile;//variable for the missile's image
        public Rectangle projectileRec;//variable for a rectangle to place our image in
        public Matrix matrixProjectile;//matrix to enable us to rotate missile in the same angle as the spaceship
        Point centreProjectile;//centre of missile
        // in the following constructor we pass in the values of spaceRec and the rotation angle of the spaceship
        // this gives us the position of the spaceship which we can then use to place the
        // missile where the spaceship is located and at the correct angle
        public Projectile(Rectangle playerRec, int projectileRotate)
        {
            width = 50;
            height = 50;
            projectile = Properties.Resources.rubbish;
            projectileRec = new Rectangle(x, y, width, height);
            //this code works out the speed of the missile to be used in the moveMissile method
            xSpeed = 30* (Math.Cos((projectileRotate - 90) * Math.PI / 180));
            ySpeed = 30 * (Math.Sin((projectileRotate + 90) * Math.PI / 180));
            //calculate x,y to move missile to middle of spaceship in drawMissile method
            x = playerRec.X + playerRec.Width / 2;
            y = playerRec.Y + playerRec.Height / 2;
            //pass missileRotate angle to missileRotated so that it can be used in the drawMissile method
            projectileRotated = projectileRotate;

        }

        public void drawProjectile(Graphics g)
        {

            
            //centre missile 
            centreProjectile = new Point(x, y);
            //instantiate a Matrix object called matrixMissile
            matrixProjectile = new Matrix();
            //rotate the matrix (in this case missileRec) about its centre
            matrixProjectile.RotateAt(projectileRotated, centreProjectile);
            //Set the current draw location to the rotated matrix point i.e. where missileRec is now
            g.Transform = matrixProjectile;
            //Draw the missile
            g.DrawImage(projectile, projectileRec);

        }
        public void moveProjectile(Graphics g)
        {
            x += (int)xSpeed;//cast double to an integer value
            y -= (int)ySpeed;
            projectileRec.Location = new Point(x, y);//missiles new location

        }

    }
}
