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
            panel1 = new Panel();
            button3 = new Button();
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
            button1.ForeColor = Color.Red;
            button1.Location = new Point(339, 145);
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
            pathfindingButton.BackColor = Color.Crimson;
            pathfindingButton.ForeColor = SystemColors.ButtonFace;
            pathfindingButton.Location = new Point(1036, 46);
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
            programPanel.Controls.Add(panel1);
            programPanel.Controls.Add(button3);
            programPanel.Controls.Add(textBox1);
            programPanel.Controls.Add(richTextBox1);
            programPanel.Controls.Add(button2);
            programPanel.Controls.Add(comboBox1);
            programPanel.Controls.Add(pathfindingButton);
            programPanel.Controls.Add(button1);
            programPanel.Location = new Point(11, 1);
            programPanel.Name = "programPanel";
            programPanel.Size = new Size(1555, 1047);
            programPanel.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(733, 211);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 300);
            panel1.TabIndex = 8;
            panel1.Paint += ColorPad;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(10, 76);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 7;
            button3.Text = "From file";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Tomato;
            textBox1.Location = new Point(323, 211);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(363, 319);
            textBox1.TabIndex = 6;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Salmon;
            richTextBox1.Location = new Point(10, 126);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(276, 404);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.ForeColor = Color.Red;
            button2.Location = new Point(521, 145);
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
            comboBox1.Items.AddRange(new object[] { "Basic", "Advanced", "Expert" });
            comboBox1.Location = new Point(110, 76);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(172, 31);
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
            ClientSize = new Size(1283, 619);
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
        private Button button3;
        private Panel panel1;
    }
}
