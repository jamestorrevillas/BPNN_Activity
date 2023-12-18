using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;

namespace BPNN_Activity
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        public Form1()
        {
            InitializeComponent();
            nn = new NeuralNet(4, 4, 1);
        }

        private void btn_TrainTheNeuralNet_Click(object sender, EventArgs e)
        {

            if (!isValidInputs())
                return;

            /* 2 inputs OR GATE
            for (int i = 0; i < 100; i++)
            {
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();
            }*/

            // 4 inputs AND GATE ver 1.0 ~ verbose code
            /*for (int epoch = 0; epoch < 1000; epoch++)
            {
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();
            }*/

            // 4 inputs AND GATE ver 2.0 ~ minimalistic code
            for (int epoch = 0; epoch < 70; epoch++) 
            {
                for (int i = 0; i < 16; i++)
                {
                    double[] inputs = new double[4];
                    for (int j = 0; j < 4; j++)
                    {
                        inputs[j] = (i >> j) & 1;
                    }
                    double desiredOutput = inputs.All(x => x == 1) ? 1.0 : 0.0;
                    for (int k = 0; k < 4; k++)
                    {
                        nn.setInputs(k, inputs[k]);
                    }
                    nn.setDesiredOutput(0, desiredOutput);
                    nn.learn();
                }
            }
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            if (!isValidInputs())
                return;
            
            nn.setInputs(0, Convert.ToDouble(txtBx_InputA.Text));
            nn.setInputs(1, Convert.ToDouble(txtBx_InputB.Text));
            nn.setInputs(2, Convert.ToDouble(txtBx_InputC.Text));
            nn.setInputs(3, Convert.ToDouble(txtBx_InputD.Text));
            nn.run();
            txtBx_OutputX.Text = nn.getOutputData(0).ToString("F3");
        }

        private bool isValidInputs()
        {
            if ((txtBx_InputA.Text == "0" || txtBx_InputA.Text == "1") &&
                (txtBx_InputB.Text == "0" || txtBx_InputB.Text == "1") &&
                (txtBx_InputC.Text == "0" || txtBx_InputC.Text == "1") &&
                (txtBx_InputD.Text == "0" || txtBx_InputD.Text == "1"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Missing or Invalid Input: Please ensure all four inputs are either 0 or 1.");
                return false;
            }
        }
    }
}
