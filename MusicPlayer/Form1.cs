using WMPLib;


namespace MusicPlayer
{
    public partial class MusicForm : Form
    {   
        WindowsMediaPlayer player = new WindowsMediaPlayer();   // Windows Media Player instance
        OpenFileDialog openFileDialog = new OpenFileDialog();   // Open file dialog instance to select music files
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();    // Timer instance to keep track of time
        List<string> playlist = new List<string>(); // List to keep track of playlist
        int currentSongIndex = 0; // Index of current song being played
       

        public MusicForm()
        {
            InitializeComponent();

            // Setting filter for open file dialog to select only music files
            openFileDialog.Filter = "Music Files|*.mp3;*.wma;*.wav"; 
            openFileDialog.Title = "Select a Music File";
            openFileDialog.Multiselect = true; 

            // Setting timer interval to 1000 milliseconds
            timer.Interval = 1000; 
            timer.Tick += new EventHandler(UpdateTime);

            MusicGridView.CellClick += MusicGridView_CellClick;
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
                // Adding selected music files to playlist
                playlist.AddRange(openFileDialog.FileNames);

                // Data source of the grid
                MusicGridView.DataSource = null;
                MusicGridView.DataSource = playlist.Select(x => new { Song = Path.GetFileName(x) }).ToList(); // Adding musics to grid
                MusicGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Fill the entire DataGrid

                // Checking if playlist is not empty
                if (playlist.Count > 0)
                {
                    player.URL = playlist[0];   // Setting first music file to player
                    player.controls.play();     // Playing music
                    currentlyPlay.Text = Path.GetFileName(playlist[0]);   // Updating currently playing text
                    timer.Start();      // Starting timer
                }
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

        // Method to skip music in current playlist
        private void NextButton_Click(object sender, EventArgs e)
        {
            // Checking if the playlist is not empty and there is next song in the playlist
            if (playlist.Count > 0 && currentSongIndex + 1 < playlist.Count)
            {
                selectedRowIndex++;   // Incrementing selectedRowIndex index
                player.URL = playlist[selectedRowIndex];   // Setting next song to player
                player.controls.play();     // Playing music
                currentlyPlay.Text = Path.GetFileName(playlist[selectedRowIndex]);   // Updating currently playing text
                timer.Start();      // Starting timer
            }
        }
        // Method to go back music in current playlist
        private void PreviousButton_Click(object sender, EventArgs e)
        {
            // Checking if the playlist is not empty and there is previous song in the playlist
            if (playlist.Count > 0 && currentSongIndex - 1 < playlist.Count)
            {
                selectedRowIndex--;   // Incrementing selectedRowIndex index
                player.URL = playlist[selectedRowIndex];   // Setting next song to player
                player.controls.play();     // Playing music
                currentlyPlay.Text = Path.GetFileName(playlist[selectedRowIndex]);   // Updating currently playing text
                timer.Start();      // Starting timer
            }
        }

        // Method to play music when selected cell pressed
        private int selectedRowIndex;   
        private void MusicGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;  // So that we can use it on different method

            player.URL = playlist[e.RowIndex]; //   Setting music to file to player base on which row pressed
            player.controls.play();     // Playing Music
            currentlyPlay.Text = Path.GetFileName(playlist[e.RowIndex]);    // Updating currently playing text
            if (MusicTimer.Text == "")  // Starting timer if the timer stop
            {
                timer.Start();
            }
        }

        // Method to control volume
        private void VolumeBar_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = VolumeBar.Value;   // Updating volume value
        }

    }
}