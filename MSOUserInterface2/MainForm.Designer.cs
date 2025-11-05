using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.DataCollection;

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
            _pathfindingPanel = new Panel();
            panel1 = new Panel();
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
            _programButton.Location = new Point(675, 12);
            _programButton.Name = "_programButton";
            _programButton.Size = new Size(169, 46);
            _programButton.TabIndex = 1;
            _programButton.Text = "To programs";
            _programButton.UseVisualStyleBackColor = true;
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
            _programPanel.Controls.Add(panel1);
            _programPanel.Controls.Add(_fileLoadButton);
            _programPanel.Controls.Add(_outputTextBox);
            _programPanel.Controls.Add(_programRichTextBox);
            _programPanel.Controls.Add(_runButton);
            _programPanel.Controls.Add(_examplesComboBox);
            _programPanel.Controls.Add(_pathfindingButton);
            _programPanel.Controls.Add(_metricsButton);
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
            _outputTextBox.Location = new Point(312, 161);
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
            // _pathfindingPanel
            // 
            _pathfindingPanel.Controls.Add(_programButton);
            _pathfindingPanel.Location = new Point(11, 12);
            _pathfindingPanel.Name = "_pathfindingPanel";
            _pathfindingPanel.Size = new Size(986, 582);
            _pathfindingPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(644, 161);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 300);
            panel1.TabIndex = 8;
            panel1.Paint += ColorPad;
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
    }
}
