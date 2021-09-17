using CafetoTest.Enums;
using CafetoTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafetoTest
{
    public class DestinationAppSettings : IDestination
    {
        public  IEnumerable<Destination> Destinations()
        {
            List<Destination> messageDestinations = new List<Destination>();
            string[] destinations = ConfigurationManager.AppSettings["destinations"].Split(';');

            foreach (string destination in destinations)
            {

                messageDestinations.Add((Destination)Enum.Parse(typeof(Destination), destination));
            }
            return messageDestinations;
        }
    }
}
