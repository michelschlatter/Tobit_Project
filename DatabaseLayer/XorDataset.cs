using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class XorDataset
    {
        public static List<double[]> xOrInput = new List<double[]>()
            {
                new double[2] { 0,1},
                new double[2] { 0,0},
                new double[2] { 1,1},
                new double[2] { 1,0},
            };

       public static List<double[]> xOrLabels = new List<double[]>()
            {
                new double[1] { 1},
                new double[1] { 0},
                new double[1] { 0},
                new double[1] { 1},
            };
    }
}
