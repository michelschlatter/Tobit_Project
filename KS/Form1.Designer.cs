namespace KS
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPredict = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxY = new System.Windows.Forms.TextBox();
            this.chkBoxMagnet1PlusToTheRight = new System.Windows.Forms.CheckBox();
            this.chkBoxMagnet2PlusPointsToTheLeft = new System.Windows.Forms.CheckBox();
            this.lblM1 = new System.Windows.Forms.Label();
            this.lblM2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowNeuralNetwork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(21, 170);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(116, 42);
            this.btnPredict.TabIndex = 2;
            this.btnPredict.Text = "Conclude";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Conclusion:";
            // 
            // txtBoxY
            // 
            this.txtBoxY.Location = new System.Drawing.Point(21, 263);
            this.txtBoxY.Multiline = true;
            this.txtBoxY.Name = "txtBoxY";
            this.txtBoxY.ReadOnly = true;
            this.txtBoxY.Size = new System.Drawing.Size(275, 22);
            this.txtBoxY.TabIndex = 7;
            // 
            // chkBoxMagnet1PlusToTheRight
            // 
            this.chkBoxMagnet1PlusToTheRight.AutoSize = true;
            this.chkBoxMagnet1PlusToTheRight.Location = new System.Drawing.Point(21, 25);
            this.chkBoxMagnet1PlusToTheRight.Name = "chkBoxMagnet1PlusToTheRight";
            this.chkBoxMagnet1PlusToTheRight.Size = new System.Drawing.Size(275, 21);
            this.chkBoxMagnet1PlusToTheRight.TabIndex = 9;
            this.chkBoxMagnet1PlusToTheRight.Text = "Magnet 1: Plus- Pool points to the right";
            this.chkBoxMagnet1PlusToTheRight.UseVisualStyleBackColor = true;
            this.chkBoxMagnet1PlusToTheRight.CheckedChanged += new System.EventHandler(this.chkBoxMagnet1PlusToTheRight_CheckedChanged);
            // 
            // chkBoxMagnet2PlusPointsToTheLeft
            // 
            this.chkBoxMagnet2PlusPointsToTheLeft.AutoSize = true;
            this.chkBoxMagnet2PlusPointsToTheLeft.Location = new System.Drawing.Point(21, 66);
            this.chkBoxMagnet2PlusPointsToTheLeft.Name = "chkBoxMagnet2PlusPointsToTheLeft";
            this.chkBoxMagnet2PlusPointsToTheLeft.Size = new System.Drawing.Size(266, 21);
            this.chkBoxMagnet2PlusPointsToTheLeft.TabIndex = 10;
            this.chkBoxMagnet2PlusPointsToTheLeft.Text = "Magnet 2: Plus- Pool points to the left";
            this.chkBoxMagnet2PlusPointsToTheLeft.UseVisualStyleBackColor = true;
            this.chkBoxMagnet2PlusPointsToTheLeft.CheckedChanged += new System.EventHandler(this.chkBoxMagnet2PlusPointsToTheLeft_CheckedChanged);
            // 
            // lblM1
            // 
            this.lblM1.AutoSize = true;
            this.lblM1.Location = new System.Drawing.Point(23, 129);
            this.lblM1.Name = "lblM1";
            this.lblM1.Size = new System.Drawing.Size(33, 17);
            this.lblM1.TabIndex = 11;
            this.lblM1.Text = "+ / -";
            // 
            // lblM2
            // 
            this.lblM2.AutoSize = true;
            this.lblM2.Location = new System.Drawing.Point(110, 129);
            this.lblM2.Name = "lblM2";
            this.lblM2.Size = new System.Drawing.Size(33, 17);
            this.lblM2.TabIndex = 12;
            this.lblM2.Text = "- / +";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "M1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "M2";
            // 
            // btnShowNeuralNetwork
            // 
            this.btnShowNeuralNetwork.Location = new System.Drawing.Point(113, 303);
            this.btnShowNeuralNetwork.Name = "btnShowNeuralNetwork";
            this.btnShowNeuralNetwork.Size = new System.Drawing.Size(183, 27);
            this.btnShowNeuralNetwork.TabIndex = 15;
            this.btnShowNeuralNetwork.Text = "Show Neural Network";
            this.btnShowNeuralNetwork.UseVisualStyleBackColor = true;
            this.btnShowNeuralNetwork.Click += new System.EventHandler(this.btnShowNeuralNetwork_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 344);
            this.Controls.Add(this.btnShowNeuralNetwork);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblM2);
            this.Controls.Add(this.lblM1);
            this.Controls.Add(this.chkBoxMagnet2PlusPointsToTheLeft);
            this.Controls.Add(this.chkBoxMagnet1PlusToTheRight);
            this.Controls.Add(this.txtBoxY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPredict);
            this.Name = "Form1";
            this.Text = "Magnet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxY;
        private System.Windows.Forms.CheckBox chkBoxMagnet1PlusToTheRight;
        private System.Windows.Forms.CheckBox chkBoxMagnet2PlusPointsToTheLeft;
        private System.Windows.Forms.Label lblM1;
        private System.Windows.Forms.Label lblM2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowNeuralNetwork;
    }
}

