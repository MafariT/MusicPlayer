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
        private void InitializeComponent()
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
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicGridView)).BeginInit();
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
            this.PlayButton.Click += new System.EventHandler(this.button1_Click);
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
            this.StopButton.Click += new System.EventHandler(this.button2_Click);
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
            this.PauseButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // currentlyPlay
            // 
            this.currentlyPlay.AutoSize = true;
            this.currentlyPlay.Location = new System.Drawing.Point(12, 43);
            this.currentlyPlay.Name = "currentlyPlay";
            this.currentlyPlay.Size = new System.Drawing.Size(0, 15);
            this.currentlyPlay.TabIndex = 3;
            // 
            // MusicTimer
            // 
            this.MusicTimer.AutoSize = true;
            this.MusicTimer.Location = new System.Drawing.Point(12, 64);
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
            this.VolumeBar.Size = new System.Drawing.Size(45, 67);
            this.VolumeBar.TabIndex = 5;
            this.VolumeBar.Scroll += new System.EventHandler(this.VolumeBar_Scroll);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.Location = new System.Drawing.Point(780, 85);
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
            this.MusicGridView.Location = new System.Drawing.Point(12, 114);
            this.MusicGridView.Name = "MusicGridView";
            this.MusicGridView.RowTemplate.Height = 25;
            this.MusicGridView.Size = new System.Drawing.Size(843, 206);
            this.MusicGridView.TabIndex = 6;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(12, 85);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(75, 23);
            this.PreviousButton.TabIndex = 8;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // MusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 333);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button PlayButton;
        private Button StopButton;
        private Button PauseButton;
        private Label currentlyPlay;
        private Label MusicTimer;
        private TrackBar VolumeBar;
        private Button NextButton;
        private DataGridView MusicGridView;
        private Button PreviousButton;
    }
}