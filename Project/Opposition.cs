using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Project
{
    class Opposition
    {  // declare fields to use in the class

        public int x, y, width, height; //variables for the rectangle
        public Image oppositionImage;//variable for the planet's image
        Random rand = new Random();
        public Matrix matrix;
        Point centre;


        public Rectangle oppositionRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Opposition(int displacement)
        {
            x = displacement;
            y = 10;
            width = 40;
            height = 40;
            
            oppositionImage = Properties.Resources.Crow;
            oppositionRec = new Rectangle(x, y, width, height);
        }

        // Methods for the Planet class
        public void Draw(Graphics g)
        {
            centre = new Point(oppositionRec.X + width / 2, oppositionRec.Y + width / 2);
            matrix = new Matrix();
           
            g.Transform = matrix;

            oppositionRec = new Rectangle(x, y, width, height);
            g.DrawImage(oppositionImage, oppositionRec);
        }

        public void MoveOpposition(Graphics g)
        {
            y += 5;
            oppositionRec.Location = new Point(x, y);
        }
    }
}
