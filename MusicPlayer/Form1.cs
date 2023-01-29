using WMPLib;


namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.URL = @"C:\Users\Evaluation Software\source\repos\MusicPlayer\MusicPlayer\music tes\Bcalm - Elements - rose fields.mp3";
            player.controls.play();
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