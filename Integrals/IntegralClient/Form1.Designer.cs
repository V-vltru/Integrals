namespace IntegralClient
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSteps = new System.Windows.Forms.TextBox();
            this.buttonAddSteps = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonRemoveStep = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxMethods = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBoxParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.labelResult);
            this.groupBoxParameters.Controls.Add(this.label4);
            this.groupBoxParameters.Controls.Add(this.comboBoxMethods);
            this.groupBoxParameters.Controls.Add(this.buttonCalculate);
            this.groupBoxParameters.Controls.Add(this.buttonRemoveStep);
            this.groupBoxParameters.Controls.Add(this.listBox1);
            this.groupBoxParameters.Controls.Add(this.buttonAddSteps);
            this.groupBoxParameters.Controls.Add(this.textBoxSteps);
            this.groupBoxParameters.Controls.Add(this.label3);
            this.groupBoxParameters.Controls.Add(this.label1);
            this.groupBoxParameters.Controls.Add(this.label2);
            this.groupBoxParameters.Controls.Add(this.textBoxB);
            this.groupBoxParameters.Controls.Add(this.textBoxA);
            this.groupBoxParameters.Location = new System.Drawing.Point(12, 12);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(329, 534);
            this.groupBoxParameters.TabIndex = 0;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Параметры интеграла";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(57, 22);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 1;
            this.textBoxA.Text = "1";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(57, 48);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 2;
            this.textBoxB.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Кол-во разбиений:";
            // 
            // textBoxSteps
            // 
            this.textBoxSteps.Location = new System.Drawing.Point(113, 128);
            this.textBoxSteps.Name = "textBoxSteps";
            this.textBoxSteps.Size = new System.Drawing.Size(100, 20);
            this.textBoxSteps.TabIndex = 5;
            this.textBoxSteps.TextChanged += new System.EventHandler(this.textBoxSteps_TextChanged);
            // 
            // buttonAddSteps
            // 
            this.buttonAddSteps.Location = new System.Drawing.Point(231, 126);
            this.buttonAddSteps.Name = "buttonAddSteps";
            this.buttonAddSteps.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSteps.TabIndex = 6;
            this.buttonAddSteps.Text = "Добавить";
            this.buttonAddSteps.UseVisualStyleBackColor = true;
            this.buttonAddSteps.Click += new System.EventHandler(this.buttonAddSteps_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "1000",
            "10000",
            "100000",
            "500000",
            "1000000",
            "5000000",
            "10000000"});
            this.listBox1.Location = new System.Drawing.Point(9, 157);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 251);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonRemoveStep
            // 
            this.buttonRemoveStep.Location = new System.Drawing.Point(9, 414);
            this.buttonRemoveStep.Name = "buttonRemoveStep";
            this.buttonRemoveStep.Size = new System.Drawing.Size(204, 23);
            this.buttonRemoveStep.TabIndex = 7;
            this.buttonRemoveStep.Text = "Удалить разбиение";
            this.buttonRemoveStep.UseVisualStyleBackColor = true;
            this.buttonRemoveStep.Click += new System.EventHandler(this.buttonRemoveStep_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(6, 472);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(207, 56);
            this.buttonCalculate.TabIndex = 1;
            this.buttonCalculate.Text = "Считать!";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // chartResult
            // 
            chartArea8.Name = "ChartArea1";
            this.chartResult.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartResult.Legends.Add(legend8);
            this.chartResult.Location = new System.Drawing.Point(347, 12);
            this.chartResult.Name = "chartResult";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartResult.Series.Add(series8);
            this.chartResult.Size = new System.Drawing.Size(659, 534);
            this.chartResult.TabIndex = 1;
            this.chartResult.Text = "chart1";
            // 
            // comboBoxMethods
            // 
            this.comboBoxMethods.FormattingEnabled = true;
            this.comboBoxMethods.Items.AddRange(new object[] {
            "Прямоугольников",
            "Трапеций",
            "Парабол"});
            this.comboBoxMethods.Location = new System.Drawing.Point(57, 85);
            this.comboBoxMethods.Name = "comboBoxMethods";
            this.comboBoxMethods.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMethods.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Метод:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(10, 456);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(59, 13);
            this.labelResult.TabIndex = 9;
            this.labelResult.Text = "Резултат: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 558);
            this.Controls.Add(this.chartResult);
            this.Controls.Add(this.groupBoxParameters);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.TextBox textBoxSteps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonRemoveStep;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonAddSteps;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxMethods;
        private System.Windows.Forms.Label labelResult;
    }
}

