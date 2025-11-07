using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.DataCollection;
using MSOopdracht2;

namespace MSOUserInterface2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _metricsButton = new Button();
            _programButton = new Button();
            _pathfindingButton = new Button();
            _programPanel = new Panel();
            _fileLoadButton = new Button();
            _outputTextBox = new TextBox();
            _programRichTextBox = new RichTextBox();
            _runButton = new Button();
            _examplesComboBox = new ComboBox();
            panel1 = new Panel();
            _pathfindingRunButton = new Button();
            _pathfindingExpert2 = new Button();
            _pathfindingExpert1 = new Button();
            _pathfindingAdvanced2 = new Button();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            _pathfindingPanel = new Panel();
            panel2 = new Panel();
            _outputPathFindingTextBox = new TextBox();
            _pathFindingExerciseComboBox = new ComboBox();
            _pathfindingMetricButton = new Button();
            _programPanel.SuspendLayout();
            _pathfindingPanel.SuspendLayout();
            SuspendLayout();
            // 
            // _metricsButton
            // 
            _metricsButton.ForeColor = Color.Red;
            _metricsButton.Location = new Point(312, 95);
            _metricsButton.Name = "_metricsButton";
            _metricsButton.Size = new Size(147, 60);
            _metricsButton.TabIndex = 0;
            _metricsButton.Text = "Metrics";
            _metricsButton.UseVisualStyleBackColor = true;
            _metricsButton.Click += MetricsButtonClick;
            // 
            // _programButton
            // 
            _programButton.BackColor = Color.Fuchsia;
            _programButton.Location = new Point(675, 12);
            _programButton.Name = "_programButton";
            _programButton.Size = new Size(169, 46);
            _programButton.TabIndex = 1;
            _programButton.Text = "To programs";
            _programButton.UseVisualStyleBackColor = false;
            _programButton.Click += ToProgramButtonClick;
            // 
            // _pathfindingButton
            // 
            _pathfindingButton.BackColor = Color.Crimson;
            _pathfindingButton.ForeColor = SystemColors.ButtonFace;
            _pathfindingButton.Location = new Point(684, 12);
            _pathfindingButton.Name = "_pathfindingButton";
            _pathfindingButton.Size = new Size(169, 46);
            _pathfindingButton.TabIndex = 2;
            _pathfindingButton.Text = "To pathfinding";
            _pathfindingButton.UseVisualStyleBackColor = false;
            _pathfindingButton.Click += ToPathfindingButtonClick;
            // 
            // _programPanel
            // 
            _programPanel.BackColor = Color.DarkRed;
            _programPanel.Controls.Add(_fileLoadButton);
            _programPanel.Controls.Add(_outputTextBox);
            _programPanel.Controls.Add(_programRichTextBox);
            _programPanel.Controls.Add(_runButton);
            _programPanel.Controls.Add(_examplesComboBox);
            _programPanel.Controls.Add(_pathfindingButton);
            _programPanel.Controls.Add(_metricsButton);
            _programPanel.Controls.Add(panel1);
            _programPanel.Location = new Point(11, 12);
            _programPanel.Name = "_programPanel";
            _programPanel.Size = new Size(986, 582);
            _programPanel.TabIndex = 3;
            // 
            // _fileLoadButton
            // 
            _fileLoadButton.BackColor = Color.Crimson;
            _fileLoadButton.ForeColor = SystemColors.ButtonFace;
            _fileLoadButton.Location = new Point(14, 41);
            _fileLoadButton.Name = "_fileLoadButton";
            _fileLoadButton.Size = new Size(94, 29);
            _fileLoadButton.TabIndex = 7;
            _fileLoadButton.Text = "From file";
            _fileLoadButton.UseVisualStyleBackColor = false;
            _fileLoadButton.Click += FileLoadButtonClick;
            // 
            // _outputTextBox
            // 
            _outputTextBox.BackColor = Color.Tomato;
            _outputTextBox.Location = new Point(312, 184);
            _outputTextBox.Multiline = true;
            _outputTextBox.Name = "_outputTextBox";
            _outputTextBox.Size = new Size(268, 213);
            _outputTextBox.TabIndex = 6;
            // 
            // _programRichTextBox
            // 
            _programRichTextBox.BackColor = Color.Salmon;
            _programRichTextBox.Location = new Point(14, 76);
            _programRichTextBox.Name = "_programRichTextBox";
            _programRichTextBox.Size = new Size(276, 404);
            _programRichTextBox.TabIndex = 5;
            _programRichTextBox.Text = "";
            // 
            // _runButton
            // 
            _runButton.ForeColor = Color.Red;
            _runButton.Location = new Point(465, 95);
            _runButton.Name = "_runButton";
            _runButton.Size = new Size(147, 60);
            _runButton.TabIndex = 4;
            _runButton.Text = "Run";
            _runButton.UseVisualStyleBackColor = true;
            _runButton.Click += RunButtonClick;
            // 
            // _examplesComboBox
            // 
            _examplesComboBox.BackColor = Color.RosyBrown;
            _examplesComboBox.ForeColor = Color.Brown;
            _examplesComboBox.FormattingEnabled = true;
            _examplesComboBox.Items.AddRange(new object[] { "Basic", "Advanced", "Expert" });
            _examplesComboBox.Location = new Point(114, 41);
            _examplesComboBox.Name = "_examplesComboBox";
            _examplesComboBox.Size = new Size(172, 31);
            _examplesComboBox.TabIndex = 3;
            _examplesComboBox.Text = "Examples";
            _examplesComboBox.SelectedIndexChanged += ExamplesComboBox_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(644, 161);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 300);
            panel1.TabIndex = 8;
            panel1.Paint += ColorPanel;
            // 
            // _pathfindingRunButton
            // 
            _pathfindingRunButton.BackColor = Color.Thistle;
            _pathfindingRunButton.Location = new Point(14, 520);
            _pathfindingRunButton.Name = "_pathfindingRunButton";
            _pathfindingRunButton.Size = new Size(112, 53);
            _pathfindingRunButton.TabIndex = 9;
            _pathfindingRunButton.Text = "Run";
            _pathfindingRunButton.UseVisualStyleBackColor = false;
            _pathfindingRunButton.Click += PathfindingRunButtonClick;
            // 
            // _pathfindingExpert2
            // 
            _pathfindingExpert2.BackColor = Color.MidnightBlue;
            _pathfindingExpert2.Location = new Point(325, 28);
            _pathfindingExpert2.Name = "_pathfindingExpert2";
            _pathfindingExpert2.Size = new Size(90, 53);
            _pathfindingExpert2.TabIndex = 0;
            _pathfindingExpert2.Text = "Expert example 2";
            _pathfindingExpert2.UseVisualStyleBackColor = false;
            _pathfindingExpert2.Click += GetExpertExercise2;
            // 
            // _pathfindingExpert1
            // 
            _pathfindingExpert1.BackColor = Color.RoyalBlue;
            _pathfindingExpert1.Location = new Point(225, 28);
            _pathfindingExpert1.Name = "_pathfindingExpert1";
            _pathfindingExpert1.Size = new Size(90, 53);
            _pathfindingExpert1.TabIndex = 11;
            _pathfindingExpert1.Text = "Expert example 1";
            _pathfindingExpert1.UseVisualStyleBackColor = false;
            _pathfindingExpert1.Click += GetExpertExercise1;
            // 
            // _pathfindingAdvanced2
            // 
            _pathfindingAdvanced2.BackColor = Color.RoyalBlue;
            _pathfindingAdvanced2.Location = new Point(25, 28);
            _pathfindingAdvanced2.Name = "_pathfindingAdvanced2";
            _pathfindingAdvanced2.Size = new Size(90, 53);
            _pathfindingAdvanced2.TabIndex = 0;
            _pathfindingAdvanced2.Text = "Advanced example 1";
            _pathfindingAdvanced2.UseVisualStyleBackColor = false;
            _pathfindingAdvanced2.Click += GetAdvancedExercise2;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.Location = new Point(125, 28);
            button1.Name = "button1";
            button1.Size = new Size(90, 53);
            button1.TabIndex = 10;
            button1.Text = "Advanced example 2";
            button1.UseVisualStyleBackColor = false;
            button1.Click += GetAdvancedExercise1;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Orchid;
            richTextBox1.Location = new Point(14, 95);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(418, 229);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            richTextBox1.Visible = false;
            // 
            // _pathfindingPanel
            // 
            _pathfindingPanel.BackColor = Color.Indigo;
            _pathfindingPanel.Controls.Add(panel2);
            _pathfindingPanel.Controls.Add(_pathfindingRunButton);
            _pathfindingPanel.Controls.Add(_pathfindingExpert2);
            _pathfindingPanel.Controls.Add(_pathfindingExpert1);
            _pathfindingPanel.Controls.Add(_pathfindingAdvanced2);
            _pathfindingPanel.Controls.Add(button1);
            _pathfindingPanel.Controls.Add(richTextBox1);
            _pathfindingPanel.Controls.Add(_programButton);
            _pathfindingPanel.Controls.Add(_outputPathFindingTextBox);
            _pathfindingPanel.Controls.Add(_pathFindingExerciseComboBox);
            _pathfindingPanel.Controls.Add(_pathfindingMetricButton);
            _pathfindingPanel.Location = new Point(11, 12);
            _pathfindingPanel.Name = "_pathfindingPanel";
            _pathfindingPanel.Size = new Size(986, 582);
            _pathfindingPanel.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Location = new Point(453, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(435, 435);
            panel2.TabIndex = 12;
            panel2.Paint += ColorPanel;
            // 
            // _outputPathFindingTextBox
            // 
            _outputPathFindingTextBox.Location = new Point(14, 345);
            _outputPathFindingTextBox.Multiline = true;
            _outputPathFindingTextBox.Name = "_outputPathFindingTextBox";
            _outputPathFindingTextBox.Size = new Size(268, 160);
            _outputPathFindingTextBox.TabIndex = 9;
            // 
            // _pathFindingExerciseComboBox
            // 
            _pathFindingExerciseComboBox.FormattingEnabled = true;
            _pathFindingExerciseComboBox.Items.AddRange(new object[] { "Exercise 1", "Exercise 2", "Exercise 3" });
            _pathFindingExerciseComboBox.Location = new Point(450, 34);
            _pathFindingExerciseComboBox.Name = "_pathFindingExerciseComboBox";
            _pathFindingExerciseComboBox.Size = new Size(169, 31);
            _pathFindingExerciseComboBox.TabIndex = 9;
            _pathFindingExerciseComboBox.Text = "Exercises";
            _pathFindingExerciseComboBox.SelectedIndexChanged += PathfindingExercises_SelectedIndexChanged;
            // 
            // _pathfindingMetricButton
            // 
            _pathfindingMetricButton.Location = new Point(135, 520);
            _pathfindingMetricButton.Name = "_pathfindingMetricButton";
            _pathfindingMetricButton.Size = new Size(106, 53);
            _pathfindingMetricButton.TabIndex = 9;
            _pathfindingMetricButton.Text = "Metrics";
            _pathfindingMetricButton.UseVisualStyleBackColor = true;
            _pathfindingMetricButton.Click += PathfindingMetricsButtonClick;
            
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 597);
            Controls.Add(_programPanel);
            Controls.Add(_pathfindingPanel);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            _programPanel.ResumeLayout(false);
            _programPanel.PerformLayout();
            _pathfindingPanel.ResumeLayout(false);
            _pathfindingPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button _metricsButton;
        private Button _programButton;
        private Button _pathfindingButton;
        private Panel _programPanel;
        private Panel _pathfindingPanel;
        private ComboBox _examplesComboBox;
        private Button _runButton;
        private RichTextBox _programRichTextBox;
        private TextBox _outputTextBox;
        private Button _fileLoadButton;
        private Panel panel1;
        private bool _hasRun = false; //only draw the trace if the user has clicked 'run'
        private bool _loadedGrid = false;
        private RichTextBox richTextBox1;
        private Button _pathfindingAdvanced2;
        private Button button1;
        private Button _pathfindingExpert2;
        private Button _pathfindingExpert1;
        private Button _pathfindingRunButton;
        private Panel panel2;
        private TextBox _outputPathFindingTextBox;
        private ComboBox _pathFindingExerciseComboBox;
        private Button _pathfindingMetricButton;
        private Image _characterImage;
        private Grid _grid;
        private Character _currentCharacter;
    }
}
