using System;
using System.Windows.Forms;
using WMPLib;


namespace MusicPlayer
{
    public partial class Form1 : Form
    {   
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        OpenFileDialog openFileDialog = new OpenFileDialog();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();  
  
        public Form1()
        {
            InitializeComponent();
            openFileDialog.Filter = "Music Files|*.mp3;*.wma;*.wav"; 
            openFileDialog.Title = "Select a Music File";
            timer.Interval = 1000;
            timer.Tick += new EventHandler(UpdateTime);
        }
        // update the timer
        private void UpdateTime(object sender, EventArgs e)
        {
            MusicTimer.Text = player.controls.currentPositionString;
        }

        //play button
        private void button1_Click(object sender, EventArgs e)
        {
            // pop out the explorer
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                player.URL = openFileDialog.FileName;
                player.controls.play();
                currentlyPlay.Text = openFileDialog.SafeFileName;
                timer.Start();
            }
        }
        //stop button
        private void button2_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            currentlyPlay.Text = "";
            MusicTimer.Text = "";
        }
        //pause button
        private void button3_Click(object sender, EventArgs e)
        {
            // this check if the music is playing or not
            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                player.controls.pause();
            }
            else if (player.playState == WMPPlayState.wmppsPaused)
            {
                player.controls.play();
            }
        }
    }
}