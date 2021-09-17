using CafetoTest.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafetoTest.Interfaces
{
    public interface IDestination
    {
        IEnumerable<Destination> Destinations();
    }
}
