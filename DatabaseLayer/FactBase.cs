using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    internal static class FactBase
    {

        internal static List<Fact> Facts = new List<Fact>()
        {
            new Fact() { Value = "The magnets attract each other.", Number = 2 },
            new Fact() { Value = "The magnets repel each other.", Number = 1 },
        };
    }
}
