using DNDTextGame;

namespace dndTextGame
{
    public partial class Form1 : Form
    {
        private GameManager gameManager;

        private void DisplayGameOutput()
        {
            rtbGameOutput.Clear();
            rtbGameOutput.AppendText(gameManager.GetGameOutput() + "\n\n");
            txtPlayInput.Clear(); // Changed from txtPlayerInput
            txtPlayInput.Focus(); // Changed from txtPlayerInput
        }

        public Form1()
        {
            InitializeComponent();
            gameManager = new GameManager();
            DisplayGameOutput();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // No action needed here
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string playerInput = txtPlayInput.Text; // Changed from txtPlayerInput
            gameManager.ProcessPlayerInput(playerInput);
            DisplayGameOutput();
        }

        private void txtPlayerInput_KeyDown(object sender, KeyEventArgs e) // This method name is also wrong if you matched the above!
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}