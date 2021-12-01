using System;
using System.Collections.Generic;

namespace NordCloudLinkStation.Classes
{
    public class Device : Point
    { 
        public Device(Point p)
        {
            this.X = p.X;
            this.Y = p.Y; 
        }

        public string DisplayStationViability(LinkStation bestStation, double bestPower)
        {
            double truncatedPower = Math.Truncate(bestStation.Power * 100) / 100;

            if (bestPower > 0)
                return "Best link station for device at point " + this.ToString() + " is LinkStation" + bestStation.Name + " at point " + bestStation.ToString() + " with a power of " + String.Format("{0:0.00}", truncatedPower) + ".\n\n";
            else
                return "No link station within the proximity for device at point " + this.ToString() + ".\n\n";
        }

        public string GetBestLinkStationByPower(List<LinkStation> linkStations)
        {
            double bestPower = 0;
            LinkStation bestStation = linkStations[0];

            foreach (LinkStation ls in linkStations)
            {
                double power = ls.GetPowerForGivenPoint(this);
                if (power > bestPower)
                {
                    bestStation = ls;
                    bestPower = power;
                }
            }

            return DisplayStationViability(bestStation, bestPower);
        }
    }
}