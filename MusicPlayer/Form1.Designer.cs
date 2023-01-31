namespace MusicPlayer
{
     partial class MusicForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicForm));
            this.PlayButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.currentlyPlay = new System.Windows.Forms.Label();
            this.MusicTimer = new System.Windows.Forms.Label();
            this.VolumeBar = new System.Windows.Forms.TrackBar();
            this.NextButton = new System.Windows.Forms.Button();
            this.MusicGridView = new System.Windows.Forms.DataGridView();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.MusicPicture = new System.Windows.Forms.PictureBox();
            this.ShuffleButton = new System.Windows.Forms.Button();
            this.UnshoffleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PlayButton.Location = new System.Drawing.Point(293, 12);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(281, 23);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "PLAY";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StopButton.Location = new System.Drawing.Point(580, 12);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(100, 23);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "STOP";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PauseButton.Location = new System.Drawing.Point(187, 12);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(100, 23);
            this.PauseButton.TabIndex = 2;
            this.PauseButton.Text = "PAUSE";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // currentlyPlay
            // 
            this.currentlyPlay.AutoSize = true;
            this.currentlyPlay.Location = new System.Drawing.Point(12, 118);
            this.currentlyPlay.Name = "currentlyPlay";
            this.currentlyPlay.Size = new System.Drawing.Size(0, 15);
            this.currentlyPlay.TabIndex = 3;
            // 
            // MusicTimer
            // 
            this.MusicTimer.AutoSize = true;
            this.MusicTimer.Location = new System.Drawing.Point(12, 132);
            this.MusicTimer.Name = "MusicTimer";
            this.MusicTimer.Size = new System.Drawing.Size(0, 15);
            this.MusicTimer.TabIndex = 4;
            // 
            // VolumeBar
            // 
            this.VolumeBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VolumeBar.Location = new System.Drawing.Point(810, 12);
            this.VolumeBar.Maximum = 100;
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.VolumeBar.Size = new System.Drawing.Size(45, 100);
            this.VolumeBar.TabIndex = 5;
            this.VolumeBar.Scroll += new System.EventHandler(this.VolumeBar_Scroll);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.Location = new System.Drawing.Point(780, 150);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 7;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // MusicGridView
            // 
            this.MusicGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MusicGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MusicGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MusicGridView.Location = new System.Drawing.Point(12, 179);
            this.MusicGridView.Name = "MusicGridView";
            this.MusicGridView.RowTemplate.Height = 25;
            this.MusicGridView.Size = new System.Drawing.Size(843, 220);
            this.MusicGridView.TabIndex = 6;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(12, 150);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(75, 23);
            this.PreviousButton.TabIndex = 8;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // MusicPicture
            // 
            this.MusicPicture.BackColor = System.Drawing.Color.Transparent;
            this.MusicPicture.Location = new System.Drawing.Point(18, 12);
            this.MusicPicture.Name = "MusicPicture";
            this.MusicPicture.Size = new System.Drawing.Size(100, 100);
            this.MusicPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MusicPicture.TabIndex = 9;
            this.MusicPicture.TabStop = false;
            // 
            // ShuffleButton
            // 
            this.ShuffleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShuffleButton.Location = new System.Drawing.Point(699, 150);
            this.ShuffleButton.Name = "ShuffleButton";
            this.ShuffleButton.Size = new System.Drawing.Size(75, 23);
            this.ShuffleButton.TabIndex = 10;
            this.ShuffleButton.Text = "Shuffle";
            this.ShuffleButton.UseVisualStyleBackColor = true;
            this.ShuffleButton.Click += new System.EventHandler(this.ShuffleButton_Click);
            // 
            // UnshoffleButton
            // 
            this.UnshoffleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UnshoffleButton.Location = new System.Drawing.Point(618, 150);
            this.UnshoffleButton.Name = "UnshoffleButton";
            this.UnshoffleButton.Size = new System.Drawing.Size(75, 23);
            this.UnshoffleButton.TabIndex = 11;
            this.UnshoffleButton.Text = "Unshuffle";
            this.UnshoffleButton.UseVisualStyleBackColor = true;
            this.UnshoffleButton.Click += new System.EventHandler(this.UnshoffleButton_Click);
            // 
            // MusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 412);
            this.Controls.Add(this.UnshoffleButton);
            this.Controls.Add(this.ShuffleButton);
            this.Controls.Add(this.MusicPicture);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.MusicGridView);
            this.Controls.Add(this.VolumeBar);
            this.Controls.Add(this.MusicTimer);
            this.Controls.Add(this.currentlyPlay);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.PlayButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusicForm";
            this.Text = "Music Player";
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button PlayButton;
        public Button StopButton;
        public Button PauseButton;
        public Label currentlyPlay;
        public Label MusicTimer;
        public TrackBar VolumeBar;
        public Button NextButton;
        public DataGridView MusicGridView;
        public Button PreviousButton;
        public PictureBox MusicPicture;
        private Button ShuffleButton;
        private Button UnshoffleButton;
    }
}