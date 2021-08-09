using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Project
{
    class Opposition2
    {
        // declare fields to use in the class

        public int x, y, width, height; //variables for the rectangle
        public Image opposition2Image;//variable for the planet's image
        Random rand = new Random();
        public Matrix matrix;
        Point centre;



        public Rectangle opposition2Rec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Opposition2(int displacement)
        {
            x = 540;
            y = displacement;
            width = 100;
            height = 75;

            opposition2Image = Properties.Resources.opossum;
            opposition2Rec = new Rectangle(x, y, width, height);
        }


        // Methods for the Planet class
        public void Draw(Graphics g)
        {
            centre = new Point(opposition2Rec.X + width / 2, opposition2Rec.Y + width / 2);
            matrix = new Matrix();

            g.Transform = matrix;

            opposition2Rec = new Rectangle(x, y, width, height);
            g.DrawImage(opposition2Image, opposition2Rec);
        }

        public void MoveOpposition2(Graphics g)
        {
            x -= 5;
            opposition2Rec.Location = new Point(x, y);
        }

    }
}
