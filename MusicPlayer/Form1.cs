using WMPLib;


namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        OpenFileDialog openFileDialog = new OpenFileDialog();
  
        public Form1()
        {
            InitializeComponent();
            openFileDialog.Filter = "Music Files|*.mp3;*.wma;*.wav";
            openFileDialog.Title = "Select a Music File";
        }
        //play button
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                player.URL = openFileDialog.FileName;
                player.controls.play();
                currentlyPlay.Text = openFileDialog.SafeFileName;
                
                
            }
        }
        //stop button
        private void button2_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }
        //pause button
        private void button3_Click(object sender, EventArgs e)
        {
            player.controls.pause();
            currentlyPlay.Text = "";
        }
    }
}