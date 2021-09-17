using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafetoTest.MessageTypes
{
    public abstract class BaseMessage
    {
        public string Message { get; set; }
        public BaseMessage(string message)
        {
            this.Message = message;
        }

        public abstract void FormatMessage();
    }
}
