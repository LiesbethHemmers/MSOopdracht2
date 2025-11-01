namespace MSOUserInterface2
{
    partial class Form1
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
            metricsButton = new Button();
            programButton = new Button();
            pathfindingButton = new Button();
            programPanel = new Panel();
            fileLoadButton = new Button();
            outputTextBox = new TextBox();
            programRichTextBox = new RichTextBox();
            runButton = new Button();
            examplesComboBox = new ComboBox();
            pathfindingPanel = new Panel();
            programPanel.SuspendLayout();
            pathfindingPanel.SuspendLayout();
            SuspendLayout();
            // 
            // metricsButton
            // 
            metricsButton.ForeColor = Color.Red;
            metricsButton.Location = new Point(312, 76);
            metricsButton.Name = "metricsButton";
            metricsButton.Size = new Size(147, 60);
            metricsButton.TabIndex = 0;
            metricsButton.Text = "Metrics";
            metricsButton.UseVisualStyleBackColor = true;
            metricsButton.Click += MetricsButtonClick;
            // 
            // programButton
            // 
            programButton.Location = new Point(675, 12);
            programButton.Name = "programButton";
            programButton.Size = new Size(169, 46);
            programButton.TabIndex = 1;
            programButton.Text = "To programs";
            programButton.UseVisualStyleBackColor = true;
            programButton.Click += ToProgramButtonClick;
            // 
            // pathfindingButton
            // 
            pathfindingButton.BackColor = Color.Crimson;
            pathfindingButton.ForeColor = SystemColors.ButtonFace;
            pathfindingButton.Location = new Point(684, 12);
            pathfindingButton.Name = "pathfindingButton";
            pathfindingButton.Size = new Size(169, 46);
            pathfindingButton.TabIndex = 2;
            pathfindingButton.Text = "To pathfinding";
            pathfindingButton.UseVisualStyleBackColor = false;
            pathfindingButton.Click += ToPathfindingButtonClick;
            // 
            // programPanel
            // 
            programPanel.BackColor = Color.DarkRed;
            programPanel.Controls.Add(fileLoadButton);
            programPanel.Controls.Add(outputTextBox);
            programPanel.Controls.Add(programRichTextBox);
            programPanel.Controls.Add(runButton);
            programPanel.Controls.Add(examplesComboBox);
            programPanel.Controls.Add(pathfindingButton);
            programPanel.Controls.Add(metricsButton);
            programPanel.Location = new Point(11, 12);
            programPanel.Name = "programPanel";
            programPanel.Size = new Size(878, 494);
            programPanel.TabIndex = 3;
            // 
            // fileLoadButton
            // 
            fileLoadButton.BackColor = Color.Crimson;
            fileLoadButton.ForeColor = SystemColors.ButtonFace;
            fileLoadButton.Location = new Point(14, 41);
            fileLoadButton.Name = "fileLoadButton";
            fileLoadButton.Size = new Size(94, 29);
            fileLoadButton.TabIndex = 7;
            fileLoadButton.Text = "From file";
            fileLoadButton.UseVisualStyleBackColor = false;
            fileLoadButton.Click += FileLoadButtonClick;
            // 
            // outputTextBox
            // 
            outputTextBox.BackColor = Color.Tomato;
            outputTextBox.Location = new Point(312, 161);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(363, 319);
            outputTextBox.TabIndex = 6;
            // 
            // programRichTextBox
            // 
            programRichTextBox.BackColor = Color.Salmon;
            programRichTextBox.Location = new Point(14, 76);
            programRichTextBox.Name = "programRichTextBox";
            programRichTextBox.Size = new Size(276, 404);
            programRichTextBox.TabIndex = 5;
            programRichTextBox.Text = "";
            // 
            // runButton
            // 
            runButton.ForeColor = Color.Red;
            runButton.Location = new Point(528, 76);
            runButton.Name = "runButton";
            runButton.Size = new Size(147, 60);
            runButton.TabIndex = 4;
            runButton.Text = "Run";
            runButton.UseVisualStyleBackColor = true;
            runButton.Click += RunButtonClick;
            // 
            // examplesComboBox
            // 
            examplesComboBox.BackColor = Color.RosyBrown;
            examplesComboBox.ForeColor = Color.Brown;
            examplesComboBox.FormattingEnabled = true;
            examplesComboBox.Items.AddRange(new object[] { "Basic", "Advanced", "Expert" });
            examplesComboBox.Location = new Point(114, 41);
            examplesComboBox.Name = "examplesComboBox";
            examplesComboBox.Size = new Size(172, 31);
            examplesComboBox.TabIndex = 3;
            examplesComboBox.SelectedIndexChanged += ExamplesComboBox_SelectedIndexChanged;
            // 
            // pathfindingPanel
            // 
            pathfindingPanel.Controls.Add(programButton);
            pathfindingPanel.Location = new Point(11, 12);
            pathfindingPanel.Name = "pathfindingPanel";
            pathfindingPanel.Size = new Size(878, 494);
            pathfindingPanel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 518);
            Controls.Add(programPanel);
            Controls.Add(pathfindingPanel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            programPanel.ResumeLayout(false);
            programPanel.PerformLayout();
            pathfindingPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button metricsButton;
        private Button programButton;
        private Button pathfindingButton;
        private Panel programPanel;
        private Panel pathfindingPanel;
        private ComboBox examplesComboBox;
        private Button runButton;
        private RichTextBox programRichTextBox;
        private TextBox outputTextBox;
        private Button fileLoadButton;
    }
}
