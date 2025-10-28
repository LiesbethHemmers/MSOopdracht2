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

        private void button1_Click(object sender, EventArgs e)
        {
            CodeProgram codeProgram = TextToCodeProgram();
            MetricCalculator calculator = new MetricCalculator();
            StoredMetrics metric = calculator.CalculateMetrics(codeProgram);
            List<string> output = metric.GetMetrics();
            textBox1.Text = string.Join(" ", output);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CodeProgram codeProgram = TextToCodeProgram();
            CodeProgramExecutor executor = new CodeProgramExecutor();
            List<string> output = executor.Run(codeProgram);
            textBox1.Text = string.Join(" ", output);
        }

        private void ToProgramButtonClick(object sender, EventArgs e)
        {
            programPanel.BringToFront();
        }
        private void ToPathfindingButtonClick(object sender, EventArgs e)
        {
            pathfindingPanel.BringToFront();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Basic"))
            {
                BasicClick();
            }

            if (comboBox1.Text.Equals("Advanced"))
            {
                AdvancedClick();
            }

            if (comboBox1.Text.Equals("Expert"))
            {
                ExpertClick();
            }
        }

        public void BasicClick()
        {
            string exampleProgram = ExamplePrograms.GetTextBasicExampleProgram();
            richTextBox1.Text = File.ReadAllText(exampleProgram);
            string fileAsText = richTextBox1.Text;
        }

        public void AdvancedClick()
        {
            string exampleProgram = ExamplePrograms.GetTextAdvancedExampleProgram();
            richTextBox1.Text = File.ReadAllText(exampleProgram);
            string fileAsText = richTextBox1.Text;
        }

        public void ExpertClick()
        {
            string exampleProgram = ExamplePrograms.GetTextExpertExampleProgram();
            richTextBox1.Text = File.ReadAllText(exampleProgram);
            string fileAsText = richTextBox1.Text;
        }

        private CodeProgram TextToCodeProgram()
        {
            FileInfo file = new FileInfo(@"ProcessingFile\ProcessingFile.txt");
            string fullFileName = file.FullName;

            richTextBox1.SaveFile(fullFileName, RichTextBoxStreamType.PlainText);

            CodeProgram codeProgram = null;
            IProgramParser parser = new TxtProgramParser();
            IProgramImporter importer = new TxtProgramImporter(parser);
            codeProgram = importer.Import(fullFileName);
            return codeProgram;
        }
    }
}
