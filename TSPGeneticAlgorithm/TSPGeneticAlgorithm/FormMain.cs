using System;
using System.Windows.Forms;

namespace TSP_Genetic_Algorithm
{
    public partial class FormMain : Form
    {
        public FormMain() => InitializeComponent();

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Title = "Choose a file";
                fileDialog.Filter = "Files(*.txt; *.atsp;)| *.txt; *.atsp;";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string message = GraphManager.LoadGraphFile(fileDialog.FileName);
                    MessageBox.Show(message);
                    labelFileName.Text = $"File: {fileDialog.FileName}";
                }
            }
        }

        private void buttonExecuteAlgorithm_Click(object sender, EventArgs e)
        {
            double time;
            string[] results = GeneticAlgorithm.ExecuteOrderedCrossoverAlgorithm(out time, (double)numericUpDownCrossoverProbability.Value,
                (int)numericUpDownTournamentSize.Value, (int)numericUpDownPopulationSize.Value, (int)numericUpDownPopulationSize.Value);

            labelDistance.Text = $"Cost: {results[0]}";
            textBoxTour.Text = results[1];
            labelTime.Text = $"Execution time: {time}ms";
        }

        private void buttonTests_Click(object sender, EventArgs e) => TestsManager.PerformTests();
    }
}