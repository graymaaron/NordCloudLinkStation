using System;
using System.Collections.Generic;

using NordCloudLinkStation.Classes;

namespace NordCloudLinkStation
{
    class Program
    {
        static void Main(string[] args)
        {
            string results = "";

            List <LinkStation> linkStations = new List<LinkStation>
            {
                new LinkStation(new Point(0, 0), 10, "001"),
                new LinkStation(new Point(20, 20), 5, "002"),
                new LinkStation(new Point(10, 0), 12, "003")
            };

            List<Device> devices = new List<Device>
            {
                new Device(new Point(0,0)),
                new Device(new Point(100,100)),
                new Device(new Point(15,10)),
                new Device(new Point(18,18))
            };

            foreach (Device d in devices)
                results += d.GetBestLinkStationByPower(linkStations);

            Console.WriteLine(results);
            Console.ReadKey();
        }
    }
}
