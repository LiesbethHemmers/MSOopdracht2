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
    }
}
