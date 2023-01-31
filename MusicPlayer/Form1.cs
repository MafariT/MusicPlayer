using TagLib;
using WMPLib;

namespace MusicPlayer
{
    public partial class MusicForm : Form
    {
        private WindowsMediaPlayer player = new WindowsMediaPlayer();   // Windows Media Player instance
        private OpenFileDialog openFileDialog = new OpenFileDialog();   // Open file dialog instance to select music files
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();    // Timer instance to keep track of time
        private List<string> playlist = new List<string>(); // List to keep track of playlist
        private PictureBox albumArtworkPictureBox = new PictureBox();   // Display picture
        private int currentSongIndex = 0; // Index of current song being played

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

            this.Controls.Add(albumArtworkPictureBox);
        }

        public void UpdateAlbumArtwork(string filePath)
        {
            // Use TagLib to extract the album artwork from the music file
            TagLib.File musicFile = TagLib.File.Create(filePath);
            IPicture albumArtwork = musicFile.Tag.Pictures[0];
            if (albumArtwork != null)
            {
                // Display the album artwork in the PictureBox
                using (var stream = new MemoryStream(albumArtwork.Data.Data))
                {
                    MusicPicture.Image = Image.FromStream(stream);
                }
            }
            else
            {
                // If there is no album artwork, display a default image
                albumArtworkPictureBox.Image = Image.FromFile("default.png");
            }
        }

        // Method to update stuff on the form
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
        private void PlayButton_Click(object sender, EventArgs e)
        {
            // Showing open file dialog to select music file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PlayMusic();
            }
        }

        // Method to pause/play music
        private void PauseButton_Click(object sender, EventArgs e)
        {
            PauseMusic();
        }

        // Method to stop music
        private void StopButton_Click(object sender, EventArgs e)
        {
            StopMusic();
        }

        // Method to skip music in current playlist
        private void NextButton_Click(object sender, EventArgs e)
        {
            // Checking if the playlist is not empty and there is next song in the playlist
            if (playlist.Count > 0 && currentSongIndex + 1 < playlist.Count)
            {
                PlayNextMusic();
            }
        }

        // Method to go back music in current playlist
        private void PreviousButton_Click(object sender, EventArgs e)
        {
            // Checking if the playlist is not empty and there is previous song in the playlist
            if (playlist.Count > 0 && currentSongIndex - 1 < playlist.Count)
            {
                PlayPrevMusic();
            }
        }

        // Method to play music when selected cell pressed
        private int selectedRowIndex;

        private void MusicGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;  // So that we can use it on different method
            PlaySelectCell();
        }

        // Method to control volume
        private void VolumeBar_Scroll(object sender, EventArgs e)
        {
            ControlVolume();
        }

        /* ---------------------------- CODE THAT CONTROL PLAY ----------------------------  */

        public void PlayMusic()
        {
            // Adding selected music files to playlist
            playlist.AddRange(openFileDialog.FileNames);

            // Displayed Image
            UpdateAlbumArtwork(openFileDialog.FileName);

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

        public void PauseMusic()
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

        public void StopMusic()
        {
            player.controls.stop();     // Stopping music
            currentlyPlay.Text = "";    // Updating currently playing text
            timer.Stop();   // Stopping timer
            MusicTimer.Text = "";   // Clearing time text
        }

        public void PlayNextMusic()
        {
            selectedRowIndex++;   // Incrementing selectedRowIndex index
            player.URL = playlist[selectedRowIndex];   // Setting next song to player
            player.controls.play();     // Playing music
            UpdateAlbumArtwork(playlist[selectedRowIndex]);    // Display Picture
            currentlyPlay.Text = Path.GetFileName(playlist[selectedRowIndex]);   // Updating currently playing text
            timer.Start();      // Starting timer
        }

        public void PlayPrevMusic()
        {
            selectedRowIndex--;   // Incrementing selectedRowIndex index
            player.URL = playlist[selectedRowIndex];   // Setting next song to player
            player.controls.play();     // Playing music
            UpdateAlbumArtwork(playlist[selectedRowIndex]);    // Display Picture
            currentlyPlay.Text = Path.GetFileName(playlist[selectedRowIndex]);   // Updating currently playing text
            timer.Start();      // Starting timer
        }

        public void PlaySelectCell()
        {
            player.URL = playlist[selectedRowIndex]; //   Setting music to file to player base on which row pressed
            player.controls.play();     // Playing Music
            UpdateAlbumArtwork(playlist[selectedRowIndex]);    // Display Picture
            currentlyPlay.Text = Path.GetFileName(playlist[selectedRowIndex]);    // Updating currently playing text
            if (MusicTimer.Text == "")  // Starting timer if the timer stop
            {
                timer.Start();
            }
        }

        public void ControlVolume()
        {
            player.settings.volume = VolumeBar.Value;   // Updating volume value
        }
    }
}