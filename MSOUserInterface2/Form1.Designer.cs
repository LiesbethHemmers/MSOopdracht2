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
            //panels are a sort of container, everything that belongs to a panel moves with it, used for menu
            programPanel = new Panel();
            pathfindingPanel = new Panel();

            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(11, 10);
            button1.Name = "button1";
            button1.Size = new Size(268, 99);
            button1.TabIndex = 0;
            button1.Text = "hoi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // programButton
            // 
            programButton.Location = new Point(600, 10);
            programButton.Name = "programButton";
            programButton.Size = new Size(150, 40);
            programButton.TabIndex = 1;
            programButton.Text = "To programs";
            programButton.UseVisualStyleBackColor = true;
            programButton.Click += ToProgramButtonClick;
            // 
            // pathfindingButton
            // 
            pathfindingButton.Location = new Point(600, 10);
            pathfindingButton.Name = "pathfindingButton";
            pathfindingButton.Size = new Size(150, 40);
            pathfindingButton.TabIndex = 2;
            pathfindingButton.Text = "To pathfinding";
            pathfindingButton.UseVisualStyleBackColor = true;
            pathfindingButton.Click += ToPathfindingButtonClick;
            // 
            // programPanel
            // 
            programPanel.Location = new Point(10, 10);
            programPanel.Name = "programPanel";
            programPanel.Size = new Size(780, 430);
            programPanel.TabIndex = 3;
            programPanel.Controls.Add(pathfindingButton);
            programPanel.Controls.Add(button1);
            // 
            // pathfindingPanel
            // 
            pathfindingPanel.Location = new Point(10, 10);
            pathfindingPanel.Name = "pathfindingPanel";
            pathfindingPanel.Size = new Size(780, 430);
            pathfindingPanel.TabIndex = 0;
            pathfindingPanel.Controls.Add(programButton);

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(programPanel);
            Controls.Add(pathfindingPanel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button programButton;
        private Button pathfindingButton;
        private Panel programPanel;
        private Panel pathfindingPanel;
    }
}
