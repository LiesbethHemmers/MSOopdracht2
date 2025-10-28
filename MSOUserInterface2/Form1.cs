using MSOopdracht2;

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
        }

        public void AdvancedClick()
        {
            string exampleProgram = ExamplePrograms.GetTextAdvancedExampleProgram();
            richTextBox1.Text = File.ReadAllText(exampleProgram);
        }

        public void ExpertClick()
        {
            string exampleProgram = ExamplePrograms.GetTextExpertExampleProgram();
            richTextBox1.Text = File.ReadAllText(exampleProgram);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
