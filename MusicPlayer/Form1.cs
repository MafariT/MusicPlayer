using WMPLib;


namespace MusicPlayer
{
    public partial class MusicForm : Form
    {   
        WindowsMediaPlayer player = new WindowsMediaPlayer();   // Windows Media Player instance
        OpenFileDialog openFileDialog = new OpenFileDialog();   // Open file dialog instance to select music files
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();    // Timer instance to keep track of time

        public MusicForm()
        {
            InitializeComponent();

            // Setting filter for open file dialog to select only music files
            openFileDialog.Filter = "Music Files|*.mp3;*.wma;*.wav"; 
            openFileDialog.Title = "Select a Music File";

            // Setting timer interval to 1000 milliseconds
            timer.Interval = 1000; 
            timer.Tick += new EventHandler(UpdateTime);
        }
        // Method to update time on the form
        private void UpdateTime(object sender, EventArgs e)
        {
            MusicTimer.Text = player.controls.currentPositionString;     // Updating current time

            // Checking if there is any media being played and its duration is greater than 0
            if (player.currentMedia != null && player.currentMedia.duration > 0)    
            {
                // Updating current time and total time
                MusicTimer.Text = player.controls.currentPositionString + " / " + player.currentMedia.durationString;
            }
            VolumeBar.Value = (player.settings.volume);     // Set the VolumeBar value to current volume level
        }

        // Method to play music file
        private void button1_Click(object sender, EventArgs e)
        {
            // Showing open file dialog to select music file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                player.URL = openFileDialog.FileName;   // Setting music file to player
                player.controls.play();     // Playing music
                currentlyPlay.Text = openFileDialog.SafeFileName;   // Updating currently playing text
                timer.Start();      // Starting timer
            }
        }

        // Method to pause/play music
        private void button3_Click(object sender, EventArgs e)
        {
            // This check if the music is playing or not
            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                player.controls.pause();    // Pausing music
            }
            else if (player.playState == WMPPlayState.wmppsPaused)
            {
                player.controls.play();     // Playing music
            }
        }

        // Method to stop music
        private void button2_Click(object sender, EventArgs e)
        {
            player.controls.stop();     // Stopping music
            currentlyPlay.Text = "";    // Updating currently playing text
            timer.Stop();   // Stopping timer
            MusicTimer.Text = "";   // Clearing time text
        }

        private void VolumeBar_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = VolumeBar.Value;   // Updating volume value
        }
    }
}