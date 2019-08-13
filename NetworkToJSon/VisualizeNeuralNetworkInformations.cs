using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkToJSon
{
    public class VisualizeNeuralNetworkInformations
    {
        public VisualizeNeuralNetworkInformations()
        {
            Hidden = new List<VisualizeLayerInformations>();
        }

        public VisualizeLayerInformations Input { get; set; }
        public List<VisualizeLayerInformations> Hidden { get; set; }
        public VisualizeLayerInformations Output { get; set; }

        public List<double> Weights { get; set; }
    }
}
