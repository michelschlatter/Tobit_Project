using InferenceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KS
{
    public partial class NeuralNetworkLoader : Form
    {

        bool trainingIsRunning = false;

        public NeuralNetworkLoader()
        {
            InitializeComponent();
        }

        public void WriteToOutput(int iteration, double error)
        {
            string text = $"iteration: {iteration} error: {error}";
            if (txtBoxTrainingOutput.InvokeRequired)
            {
                txtBoxTrainingOutput.Invoke(new Action(() => 
                {
                    txtBoxTrainingOutput.Text += text + Environment.NewLine;
                    txtBoxTrainingOutput.SelectionStart = txtBoxTrainingOutput.TextLength;
                    txtBoxTrainingOutput.ScrollToCaret();
                }));
            }
            else
            {
                txtBoxTrainingOutput.Text += text + Environment.NewLine;
                txtBoxTrainingOutput.SelectionStart = txtBoxTrainingOutput.TextLength;
                txtBoxTrainingOutput.ScrollToCaret();
            }
        }

        private void TrainNn_Click(object sender, EventArgs e)
        {
            if (trainingIsRunning) return;

            Inference inference = new Inference();
            inference.CreateNeuralNetworkArchitecture();
            Thread thread = new Thread(() => 
            {
                trainingIsRunning = true;
                inference.TrainNeuralNetwork(WriteToOutput);
              
                BeginInvoke(new Action(() => 
                {
                    new Form1(inference).Show();
                    Hide();
                    trainingIsRunning = false;
                }));
               
             });
            thread.Start();
        }

        private void LoadNn_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                txtBoxNnPath.Text = dlg.FileName;
                if(Path.GetExtension(dlg.FileName) == ".json")
                {
                    Inference inference = new Inference();
                    inference.LoadNeuralNetwork(dlg.FileName);
                    Form1 f1 = new Form1(inference);
                    Hide();
                    f1.Show();
                }
                else
                {
                    MessageBox.Show("File has to be a .json file");
                }
            }
          
        }

        private void btnSkipTraining_Click(object sender, EventArgs e)
        {
            Inference inference = new Inference();
            inference.CreateNeuralNetworkArchitecture();
            new Form1(inference).Show();
            Hide();
        }
    }
}
