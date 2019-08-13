using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public static class RuleBase
    {
        public static void ApplyRules(ref double x1, ref double x2)
        {
            x1 = x1 >= 0.5 ? 1d : 0d;
            x2 = x2 >= 0.5 ? 1d : 0d;
        }

        public static string ApplyRules(double x)
        {
            x = x >= 0.5 ? 1d : 0d;

            if (x == 0)
            {
                return FactBase.Facts.FirstOrDefault(f => f.Number == 1).Value;
            }
            else if(x == 1)
            {
                return FactBase.Facts.FirstOrDefault(f => f.Number == 2).Value;
            }
            throw new Exception("Fact not found!");
        }

       
    }
}
