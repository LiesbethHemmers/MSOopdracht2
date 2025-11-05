using MSOopdracht2;
using MSOopdracht2.Importers;
using MSOopdracht2.Metrics;
using MSOopdracht2.Parsers;

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
            _hasRun = true;
            panel1.Invalidate();
        }

        private void FileLoadButtonClick(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                _programRichTextBox.Text = File.ReadAllText(filePath);
                string fileAsText = _programRichTextBox.Text;
                panel1.Invalidate();
                _hasRun = false;
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

            panel1.Invalidate();
            _hasRun = false;
        }

        public void AdvancedClick()
        {
            string exampleProgram = ExamplePrograms.GetTextAdvancedExampleProgram();
            _programRichTextBox.Text = File.ReadAllText(exampleProgram);
            string fileAsText = _programRichTextBox.Text;

            panel1.Invalidate();
            _hasRun = false;
        }

        public void ExpertClick()
        {
            string exampleProgram = ExamplePrograms.GetTextExpertExampleProgram();
            _programRichTextBox.Text = File.ReadAllText(exampleProgram);
            string fileAsText = _programRichTextBox.Text;

            panel1.Invalidate();
            _hasRun = false;
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

        private int FindGridDimension(Character character)
        {
            int gridDimension = 0;

            foreach ((int x, int y) coordinate in character.AllPositions)
            {
                if (coordinate.x > gridDimension)
                {
                    gridDimension = coordinate.x;
                }
                if (coordinate.y > gridDimension)
                {
                    gridDimension = coordinate.y;
                }
            }
            return gridDimension;
        }

        private void ColorPad(object sender, PaintEventArgs e)
        {
            CodeProgram codeProgram = TextToCodeProgram();
            Character character = new Character();
            codeProgram.Execute(character);

            if (codeProgram.Commands.Count == 0 || !_hasRun)
            {
                return;
            }

            float gridDimension = FindGridDimension(character) + 1;
            float panelMargin = 10;

            Pen penGrid = new Pen(Color.Red, 2);
            Pen penPath = new Pen(Color.Black, 2);
            Graphics g = e.Graphics;

            Size size = ((Panel)sender).Size;

            float usableGridSide = size.Width - panelMargin * 2;

            float cellDimension = usableGridSide / gridDimension;

            for (int j = 0; j <= gridDimension; j++)
            {
                g.DrawLine(penGrid, panelMargin + j * cellDimension, panelMargin, panelMargin + j * cellDimension, panelMargin + usableGridSide); //vertical
                g.DrawLine(penGrid, panelMargin, panelMargin + j * cellDimension, panelMargin + usableGridSide, panelMargin + j * cellDimension); //horizontal
            }

            for (int k = 0; k < character.AllPositions.Count - 1; k++)
            {
                (int x, int y) end;
                (int x, int y) start = character.AllPositions[k];

                if (k == character.AllPositions.Count - 1)
                {
                    end = start;
                }

                else
                {
                    end = character.AllPositions[k + 1];
                }

                g.DrawLine(penPath, panelMargin + start.x * cellDimension + (cellDimension / 2), panelMargin + start.y * cellDimension + (cellDimension / 2), panelMargin + end.x * cellDimension + (cellDimension / 2), panelMargin + end.y * cellDimension + (cellDimension / 2));
            }
        }

        private void _programPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
