using CafetoTest.Enums;
using CafetoTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafetoTest.LoggerTypes
{
    public class ConsoleLogger : IWrite
    {
        public void writeMessage(string message, MessageType messageType)
        {
            switch (messageType)
            {
                case MessageType.Info:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case MessageType.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case MessageType.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    break;
            }
            Console.WriteLine(string.Format("{0} {1}", DateTime.Now.ToShortDateString(), message));
        }
    }
}
