using DNDTextGame;
using System.Drawing;
using System.Windows.Media;

namespace dndTextGame
{
    public partial class Form1 : Form
    {
        private GameManager gameManager;
        private MediaPlayer mediaPlayer; // Declare a MediaPlayer instance

        public Form1()
        {
            InitializeComponent();
            gameManager = new GameManager();
            DisplayGameOutputAndImage(); // Changed to new method
        }
        // --- Initialize and Play Ambient Sound ---
        mediaPlayer = new MediaPlayer();
        // Assign the audio resource to the MediaPlayer
        // Important: Resources.damp_cave will be a byte array for audio.
        // We need to save it to a temporary file or use a MemoryStream.
        // For simplicity and quick start, let's create a temp file.
        string tempAudioPath = Path.GetTempFileName();
        File.WriteAllBytes(tempAudioPath, Properties.Resources.damp_cave); // Assuming damp_cave is the name in resources

            mediaPlayer.Open(new Uri(tempAudioPath));

            // Set up event to loop the audio
            mediaPlayer.MediaEnded += MediaPlayer_MediaEnded;
            mediaPlayer.Play();
            // --- End Ambient Sound Initialization ---
            // Event handler to loop the audio
        private void MediaPlayer_MediaEnded(object sender, EventArgs e)
        {
            mediaPlayer.Position = TimeSpan.Zero; // Reset position to start
            mediaPlayer.Play(); // Play again
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