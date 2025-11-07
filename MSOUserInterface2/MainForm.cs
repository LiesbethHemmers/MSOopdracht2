using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
using MSOopdracht2;
using MSOopdracht2.Importers;
using MSOopdracht2.Metrics;
using MSOopdracht2.Parsers;
using System.Reflection.Metadata.Ecma335;

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
            currentCharacter = null;
            CodeProgram codeProgram = TextToCodeProgram();
            Character character = new Character();
            codeProgram.Execute(character);
            currentCharacter = character;

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
            richTextBox1.Visible = false;
            panel1.Visible = true;
            panel2.Visible = false;
            panel1.BringToFront();
            panel1.Invalidate();
            _hasRun = false;
            currentCharacter = null;
            grid = null;
        }
        private void ToPathfindingButtonClick(object sender, EventArgs e)
        {
            _pathfindingPanel.BringToFront();
            richTextBox1.Visible = true;
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.BringToFront();
            panel2.Invalidate();
            _hasRun = false;
            currentCharacter = null;
            grid = null;
            _loadedGrid = false;
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

        private CodeProgram PathfindingTextToCodeProgram()
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

        private int FindGridDimension()
        {
            if (grid == null)
            {
                return 0;
            }

            int gridDimension = 0;
            gridDimension = Math.Max(grid.GetWidth(), grid.GetHeight());

            return gridDimension;
        }

        private int FindFieldDimension(Character character)
        {
            int fieldDimension = 0;

            foreach ((int x, int y) coordinate in character.AllPositions)
            {
                if (coordinate.x > fieldDimension)
                {
                    fieldDimension = coordinate.x;
                }
                if (coordinate.y > fieldDimension)
                {
                    fieldDimension = coordinate.y;
                }
            }
            return fieldDimension;
        }

        private void ColorPad(object sender, PaintEventArgs e)
        {
            float panelMargin = 10;

            Pen penGrid = new Pen(Color.Red, 2);
            Pen penPath = new Pen(Color.Black, 2);
            Graphics graphics = e.Graphics;
            graphics.Clear(((Panel)sender).BackColor);

            Size size = ((Panel)sender).Size;

            float usableGridSide = size.Width - panelMargin * 2;

            if (grid != null && _loadedGrid == true) //After I clicked one of the exercises in the pathfinding menu
            {
                float gridDimension = FindGridDimension();

                float cellDimension = usableGridSide / gridDimension;

                for (int y = 0; y < grid.GetHeight(); y++)
                {
                    for (int x = 0; x < grid.GetWidth(); x++)
                    {
                        char symbol = grid.GetSymbol(x, y);

                        Brush brush = Brushes.White;

                        if (symbol == '+')
                        {
                            brush = Brushes.Purple;
                        }

                        if (symbol == 'o')
                        {
                            brush = Brushes.MediumOrchid;
                        }

                        if (symbol == 'x')
                        {
                            brush = Brushes.Pink;
                        }

                        graphics.FillRectangle(brush, panelMargin + x * cellDimension, panelMargin + y * cellDimension, cellDimension, cellDimension);
                    }
                }
            }

            if (_hasRun == true && currentCharacter != null) //When i have a program with a path that i want to draw
            {
                Character character = currentCharacter;
                float fieldDimension = grid != null && _loadedGrid ? FindGridDimension() : FindFieldDimension(character) + 1;
                float cellDimension = usableGridSide / fieldDimension;

                if (grid == null) //Just draw some lines for clariy if the program doesnt have a grid
                {
                    for (int j = 0; j <= fieldDimension; j++)
                    {
                        graphics.DrawLine(penGrid, panelMargin + j * cellDimension, panelMargin, panelMargin + j * cellDimension, panelMargin + usableGridSide); //vertical
                        graphics.DrawLine(penGrid, panelMargin, panelMargin + j * cellDimension, panelMargin + usableGridSide, panelMargin + j * cellDimension); //horizontal
                    }
                }

                for (int k = 0; k < currentCharacter.AllPositions.Count - 1; k++)
                {
                    (int x, int y) end;
                    (int x, int y) start = currentCharacter.AllPositions[k];

                    if (k == currentCharacter.AllPositions.Count - 1)
                    {
                        end = start;
                    }

                    else
                    {
                        end = currentCharacter.AllPositions[k + 1];
                    }

                    graphics.DrawLine(penPath, panelMargin + start.x * cellDimension + (cellDimension / 2), panelMargin + start.y * cellDimension + (cellDimension / 2), panelMargin + end.x * cellDimension + (cellDimension / 2), panelMargin + end.y * cellDimension + (cellDimension / 2));
                }
            }
        }

        private void DrawGrid(object sender, PaintEventArgs e)
        {
        }

        private Grid grid;
        private Character? currentCharacter;

        private void GetAdvancedExercise1(object sender, EventArgs e)
        {
            string gridFileName = ExamplePrograms.AdvancedGrid1();
            IGridParser parser = new TxtGridParser();
            IGridImporter importer = new TxtGridImporter(parser);
            Grid gridProgram = importer.Import(gridFileName);

            grid = gridProgram;
            string exampleProgram = ExamplePrograms.AdvancedGridProgram1();
            richTextBox1.Text = File.ReadAllText(exampleProgram);

            _hasRun = false;
            _loadedGrid = true;
            panel2.Invalidate();
        }

        private void GetAdvancedExercise2(object sender, EventArgs e)
        {
            string gridFileName = ExamplePrograms.AdvancedGrid2();
            IGridParser parser = new TxtGridParser();
            IGridImporter importer = new TxtGridImporter(parser);
            Grid gridProgram = importer.Import(gridFileName);

            grid = gridProgram;
            string exampleProgram = ExamplePrograms.AdvancedGridProgram2();
            richTextBox1.Text = File.ReadAllText(exampleProgram);

            _hasRun = false;
            _loadedGrid = true;
            panel2.Invalidate();
        }

        private void GetExpertExercise1(object sender, EventArgs e)
        {
            string gridFileName = ExamplePrograms.ExpertGrid1();
            IGridParser parser = new TxtGridParser();
            IGridImporter importer = new TxtGridImporter(parser);
            Grid gridProgram = importer.Import(gridFileName);
            grid = gridProgram;
            string exampleProgram = ExamplePrograms.ExpertGridProgram1();
            richTextBox1.Text = File.ReadAllText(exampleProgram);

            _hasRun = false;
            _loadedGrid = true;
            panel2.Invalidate();
        }


        private void GetExpertExercise2(object sender, EventArgs e)
        {
            string gridFileName = ExamplePrograms.ExpertGrid2();
            IGridParser parser = new TxtGridParser();
            IGridImporter importer = new TxtGridImporter(parser);
            Grid gridProgram = importer.Import(gridFileName);
            grid = gridProgram;
            string exampleProgram = ExamplePrograms.ExpertGridProgram2();
            richTextBox1.Text = File.ReadAllText(exampleProgram);

            _hasRun = false;
            _loadedGrid = true;
            panel2.Invalidate();
        }

        private void PathfindingRunButtonClick(object sender, EventArgs e)
        {
            currentCharacter = null;
            CodeProgram codeProgram = PathfindingTextToCodeProgram();
            Character character = new Character();
            codeProgram.Execute(character);
            currentCharacter = character;

            CodeProgramExecutor executor = new CodeProgramExecutor();

            List<string> output = executor.Run(codeProgram, grid);

            _outputPathFindingTextBox.Text = string.Join(" ", output);
            _hasRun = true;
            panel2.Invalidate();
        }

        private void _programPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PathfindingExercises_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_pathFindingExerciseComboBox.Text.Equals("Exercise 1"))
            {
                Exercise1Click();
            }

            if (_pathFindingExerciseComboBox.Text.Equals("Exercise 2"))
            {
                Exercise2Click();
            }

            if (_pathFindingExerciseComboBox.Text.Equals("Exercise 3"))
            {
                Exercise3Click();
            }
        }

        public void Exercise1Click()
        {
            string gridFileName = ExamplePrograms.ExerciseGrid1();
            IGridParser parser = new TxtGridParser();
            IGridImporter importer = new TxtGridImporter(parser);
            Grid gridProgram = importer.Import(gridFileName);
            grid = gridProgram;
            richTextBox1.Text = null;

            _hasRun = false;
            _loadedGrid = true;
            panel2.Invalidate();
        }
        public void Exercise2Click()
        {
            string gridFileName = ExamplePrograms.ExerciseGrid2();
            IGridParser parser = new TxtGridParser();
            IGridImporter importer = new TxtGridImporter(parser);
            Grid gridProgram = importer.Import(gridFileName);
            grid = gridProgram;
            richTextBox1.Text = null;

            _hasRun = false;
            _loadedGrid = true;
            panel2.Invalidate();
        }
        public void Exercise3Click()
        {
            string gridFileName = ExamplePrograms.ExerciseGrid3();
            IGridParser parser = new TxtGridParser();
            IGridImporter importer = new TxtGridImporter(parser);
            Grid gridProgram = importer.Import(gridFileName);
            grid = gridProgram;
            richTextBox1.Text = null;

            _hasRun = false;
            _loadedGrid = true;
            panel2.Invalidate();
        }

        private void PathfindingMetricsButtonClick(object sender, EventArgs e)
        {
            CodeProgram codeProgram = PathfindingTextToCodeProgram();
            MetricCalculator calculator = new MetricCalculator();
            StoredMetrics metric = calculator.CalculateMetrics(codeProgram);
            List<string> output = metric.GetMetrics();

           _outputPathFindingTextBox.Text = string.Join(" ", output);
        }
    }
}
