using CafetoTest.Enums;
using CafetoTest.Interfaces;
using CafetoTest.LoggerTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafetoTest
{
    public class StrategyMessage
    {
        private  IDestination DestinationConfig { get; set; }
        public StrategyMessage(IDestination destinationConfig)
        {
            this.DestinationConfig = destinationConfig;
        }

        public  void writeMessage(string message, MessageType messageType)
        {
            List<IWrite> destinations = GetDestinations(DestinationConfig);
            foreach (IWrite destiny in destinations)
            {
                destiny.writeMessage(message, messageType);
            }
        }


        private static List<IWrite> GetDestinations(IDestination destination)
        {
            List<IWrite> destinations = new List<IWrite>();
            IEnumerable<Destination> destinationsConfigured = destination.Destinations();

            foreach (Destination destinationItem in destinationsConfigured)
            {
                
                if (destinationItem == Destination.Console)
                {
                    destinations.Add((IWrite)Activator.CreateInstance(typeof(ConsoleLogger)));
                }

                if (destinationItem == Destination.File)
                {
                    destinations.Add((IWrite)Activator.CreateInstance(typeof(FileLogger)));
                }
            }


            return destinations;
        }
    }
}
