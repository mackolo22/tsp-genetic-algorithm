namespace TSP_Genetic_algorithm
{
    partial class FormMain
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
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.buttonExecuteAlgorithm = new System.Windows.Forms.Button();
            this.labelDistance = new System.Windows.Forms.Label();
            this.labelSolution = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelFileName = new System.Windows.Forms.Label();
            this.numericUpDownGenerationsAmount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPopulationSize = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTournamentSize = new System.Windows.Forms.NumericUpDown();
            this.labelCrossoverProbability = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTour = new System.Windows.Forms.RichTextBox();
            this.buttonTests = new System.Windows.Forms.Button();
            this.numericUpDownCrossoverProbability = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGenerationsAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopulationSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTournamentSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCrossoverProbability)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(69, 35);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(80, 36);
            this.buttonLoadFile.TabIndex = 0;
            this.buttonLoadFile.Text = "Load file";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // buttonExecuteAlgorithm
            // 
            this.buttonExecuteAlgorithm.Location = new System.Drawing.Point(92, 187);
            this.buttonExecuteAlgorithm.Name = "buttonExecuteAlgorithm";
            this.buttonExecuteAlgorithm.Size = new System.Drawing.Size(121, 42);
            this.buttonExecuteAlgorithm.TabIndex = 1;
            this.buttonExecuteAlgorithm.Text = "Execute algorithm";
            this.buttonExecuteAlgorithm.UseVisualStyleBackColor = true;
            this.buttonExecuteAlgorithm.Click += new System.EventHandler(this.buttonExecuteAlgorithm_Click);
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDistance.Location = new System.Drawing.Point(10, 239);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(39, 16);
            this.labelDistance.TabIndex = 2;
            this.labelDistance.Text = "Cost:";
            // 
            // labelSolution
            // 
            this.labelSolution.AutoSize = true;
            this.labelSolution.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSolution.Location = new System.Drawing.Point(10, 303);
            this.labelSolution.Name = "labelSolution";
            this.labelSolution.Size = new System.Drawing.Size(41, 16);
            this.labelSolution.TabIndex = 3;
            this.labelSolution.Text = "Path:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTime.Location = new System.Drawing.Point(10, 271);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(107, 16);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "Execution time:";
            // 
            // labelFileName
            // 
            this.labelFileName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFileName.Location = new System.Drawing.Point(0, 9);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(303, 16);
            this.labelFileName.TabIndex = 6;
            this.labelFileName.Text = "File: ";
            this.labelFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownGenerationsAmount
            // 
            this.numericUpDownGenerationsAmount.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownGenerationsAmount.Location = new System.Drawing.Point(188, 111);
            this.numericUpDownGenerationsAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownGenerationsAmount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownGenerationsAmount.Name = "numericUpDownGenerationsAmount";
            this.numericUpDownGenerationsAmount.Size = new System.Drawing.Size(91, 20);
            this.numericUpDownGenerationsAmount.TabIndex = 9;
            this.numericUpDownGenerationsAmount.ThousandsSeparator = true;
            this.numericUpDownGenerationsAmount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownPopulationSize
            // 
            this.numericUpDownPopulationSize.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownPopulationSize.Location = new System.Drawing.Point(188, 136);
            this.numericUpDownPopulationSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPopulationSize.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownPopulationSize.Name = "numericUpDownPopulationSize";
            this.numericUpDownPopulationSize.Size = new System.Drawing.Size(91, 20);
            this.numericUpDownPopulationSize.TabIndex = 10;
            this.numericUpDownPopulationSize.ThousandsSeparator = true;
            this.numericUpDownPopulationSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownTournamentSize
            // 
            this.numericUpDownTournamentSize.Location = new System.Drawing.Point(188, 161);
            this.numericUpDownTournamentSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTournamentSize.Name = "numericUpDownTournamentSize";
            this.numericUpDownTournamentSize.Size = new System.Drawing.Size(91, 20);
            this.numericUpDownTournamentSize.TabIndex = 11;
            this.numericUpDownTournamentSize.ThousandsSeparator = true;
            this.numericUpDownTournamentSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelCrossoverProbability
            // 
            this.labelCrossoverProbability.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCrossoverProbability.Location = new System.Drawing.Point(26, 85);
            this.labelCrossoverProbability.Name = "labelCrossoverProbability";
            this.labelCrossoverProbability.Size = new System.Drawing.Size(156, 16);
            this.labelCrossoverProbability.TabIndex = 12;
            this.labelCrossoverProbability.Text = "Crossover probability:";
            this.labelCrossoverProbability.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(26, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Population size:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(26, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Amount of generations:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(26, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tournament size:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxTour
            // 
            this.textBoxTour.BackColor = System.Drawing.Color.White;
            this.textBoxTour.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTour.ForeColor = System.Drawing.Color.Black;
            this.textBoxTour.Location = new System.Drawing.Point(12, 333);
            this.textBoxTour.Name = "textBoxTour";
            this.textBoxTour.ReadOnly = true;
            this.textBoxTour.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.textBoxTour.Size = new System.Drawing.Size(281, 61);
            this.textBoxTour.TabIndex = 20;
            this.textBoxTour.Text = "";
            this.textBoxTour.WordWrap = false;
            // 
            // buttonTests
            // 
            this.buttonTests.Location = new System.Drawing.Point(155, 35);
            this.buttonTests.Name = "buttonTests";
            this.buttonTests.Size = new System.Drawing.Size(80, 36);
            this.buttonTests.TabIndex = 21;
            this.buttonTests.Text = "Perform tests";
            this.buttonTests.UseVisualStyleBackColor = true;
            this.buttonTests.Click += new System.EventHandler(this.buttonTests_Click);
            // 
            // numericUpDownCrossoverProbability
            // 
            this.numericUpDownCrossoverProbability.DecimalPlaces = 2;
            this.numericUpDownCrossoverProbability.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownCrossoverProbability.Location = new System.Drawing.Point(188, 85);
            this.numericUpDownCrossoverProbability.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCrossoverProbability.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownCrossoverProbability.Name = "numericUpDownCrossoverProbability";
            this.numericUpDownCrossoverProbability.Size = new System.Drawing.Size(91, 20);
            this.numericUpDownCrossoverProbability.TabIndex = 22;
            this.numericUpDownCrossoverProbability.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 429);
            this.Controls.Add(this.numericUpDownCrossoverProbability);
            this.Controls.Add(this.buttonTests);
            this.Controls.Add(this.textBoxTour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCrossoverProbability);
            this.Controls.Add(this.numericUpDownTournamentSize);
            this.Controls.Add(this.numericUpDownPopulationSize);
            this.Controls.Add(this.numericUpDownGenerationsAmount);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelSolution);
            this.Controls.Add(this.labelDistance);
            this.Controls.Add(this.buttonExecuteAlgorithm);
            this.Controls.Add(this.buttonLoadFile);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TSP - Genetic Algorithm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGenerationsAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopulationSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTournamentSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCrossoverProbability)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.Button buttonExecuteAlgorithm;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.Label labelSolution;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.NumericUpDown numericUpDownGenerationsAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownPopulationSize;
        private System.Windows.Forms.NumericUpDown numericUpDownTournamentSize;
        private System.Windows.Forms.Label labelCrossoverProbability;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox textBoxTour;
        private System.Windows.Forms.Button buttonTests;
        private System.Windows.Forms.NumericUpDown numericUpDownCrossoverProbability;
    }
}

