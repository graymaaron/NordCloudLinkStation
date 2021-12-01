using System;

namespace NordCloudLinkStation.Classes
{
    public class LinkStation : Point
    {
        private string name;

        private double power;
        private double proximity;
                
        public LinkStation(Point p, double proximity, string name)
        {
            this.X = p.X;
            this.Y = p.Y;

            this.proximity = proximity;
            this.name = name;
        }

        public double Power
        {
            get { return power; }
            set { power = value; }
        }

        public double Proximity
        {
            get { return proximity; }
            set { proximity = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double GetPowerForGivenPoint(Point device)
        {
            double distance = this.GetDistanceBetweenTwoPoints(device);
            power = distance < this.proximity ? Math.Pow((proximity - distance), 2) : 0;

            return power;
        }
    }
}