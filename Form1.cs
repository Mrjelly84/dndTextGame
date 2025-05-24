using DNDTextGame;
using System.Drawing; // Add this using directive for Image and related classes

namespace dndTextGame
{
    public partial class Form1 : Form
    {
        private GameManager gameManager;

        public Form1()
        {
            InitializeComponent();
            gameManager = new GameManager();
            DisplayGameOutputAndImage(); // Changed to new method
        }

        // Renamed and modified to handle both text and image
        private void DisplayGameOutputAndImage()
        {
            rtbGameOutput.Clear();
            string currentGameState = gameManager.GetGameState(); // Get the raw state from GameManager
            string gameText = gameManager.GetGameOutput();       // Get the text output

            rtbGameOutput.AppendText(gameText + "\n\n");
            txtPlayInput.Clear();
            txtPlayInput.Focus();

            // --- New Logic for Image Display ---
            switch (currentGameState) // Use the raw game state to determine the image
            {
                case "start":
                    // Assuming you added an image named "cave" to your project resources
                    pbGameImage.Image = Properties.Resources.cave;
                    pbGameImage.SizeMode = PictureBoxSizeMode.Zoom; // Or Normal, StretchImage, CenterImage
                    break;
                case "left_passage":
                    // Assuming you have an image for the goblin
                    pbGameImage.Image = Properties.Resources.goblin;
                    pbGameImage.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case "right_passage":
                    // Assuming you have an image for the chest
                    pbGameImage.Image = Properties.Resources.chest;
                    pbGameImage.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case "fight_goblin":
                    // Maybe a victorious image or a combat image
                    pbGameImage.Image = Properties.Resources.dead_goblin;
                    pbGameImage.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case "open_chest":
                    // An image of a locked chest
                    pbGameImage.Image = Properties.Resources.locked_chest;
                    pbGameImage.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case "use_key":
                    // An image of an open chest with gold
                    pbGameImage.Image = Properties.Resources.gold_chest;
                    pbGameImage.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case "restart":
                    // Reset to the start image
                    pbGameImage.Image = Properties.Resources.cave;
                    pbGameImage.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                    // You might not need an image for "invalid" as it's a temporary message
                    // default:
                    //     pbGameImage.Image = null; // Clear image for unknown states or invalid input
                    //     break;
            }
            // --- End New Logic ---
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // No action needed here
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string playerInput = txtPlayInput.Text;
            gameManager.ProcessPlayerInput(playerInput);
            DisplayGameOutputAndImage(); // Call the updated method
        }

        private void txtPlayInput_KeyDown(object sender, KeyEventArgs e)
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