using DatabaseLayer;
using NeuralNetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InferenceLayer
{
    public class Inference
    {

        BasicNeuralNetwork net;

        public void LoadNeuralNetwork(string trainedNeuralNetworkPath)
        {
            net = BasicNeuralNetwork.Load(trainedNeuralNetworkPath);
        }

        public void TrainNeuralNetwork(Action<int, double> callback)
        {
            if (net == null)
            {
                throw new Exception("Load / create the Neural Network Neural Network before calling this method!");
            }

            net.Train(XorDataset.xOrInput, XorDataset.xOrLabels, learningRate: 0.2, minError: 0.005, callback: callback);
        }

        public void CreateNeuralNetworkArchitecture()
        {
            net = new BasicNeuralNetwork();
            net.AddLayer(new Layer(2));
            net.AddLayer(new Layer(4, new Tanh(), true));
            net.AddLayer(new Layer(1, new Sigmoid(), false));
        }

        public string GetConclusion(double x1, double x2)
        {
            return Infer(x1, x2);
        }

        public string GetPrediction(Action<int, double> callback, double x1, double x2)
        {
            return Infer(x1, x2);
        }

        public void ShowNeuralNetwork()
        {
            if(net != null)
            {
                net.Visualize();
            }
            else
            {
                throw new Exception("Neural Network does not exists! Nothing to visualize!");
            }
        }

  

        private string Infer(double x1, double x2)
        {
            RuleBase.ApplyRules(ref x1, ref x2);
            CheckNnIsLoaded();

            // predict / aproximate with neural network
            double output = net.Calculate(new double[] { x1, x2 })[0];

            string conclusion = RuleBase.ApplyRules(output);

            return conclusion;
        }

        private void CheckNnIsLoaded()
        {
            if (net == null)
            {
                throw new Exception("Load the Neural Network or create and then train it before calling this method!");
            }
        }
    }
}
