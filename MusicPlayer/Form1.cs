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

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                player.URL = openFileDialog.FileName;
                player.controls.play();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }
    }
}