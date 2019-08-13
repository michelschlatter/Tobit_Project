using InferenceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KS
{
    public partial class Form1 : Form
    {
        Inference inference;
        public Form1(Inference inference)
        {
            InitializeComponent();
            this.inference = inference;
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(chkBoxMagnet1PlusToTheRight.Checked);
            double x2 = Convert.ToDouble(chkBoxMagnet2PlusPointsToTheLeft.Checked);

            string result = inference.GetConclusion(x1, x2);
            txtBoxY.Text = result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chkBoxMagnet1PlusToTheRight_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxMagnet1PlusToTheRight.Checked)
            {
                lblM1.Text = "- / +";
            }
            else
            {
                lblM1.Text = "+ / -";
            }
        }

        private void chkBoxMagnet2PlusPointsToTheLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxMagnet2PlusPointsToTheLeft.Checked)
            {
                lblM2.Text = "+ / -";
            }
            else
            {
                lblM2.Text = "- / +";
            }
        }

        private void btnShowNeuralNetwork_Click(object sender, EventArgs e)
        {
            inference.ShowNeuralNetwork();
        }
    }
}
