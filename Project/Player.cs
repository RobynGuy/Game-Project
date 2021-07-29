using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace Project
{
    class Player
    {
        // declare fields to use in the class

        public int x, y, width, height;//variables for the rectangle
        public Image player;//variable for the planet's image

        public Rectangle playerRec;//variable for a rectangle to place our image in

        public int rotationAngle;
        public Matrix matrix;
        Point centre;

        //Create a constructor (initialises the values of the fields)
        public Player()
        {
            x = 250;
            y = 200;
            width = 70;
            height = 80;
            rotationAngle = 0;
            player = Properties.Resources.hose;
            playerRec = new Rectangle(x, y, width, height);
        }
        //methods
        public void drawPlayer(Graphics g)
        {
            //find the centre point of spaceRec
            centre = new Point(playerRec.X + width / 2, playerRec.Y + width / 2);
            //instantiate a Matrix object called matrix
            matrix = new Matrix();
            //rotate the matrix (spaceRec) about its centre
            matrix.RotateAt(rotationAngle, centre);
            //Set the current draw location to the rotated matrix point
            g.Transform = matrix;
            //draw the spaceship

            g.DrawImage(player, playerRec);
        }

        public void movePlayer(int mouseX, int mouseY)
        {
           


        }

    }
}
