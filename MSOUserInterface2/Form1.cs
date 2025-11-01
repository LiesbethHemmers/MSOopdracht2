using Microsoft.VisualBasic.ApplicationServices;
using MSOopdracht2;
using MSOopdracht2.Metrics;
using MSOopdracht2.Parsers;
using MSOopdracht2.Importers;
using System.Collections;
using System.Collections.Generic;

namespace MSOUserInterface2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            programPanel.BringToFront();
        }

        private void MetricsButtonClick(object sender, EventArgs e)
        {
            CodeProgram codeProgram = TextToCodeProgram();
            MetricCalculator calculator = new MetricCalculator();
            StoredMetrics metric = calculator.CalculateMetrics(codeProgram);
            List<string> output = metric.GetMetrics();
            outputTextBox.Text = string.Join(" ", output);
        }

        private void RunButtonClick(object sender, EventArgs e)
        {
            CodeProgram codeProgram = TextToCodeProgram();
            CodeProgramExecutor executor = new CodeProgramExecutor();
            List<string> output = executor.Run(codeProgram);
            outputTextBox.Text = string.Join(" ", output);
        }

        private void FileLoadButtonClick(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                programRichTextBox.Text = File.ReadAllText(filePath);
                string fileAsText = programRichTextBox.Text;
            }
        }

        private void ToProgramButtonClick(object sender, EventArgs e)
        {
            programPanel.BringToFront();
        }
        private void ToPathfindingButtonClick(object sender, EventArgs e)
        {
            pathfindingPanel.BringToFront();
        }

        private void ExamplesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (examplesComboBox.Text.Equals("Basic"))
            {
                BasicClick();
            }

            if (examplesComboBox.Text.Equals("Advanced"))
            {
                AdvancedClick();
            }

            if (examplesComboBox.Text.Equals("Expert"))
            {
                ExpertClick();
            }
        }

        public void BasicClick()
        {
            string exampleProgram = ExamplePrograms.GetTextBasicExampleProgram();
            programRichTextBox.Text = File.ReadAllText(exampleProgram);
            string fileAsText = programRichTextBox.Text;
        }

        public void AdvancedClick()
        {
            string exampleProgram = ExamplePrograms.GetTextAdvancedExampleProgram();
            programRichTextBox.Text = File.ReadAllText(exampleProgram);
            string fileAsText = programRichTextBox.Text;
        }

        public void ExpertClick()
        {
            string exampleProgram = ExamplePrograms.GetTextExpertExampleProgram();
            programRichTextBox.Text = File.ReadAllText(exampleProgram);
            string fileAsText = programRichTextBox.Text;
        }


        private CodeProgram TextToCodeProgram()
        {
            FileInfo file = new FileInfo(@"ProcessingFile\ProcessingFile.txt");
            string fullFileName = file.FullName;

            programRichTextBox.SaveFile(fullFileName, RichTextBoxStreamType.PlainText);

            CodeProgram codeProgram = null;
            IProgramParser parser = new TxtProgramParser();
            IProgramImporter importer = new TxtProgramImporter(parser);
            codeProgram = importer.Import(fullFileName);
            return codeProgram;
        }
    }
}
