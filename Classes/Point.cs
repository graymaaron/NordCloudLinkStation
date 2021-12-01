using System;

namespace NordCloudLinkStation.Classes
{
    public class Point
    {
        private int x;
        private int y;

        public Point()
        {

        }

        public Point(int xIn, int yIn)
        {
            x = xIn;
            y = yIn;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public double GetDistanceBetweenTwoPoints(Point other)
        {
            return Math.Sqrt((Math.Pow(this.X - other.x, 2) + Math.Pow(this.y - other.y, 2)));
        }

        public override string ToString()
        {
            return "{ " + this.X + " }, { " + this.Y + " }";
        }
    }
}