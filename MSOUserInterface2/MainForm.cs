using Microsoft.VisualBasic.ApplicationServices;
using MSOopdracht2;
using MSOopdracht2.Metrics;
using MSOopdracht2.Parsers;
using MSOopdracht2.Importers;
using System.Collections;
using System.Collections.Generic;

namespace MSOUserInterface2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _programPanel.BringToFront();
        }

        private void MetricsButtonClick(object sender, EventArgs e)
        {
            CodeProgram codeProgram = TextToCodeProgram();
            MetricCalculator calculator = new MetricCalculator();
            StoredMetrics metric = calculator.CalculateMetrics(codeProgram);
            List<string> output = metric.GetMetrics();
            _outputTextBox.Text = string.Join(" ", output);
        }

        private void RunButtonClick(object sender, EventArgs e)
        {
            CodeProgram codeProgram = TextToCodeProgram();
            CodeProgramExecutor executor = new CodeProgramExecutor();
            List<string> output = executor.Run(codeProgram);
            _outputTextBox.Text = string.Join(" ", output);
        }

        private void FileLoadButtonClick(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                _programRichTextBox.Text = File.ReadAllText(filePath);
                string fileAsText = _programRichTextBox.Text;
            }
        }

        private void ToProgramButtonClick(object sender, EventArgs e)
        {
            _programPanel.BringToFront();
        }
        private void ToPathfindingButtonClick(object sender, EventArgs e)
        {
            _pathfindingPanel.BringToFront();
        }

        private void ExamplesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_examplesComboBox.Text.Equals("Basic"))
            {
                BasicClick();
            }

            if (_examplesComboBox.Text.Equals("Advanced"))
            {
                AdvancedClick();
            }

            if (_examplesComboBox.Text.Equals("Expert"))
            {
                ExpertClick();
            }
        }

        public void BasicClick()
        {
            string exampleProgram = ExamplePrograms.GetTextBasicExampleProgram();
            _programRichTextBox.Text = File.ReadAllText(exampleProgram);
            string fileAsText = _programRichTextBox.Text;
        }

        public void AdvancedClick()
        {
            string exampleProgram = ExamplePrograms.GetTextAdvancedExampleProgram();
            _programRichTextBox.Text = File.ReadAllText(exampleProgram);
            string fileAsText = _programRichTextBox.Text;
        }

        public void ExpertClick()
        {
            string exampleProgram = ExamplePrograms.GetTextExpertExampleProgram();
            _programRichTextBox.Text = File.ReadAllText(exampleProgram);
            string fileAsText = _programRichTextBox.Text;
        }


        private CodeProgram TextToCodeProgram()
        {
            FileInfo file = new FileInfo(@"ProcessingFile\ProcessingFile.txt");
            string fullFileName = file.FullName;

            _programRichTextBox.SaveFile(fullFileName, RichTextBoxStreamType.PlainText);

            CodeProgram codeProgram = null;
            IProgramParser parser = new TxtProgramParser();
            IProgramImporter importer = new TxtProgramImporter(parser);
            codeProgram = importer.Import(fullFileName);
            return codeProgram;
        }
    }
}
