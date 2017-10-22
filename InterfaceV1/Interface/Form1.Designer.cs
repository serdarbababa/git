namespace Interface
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
            this.btnTrain = new System.Windows.Forms.Button();
            this.txtInputCount = new System.Windows.Forms.TextBox();
            this.btnGenerateNetwork = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHiddenCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOutputCount = new System.Windows.Forms.TextBox();
            this.rbIHFullyConnected = new System.Windows.Forms.RadioButton();
            this.rbIHProbability = new System.Windows.Forms.RadioButton();
            this.gbxInputHidden = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rbHOFullyConnected = new System.Windows.Forms.RadioButton();
            this.rbHOProbability = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUnitNeuronTest = new System.Windows.Forms.Button();
            this.btnNetTest1 = new System.Windows.Forms.Button();
            this.gbxInputHidden.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(790, 12);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(109, 23);
            this.btnTrain.TabIndex = 0;
            this.btnTrain.Text = "generate data test";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtInputCount
            // 
            this.txtInputCount.Location = new System.Drawing.Point(110, 24);
            this.txtInputCount.Name = "txtInputCount";
            this.txtInputCount.Size = new System.Drawing.Size(32, 20);
            this.txtInputCount.TabIndex = 1;
            this.txtInputCount.Text = "15";
            // 
            // btnGenerateNetwork
            // 
            this.btnGenerateNetwork.Location = new System.Drawing.Point(547, 129);
            this.btnGenerateNetwork.Name = "btnGenerateNetwork";
            this.btnGenerateNetwork.Size = new System.Drawing.Size(107, 23);
            this.btnGenerateNetwork.TabIndex = 2;
            this.btnGenerateNetwork.Text = "Generate Network";
            this.btnGenerateNetwork.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input Nodes #";
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOutput.Location = new System.Drawing.Point(16, 225);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(725, 364);
            this.txtOutput.TabIndex = 4;
            this.txtOutput.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hidden Nodes #";
            // 
            // txtHiddenCount
            // 
            this.txtHiddenCount.Location = new System.Drawing.Point(110, 53);
            this.txtHiddenCount.Name = "txtHiddenCount";
            this.txtHiddenCount.Size = new System.Drawing.Size(32, 20);
            this.txtHiddenCount.TabIndex = 5;
            this.txtHiddenCount.Text = "15";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Output Nodes #";
            // 
            // txtOutputCount
            // 
            this.txtOutputCount.Location = new System.Drawing.Point(110, 80);
            this.txtOutputCount.Name = "txtOutputCount";
            this.txtOutputCount.Size = new System.Drawing.Size(32, 20);
            this.txtOutputCount.TabIndex = 7;
            this.txtOutputCount.Text = "15";
            // 
            // rbIHFullyConnected
            // 
            this.rbIHFullyConnected.AutoSize = true;
            this.rbIHFullyConnected.Checked = true;
            this.rbIHFullyConnected.Location = new System.Drawing.Point(23, 26);
            this.rbIHFullyConnected.Name = "rbIHFullyConnected";
            this.rbIHFullyConnected.Size = new System.Drawing.Size(101, 17);
            this.rbIHFullyConnected.TabIndex = 9;
            this.rbIHFullyConnected.TabStop = true;
            this.rbIHFullyConnected.Text = "Fully Connected";
            this.rbIHFullyConnected.UseVisualStyleBackColor = true;
            // 
            // rbIHProbability
            // 
            this.rbIHProbability.AutoSize = true;
            this.rbIHProbability.Location = new System.Drawing.Point(23, 49);
            this.rbIHProbability.Name = "rbIHProbability";
            this.rbIHProbability.Size = new System.Drawing.Size(97, 17);
            this.rbIHProbability.TabIndex = 10;
            this.rbIHProbability.Text = "With probability";
            this.rbIHProbability.UseVisualStyleBackColor = true;
            // 
            // gbxInputHidden
            // 
            this.gbxInputHidden.Controls.Add(this.label5);
            this.gbxInputHidden.Controls.Add(this.label4);
            this.gbxInputHidden.Controls.Add(this.textBox1);
            this.gbxInputHidden.Controls.Add(this.rbIHFullyConnected);
            this.gbxInputHidden.Controls.Add(this.rbIHProbability);
            this.gbxInputHidden.Location = new System.Drawing.Point(148, 18);
            this.gbxInputHidden.Name = "gbxInputHidden";
            this.gbxInputHidden.Size = new System.Drawing.Size(161, 105);
            this.gbxInputHidden.TabIndex = 11;
            this.gbxInputHidden.TabStop = false;
            this.gbxInputHidden.Text = "Input - Hidden Connectivity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(104, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Probability";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(34, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "50";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.rbHOFullyConnected);
            this.groupBox1.Controls.Add(this.rbHOProbability);
            this.groupBox1.Location = new System.Drawing.Point(315, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 105);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hidden - Output Connectivity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(104, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Probability";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(64, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(34, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "50";
            // 
            // rbHOFullyConnected
            // 
            this.rbHOFullyConnected.AutoSize = true;
            this.rbHOFullyConnected.Checked = true;
            this.rbHOFullyConnected.Location = new System.Drawing.Point(23, 26);
            this.rbHOFullyConnected.Name = "rbHOFullyConnected";
            this.rbHOFullyConnected.Size = new System.Drawing.Size(101, 17);
            this.rbHOFullyConnected.TabIndex = 9;
            this.rbHOFullyConnected.TabStop = true;
            this.rbHOFullyConnected.Text = "Fully Connected";
            this.rbHOFullyConnected.UseVisualStyleBackColor = true;
            // 
            // rbHOProbability
            // 
            this.rbHOProbability.AutoSize = true;
            this.rbHOProbability.Location = new System.Drawing.Point(23, 49);
            this.rbHOProbability.Name = "rbHOProbability";
            this.rbHOProbability.Size = new System.Drawing.Size(97, 17);
            this.rbHOProbability.TabIndex = 10;
            this.rbHOProbability.Text = "With probability";
            this.rbHOProbability.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Location = new System.Drawing.Point(482, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 105);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hidden - Hidden  Connectivity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(104, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Probability";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(64, 70);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(34, 20);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "0";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(23, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.Text = "Fully Connected";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(23, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(97, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "With probability";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gbxInputHidden);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnGenerateNetwork);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.txtOutputCount);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtHiddenCount);
            this.groupBox3.Controls.Add(this.txtInputCount);
            this.groupBox3.Location = new System.Drawing.Point(16, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(703, 194);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3 Layer Architecture";
            // 
            // btnUnitNeuronTest
            // 
            this.btnUnitNeuronTest.Location = new System.Drawing.Point(790, 39);
            this.btnUnitNeuronTest.Name = "btnUnitNeuronTest";
            this.btnUnitNeuronTest.Size = new System.Drawing.Size(100, 23);
            this.btnUnitNeuronTest.TabIndex = 17;
            this.btnUnitNeuronTest.Text = "Unit Neuron Test";
            this.btnUnitNeuronTest.UseVisualStyleBackColor = true;
            this.btnUnitNeuronTest.Click += new System.EventHandler(this.btnUnitNeuronTest_Click);
            // 
            // btnNetTest1
            // 
            this.btnNetTest1.Location = new System.Drawing.Point(790, 67);
            this.btnNetTest1.Name = "btnNetTest1";
            this.btnNetTest1.Size = new System.Drawing.Size(100, 23);
            this.btnNetTest1.TabIndex = 18;
            this.btnNetTest1.Text = "Simple Net Test";
            this.btnNetTest1.UseVisualStyleBackColor = true;
            this.btnNetTest1.Click += new System.EventHandler(this.btnNetTest1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 616);
            this.Controls.Add(this.btnNetTest1);
            this.Controls.Add(this.btnUnitNeuronTest);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnTrain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxInputHidden.ResumeLayout(false);
            this.gbxInputHidden.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.TextBox txtInputCount;
        private System.Windows.Forms.Button btnGenerateNetwork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHiddenCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOutputCount;
        private System.Windows.Forms.RadioButton rbIHFullyConnected;
        private System.Windows.Forms.RadioButton rbIHProbability;
        private System.Windows.Forms.GroupBox gbxInputHidden;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rbHOFullyConnected;
        private System.Windows.Forms.RadioButton rbHOProbability;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUnitNeuronTest;
        private System.Windows.Forms.Button btnNetTest1;
    }
}

