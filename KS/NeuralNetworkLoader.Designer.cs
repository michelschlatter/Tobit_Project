namespace KS
{
    partial class NeuralNetworkLoader
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
            this.txtBoxNnPath = new System.Windows.Forms.TextBox();
            this.LoadNn = new System.Windows.Forms.Button();
            this.TrainNn = new System.Windows.Forms.Button();
            this.txtBoxTrainingOutput = new System.Windows.Forms.TextBox();
            this.btnSkipTraining = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxNnPath
            // 
            this.txtBoxNnPath.Location = new System.Drawing.Point(12, 337);
            this.txtBoxNnPath.Name = "txtBoxNnPath";
            this.txtBoxNnPath.Size = new System.Drawing.Size(214, 22);
            this.txtBoxNnPath.TabIndex = 0;
            this.txtBoxNnPath.Visible = false;
            // 
            // LoadNn
            // 
            this.LoadNn.Location = new System.Drawing.Point(241, 327);
            this.LoadNn.Name = "LoadNn";
            this.LoadNn.Size = new System.Drawing.Size(150, 43);
            this.LoadNn.TabIndex = 1;
            this.LoadNn.Text = "Load Neural Network ";
            this.LoadNn.UseVisualStyleBackColor = true;
            this.LoadNn.Visible = false;
            this.LoadNn.Click += new System.EventHandler(this.LoadNn_Click);
            // 
            // TrainNn
            // 
            this.TrainNn.Location = new System.Drawing.Point(15, 12);
            this.TrainNn.Name = "TrainNn";
            this.TrainNn.Size = new System.Drawing.Size(179, 55);
            this.TrainNn.TabIndex = 2;
            this.TrainNn.Text = "Train Neural Network";
            this.TrainNn.UseVisualStyleBackColor = true;
            this.TrainNn.Click += new System.EventHandler(this.TrainNn_Click);
            // 
            // txtBoxTrainingOutput
            // 
            this.txtBoxTrainingOutput.Location = new System.Drawing.Point(15, 87);
            this.txtBoxTrainingOutput.Multiline = true;
            this.txtBoxTrainingOutput.Name = "txtBoxTrainingOutput";
            this.txtBoxTrainingOutput.Size = new System.Drawing.Size(379, 205);
            this.txtBoxTrainingOutput.TabIndex = 3;
            // 
            // btnSkipTraining
            // 
            this.btnSkipTraining.Location = new System.Drawing.Point(215, 12);
            this.btnSkipTraining.Name = "btnSkipTraining";
            this.btnSkipTraining.Size = new System.Drawing.Size(179, 55);
            this.btnSkipTraining.TabIndex = 4;
            this.btnSkipTraining.Text = "Skip Training";
            this.btnSkipTraining.UseVisualStyleBackColor = true;
            this.btnSkipTraining.Click += new System.EventHandler(this.btnSkipTraining_Click);
            // 
            // NeuralNetworkLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 313);
            this.Controls.Add(this.btnSkipTraining);
            this.Controls.Add(this.txtBoxTrainingOutput);
            this.Controls.Add(this.TrainNn);
            this.Controls.Add(this.LoadNn);
            this.Controls.Add(this.txtBoxNnPath);
            this.Name = "NeuralNetworkLoader";
            this.Text = "Neural Network Trainer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNnPath;
        private System.Windows.Forms.Button LoadNn;
        private System.Windows.Forms.Button TrainNn;
        private System.Windows.Forms.TextBox txtBoxTrainingOutput;
        private System.Windows.Forms.Button btnSkipTraining;
    }
}