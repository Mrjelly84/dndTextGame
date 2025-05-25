using DNDTextGame;
using System.Drawing;
using System.Windows.Forms;
using System.Media; 


namespace dndTextGame
{
    public partial class Form1 : Form
    {
        private GameManager gameManager;

        private SoundPlayer soundPlayer;

        public Form1()
        {
            InitializeComponent();
            rtbGameOutput.TabStop = false;
            txtPlayInput.Focus();

            gameManager = new GameManager();


            soundPlayer = new SoundPlayer();


            soundPlayer.Stream = Properties.Resources.damp_cave; // Assign the WAV resource stream


            soundPlayer.PlayLooping(); // Plays the sound repeatedly


            DisplayGameOutputAndImage();
        }


        private void DisplayGameOutputAndImage()
        {
            rtbGameOutput.Clear();
            string currentGameState = gameManager.GetGameState(); // Get the raw state from GameManager
            string gameText = gameManager.GetGameOutput();        // Get the text output

            rtbGameOutput.AppendText(gameText + "\n\n");
            txtPlayInput.Clear();
            txtPlayInput.Focus();

            // --- New Logic for Image Display ---
            switch (currentGameState) // Use the raw game state to determine the image
            {
                case "start":
                    pbGameImage.Image = Properties.Resources.cave;
                    pbGameImage.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case "left_passage":
                    pbGameImage.Image = Properties.Resources.goblin;
                    pbGameImage.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case "right_passage":
                    pbGameImage.Image = Properties.Resources.chest;
                    pbGameImage.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case "fight_goblin":
                    pbGameImage.Image = Properties.Resources.dead_goblin;
                    pbGameImage.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case "open_chest":
                    pbGameImage.Image = Properties.Resources.locked_chest;
                    pbGameImage.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case "use_key":
                    pbGameImage.Image = Properties.Resources.gold_chest;
                    pbGameImage.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case "restart":
                    pbGameImage.Image = Properties.Resources.cave;
                    pbGameImage.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                txtPlayInput.Focus();
            }
        }

        private void Form1_Closing(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            soundPlayer.Dispose();
            soundPlayer = null;
            Application.Exit();
        }
   
    }
}