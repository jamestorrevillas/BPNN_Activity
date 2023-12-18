namespace BPNN_Activity
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBx_InputA = new System.Windows.Forms.TextBox();
            this.txtBx_InputB = new System.Windows.Forms.TextBox();
            this.txtBx_InputC = new System.Windows.Forms.TextBox();
            this.txtBx_InputD = new System.Windows.Forms.TextBox();
            this.txtBx_OutputX = new System.Windows.Forms.TextBox();
            this.btn_TrainTheNeuralNet = new System.Windows.Forms.Button();
            this.btn_Test = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBx_InputA
            // 
            this.txtBx_InputA.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx_InputA.Location = new System.Drawing.Point(93, 157);
            this.txtBx_InputA.Name = "txtBx_InputA";
            this.txtBx_InputA.Size = new System.Drawing.Size(50, 45);
            this.txtBx_InputA.TabIndex = 7;
            // 
            // txtBx_InputB
            // 
            this.txtBx_InputB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx_InputB.Location = new System.Drawing.Point(149, 157);
            this.txtBx_InputB.Name = "txtBx_InputB";
            this.txtBx_InputB.Size = new System.Drawing.Size(50, 45);
            this.txtBx_InputB.TabIndex = 8;
            // 
            // txtBx_InputC
            // 
            this.txtBx_InputC.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx_InputC.Location = new System.Drawing.Point(205, 157);
            this.txtBx_InputC.Name = "txtBx_InputC";
            this.txtBx_InputC.Size = new System.Drawing.Size(50, 45);
            this.txtBx_InputC.TabIndex = 9;
            // 
            // txtBx_InputD
            // 
            this.txtBx_InputD.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx_InputD.Location = new System.Drawing.Point(261, 157);
            this.txtBx_InputD.Name = "txtBx_InputD";
            this.txtBx_InputD.Size = new System.Drawing.Size(50, 45);
            this.txtBx_InputD.TabIndex = 10;
            // 
            // txtBx_OutputX
            // 
            this.txtBx_OutputX.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx_OutputX.Location = new System.Drawing.Point(390, 157);
            this.txtBx_OutputX.Name = "txtBx_OutputX";
            this.txtBx_OutputX.ReadOnly = true;
            this.txtBx_OutputX.Size = new System.Drawing.Size(102, 45);
            this.txtBx_OutputX.TabIndex = 11;
            // 
            // btn_TrainTheNeuralNet
            // 
            this.btn_TrainTheNeuralNet.Location = new System.Drawing.Point(177, 359);
            this.btn_TrainTheNeuralNet.Name = "btn_TrainTheNeuralNet";
            this.btn_TrainTheNeuralNet.Size = new System.Drawing.Size(108, 62);
            this.btn_TrainTheNeuralNet.TabIndex = 14;
            this.btn_TrainTheNeuralNet.Text = "Train the Neural Network";
            this.btn_TrainTheNeuralNet.UseVisualStyleBackColor = true;
            this.btn_TrainTheNeuralNet.Click += new System.EventHandler(this.btn_TrainTheNeuralNet_Click);
            // 
            // btn_Test
            // 
            this.btn_Test.Location = new System.Drawing.Point(291, 359);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(108, 62);
            this.btn_Test.TabIndex = 15;
            this.btn_Test.Text = "Test";
            this.btn_Test.UseVisualStyleBackColor = true;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "INPUTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "OUTPUT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "OPERATIONS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 494);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Test);
            this.Controls.Add(this.btn_TrainTheNeuralNet);
            this.Controls.Add(this.txtBx_OutputX);
            this.Controls.Add(this.txtBx_InputD);
            this.Controls.Add(this.txtBx_InputC);
            this.Controls.Add(this.txtBx_InputB);
            this.Controls.Add(this.txtBx_InputA);
            this.Name = "Form1";
            this.Text = "BackPropagation Neural Network (BPNN) ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBx_InputA;
        private System.Windows.Forms.TextBox txtBx_InputB;
        private System.Windows.Forms.TextBox txtBx_InputC;
        private System.Windows.Forms.TextBox txtBx_InputD;
        private System.Windows.Forms.TextBox txtBx_OutputX;
        private System.Windows.Forms.Button btn_TrainTheNeuralNet;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

