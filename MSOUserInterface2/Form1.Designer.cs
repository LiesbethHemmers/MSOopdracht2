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
            button1 = new Button();
            programButton = new Button();
            pathfindingButton = new Button();
            programPanel = new Panel();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            pathfindingPanel = new Panel();
            programPanel.SuspendLayout();
            pathfindingPanel.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(312, 95);
            button1.Name = "button1";
            button1.Size = new Size(147, 60);
            button1.TabIndex = 0;
            button1.Text = "Metrics";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            pathfindingButton.Location = new Point(684, 12);
            pathfindingButton.Name = "pathfindingButton";
            pathfindingButton.Size = new Size(169, 46);
            pathfindingButton.TabIndex = 2;
            pathfindingButton.Text = "To pathfinding";
            pathfindingButton.UseVisualStyleBackColor = true;
            pathfindingButton.Click += ToPathfindingButtonClick;
            // 
            // programPanel
            // 
            programPanel.BackColor = Color.DarkRed;
            programPanel.Controls.Add(textBox1);
            programPanel.Controls.Add(richTextBox1);
            programPanel.Controls.Add(button2);
            programPanel.Controls.Add(comboBox1);
            programPanel.Controls.Add(pathfindingButton);
            programPanel.Controls.Add(button1);
            programPanel.Location = new Point(11, 12);
            programPanel.Name = "programPanel";
            programPanel.Size = new Size(878, 494);
            programPanel.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Tomato;
            textBox1.Location = new Point(312, 161);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 217);
            textBox1.TabIndex = 6;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Salmon;
            richTextBox1.Location = new Point(12, 76);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(276, 404);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(465, 95);
            button2.Name = "button2";
            button2.Size = new Size(147, 60);
            button2.TabIndex = 4;
            button2.Text = "Run";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.RosyBrown;
            comboBox1.ForeColor = Color.Brown;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Basic", "Advanced", "Expert", "From file" });
            comboBox1.Location = new Point(0, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(485, 31);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
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

        private Button button1;
        private Button programButton;
        private Button pathfindingButton;
        private Panel programPanel;
        private Panel pathfindingPanel;
        private ComboBox comboBox1;
        private Button button2;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
    }
}
