namespace MusicPlayer
{
  partial class FormMain
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      components = new System.ComponentModel.Container();
      timerPosition = new System.Windows.Forms.Timer(components);
      labelNowPlaying = new Label();
      trackBarSeek = new TrackBar();
      labelTime = new Label();
      buttonOpenFiles = new Button();
      buttonPrevious = new Button();
      buttonPlayPause = new Button();
      buttonStop = new Button();
      buttonNext = new Button();
      label2 = new Label();
      trackBarVolume = new TrackBar();
      label1 = new Label();
      panelPlayControls = new Panel();
      panelTrackBar = new Panel();
      panelVolume = new Panel();
      toolTip = new ToolTip(components);
      openFileDialog = new OpenFileDialog();
      listViewPlaylist = new ListView();
      columnHeaderSong = new ColumnHeader();
      columnHeaderTitle = new ColumnHeader();
      ((System.ComponentModel.ISupportInitialize)trackBarSeek).BeginInit();
      ((System.ComponentModel.ISupportInitialize)trackBarVolume).BeginInit();
      panelPlayControls.SuspendLayout();
      panelTrackBar.SuspendLayout();
      panelVolume.SuspendLayout();
      SuspendLayout();
      // 
      // timerPosition
      // 
      timerPosition.Interval = 250;
      timerPosition.Tick += TimerPosition_Tick;
      // 
      // labelNowPlaying
      // 
      labelNowPlaying.AutoEllipsis = true;
      labelNowPlaying.BackColor = Color.FromArgb(30, 30, 30);
      labelNowPlaying.Dock = DockStyle.Top;
      labelNowPlaying.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      labelNowPlaying.ForeColor = Color.White;
      labelNowPlaying.Location = new Point(0, 30);
      labelNowPlaying.Name = "labelNowPlaying";
      labelNowPlaying.Size = new Size(425, 40);
      labelNowPlaying.TabIndex = 1;
      labelNowPlaying.Text = "No track loaded";
      labelNowPlaying.TextAlign = ContentAlignment.MiddleLeft;
      // 
      // trackBarSeek
      // 
      trackBarSeek.BackColor = Color.FromArgb(30, 30, 30);
      trackBarSeek.Location = new Point(9, 12);
      trackBarSeek.Maximum = 100;
      trackBarSeek.Name = "trackBarSeek";
      trackBarSeek.Size = new Size(310, 45);
      trackBarSeek.TabIndex = 3;
      trackBarSeek.TickStyle = TickStyle.None;
      toolTip.SetToolTip(trackBarSeek, "Seek bar");
      trackBarSeek.MouseDown += TrackBarSeek_MouseDown;
      trackBarSeek.MouseUp += TrackBarSeek_MouseUp;
      // 
      // labelTime
      // 
      labelTime.AutoSize = true;
      labelTime.BackColor = Color.FromArgb(45, 45, 48);
      labelTime.ForeColor = Color.White;
      labelTime.Location = new Point(325, 12);
      labelTime.Name = "labelTime";
      labelTime.Size = new Size(72, 15);
      labelTime.TabIndex = 4;
      labelTime.Text = "00:00 / 00:00";
      // 
      // buttonOpenFiles
      // 
      buttonOpenFiles.BackColor = Color.FromArgb(45, 45, 48);
      buttonOpenFiles.FlatAppearance.BorderColor = Color.FromArgb(63, 63, 70);
      buttonOpenFiles.FlatStyle = FlatStyle.Flat;
      buttonOpenFiles.ForeColor = Color.White;
      buttonOpenFiles.Location = new Point(3, 6);
      buttonOpenFiles.Name = "buttonOpenFiles";
      buttonOpenFiles.Size = new Size(87, 41);
      buttonOpenFiles.TabIndex = 5;
      buttonOpenFiles.Text = "Open FIles...";
      toolTip.SetToolTip(buttonOpenFiles, "Select files to play");
      buttonOpenFiles.UseVisualStyleBackColor = false;
      buttonOpenFiles.Click += ButtonOpenFiles_Click;
      // 
      // buttonPrevious
      // 
      buttonPrevious.BackColor = Color.FromArgb(45, 45, 48);
      buttonPrevious.FlatAppearance.BorderColor = Color.FromArgb(63, 63, 70);
      buttonPrevious.FlatStyle = FlatStyle.Flat;
      buttonPrevious.Font = new Font("Arial Narrow", 14.25F);
      buttonPrevious.ForeColor = Color.Cyan;
      buttonPrevious.Location = new Point(97, 6);
      buttonPrevious.Name = "buttonPrevious";
      buttonPrevious.Size = new Size(41, 41);
      buttonPrevious.TabIndex = 6;
      buttonPrevious.Text = "⏮";
      toolTip.SetToolTip(buttonPrevious, "Previous track");
      buttonPrevious.UseVisualStyleBackColor = false;
      buttonPrevious.Click += ButtonPrevious_Click;
      // 
      // buttonPlayPause
      // 
      buttonPlayPause.BackColor = Color.FromArgb(45, 45, 48);
      buttonPlayPause.FlatAppearance.BorderColor = Color.FromArgb(63, 63, 70);
      buttonPlayPause.FlatStyle = FlatStyle.Flat;
      buttonPlayPause.Font = new Font("Arial Narrow", 14.25F);
      buttonPlayPause.ForeColor = Color.Cyan;
      buttonPlayPause.Location = new Point(144, 6);
      buttonPlayPause.Name = "buttonPlayPause";
      buttonPlayPause.Size = new Size(75, 41);
      buttonPlayPause.TabIndex = 7;
      buttonPlayPause.Text = "▶";
      toolTip.SetToolTip(buttonPlayPause, "Play/Pause");
      buttonPlayPause.UseVisualStyleBackColor = false;
      buttonPlayPause.Click += ButtonPlayPause_Click;
      // 
      // buttonStop
      // 
      buttonStop.BackColor = Color.FromArgb(45, 45, 48);
      buttonStop.FlatAppearance.BorderColor = Color.FromArgb(63, 63, 70);
      buttonStop.FlatStyle = FlatStyle.Flat;
      buttonStop.Font = new Font("Arial Narrow", 14.25F);
      buttonStop.ForeColor = Color.Cyan;
      buttonStop.Location = new Point(225, 6);
      buttonStop.Name = "buttonStop";
      buttonStop.Size = new Size(41, 41);
      buttonStop.TabIndex = 8;
      buttonStop.Text = "⏹";
      toolTip.SetToolTip(buttonStop, "Stop");
      buttonStop.UseVisualStyleBackColor = false;
      buttonStop.Click += ButtonStop_Click;
      // 
      // buttonNext
      // 
      buttonNext.BackColor = Color.FromArgb(45, 45, 48);
      buttonNext.FlatAppearance.BorderColor = Color.FromArgb(63, 63, 70);
      buttonNext.FlatStyle = FlatStyle.Flat;
      buttonNext.Font = new Font("Arial Narrow", 14.25F);
      buttonNext.ForeColor = Color.Cyan;
      buttonNext.Location = new Point(272, 6);
      buttonNext.Name = "buttonNext";
      buttonNext.Size = new Size(48, 41);
      buttonNext.TabIndex = 9;
      buttonNext.Text = "⏭";
      toolTip.SetToolTip(buttonNext, "Next track");
      buttonNext.UseVisualStyleBackColor = false;
      buttonNext.Click += ButtonNext_Click;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.ForeColor = Color.White;
      label2.Location = new Point(12, 15);
      label2.Name = "label2";
      label2.Size = new Size(47, 15);
      label2.TabIndex = 10;
      label2.Text = "Volume";
      // 
      // trackBarVolume
      // 
      trackBarVolume.BackColor = Color.FromArgb(30, 30, 30);
      trackBarVolume.Location = new Point(75, 15);
      trackBarVolume.Maximum = 100;
      trackBarVolume.Name = "trackBarVolume";
      trackBarVolume.Size = new Size(337, 45);
      trackBarVolume.TabIndex = 11;
      trackBarVolume.TickStyle = TickStyle.None;
      toolTip.SetToolTip(trackBarVolume, "Volume control");
      trackBarVolume.Value = 40;
      trackBarVolume.ValueChanged += TrackBarVolume_ValueChanged;
      // 
      // label1
      // 
      label1.BackColor = Color.FromArgb(30, 30, 30);
      label1.Dock = DockStyle.Top;
      label1.ForeColor = Color.White;
      label1.Location = new Point(0, 0);
      label1.Name = "label1";
      label1.Size = new Size(425, 30);
      label1.TabIndex = 0;
      label1.Text = "Now Playing";
      label1.TextAlign = ContentAlignment.MiddleLeft;
      // 
      // panelPlayControls
      // 
      panelPlayControls.Controls.Add(buttonOpenFiles);
      panelPlayControls.Controls.Add(buttonPrevious);
      panelPlayControls.Controls.Add(buttonPlayPause);
      panelPlayControls.Controls.Add(buttonStop);
      panelPlayControls.Controls.Add(buttonNext);
      panelPlayControls.Dock = DockStyle.Bottom;
      panelPlayControls.Location = new Point(0, 327);
      panelPlayControls.Name = "panelPlayControls";
      panelPlayControls.Size = new Size(425, 53);
      panelPlayControls.TabIndex = 15;
      // 
      // panelTrackBar
      // 
      panelTrackBar.Controls.Add(labelTime);
      panelTrackBar.Controls.Add(trackBarSeek);
      panelTrackBar.Dock = DockStyle.Bottom;
      panelTrackBar.Location = new Point(0, 283);
      panelTrackBar.Name = "panelTrackBar";
      panelTrackBar.Size = new Size(425, 44);
      panelTrackBar.TabIndex = 16;
      // 
      // panelVolume
      // 
      panelVolume.Controls.Add(trackBarVolume);
      panelVolume.Controls.Add(label2);
      panelVolume.Dock = DockStyle.Bottom;
      panelVolume.Location = new Point(0, 380);
      panelVolume.Name = "panelVolume";
      panelVolume.Size = new Size(425, 45);
      panelVolume.TabIndex = 17;
      // 
      // openFileDialog
      // 
      openFileDialog.Filter = "Audio files (*.mp3;*.wav;*.wma;*.m4a)|*.mp3;*.wav;*.wma;*.m4a|All files (*.*)|*.*";
      openFileDialog.Multiselect = true;
      openFileDialog.Title = "Open a Music File";
      // 
      // listViewPlaylist
      // 
      listViewPlaylist.BackColor = Color.FromArgb(30, 30, 30);
      listViewPlaylist.Columns.AddRange(new ColumnHeader[] { columnHeaderSong, columnHeaderTitle });
      listViewPlaylist.Dock = DockStyle.Fill;
      listViewPlaylist.ForeColor = Color.White;
      listViewPlaylist.FullRowSelect = true;
      listViewPlaylist.Location = new Point(0, 70);
      listViewPlaylist.MultiSelect = false;
      listViewPlaylist.Name = "listViewPlaylist";
      listViewPlaylist.Size = new Size(425, 213);
      listViewPlaylist.TabIndex = 19;
      listViewPlaylist.UseCompatibleStateImageBehavior = false;
      listViewPlaylist.View = View.Details;
      listViewPlaylist.DoubleClick += ListViewPlaylist_DoubleClick;
      // 
      // columnHeaderSong
      // 
      columnHeaderSong.Text = "Song";
      // 
      // columnHeaderTitle
      // 
      columnHeaderTitle.Text = "Title";
      columnHeaderTitle.Width = 360;
      // 
      // FormMain
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.FromArgb(30, 30, 30);
      ClientSize = new Size(425, 425);
      Controls.Add(listViewPlaylist);
      Controls.Add(panelTrackBar);
      Controls.Add(panelPlayControls);
      Controls.Add(panelVolume);
      Controls.Add(labelNowPlaying);
      Controls.Add(label1);
      MinimumSize = new Size(420, 400);
      Name = "FormMain";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Music Player";
      SizeChanged += FormMain_SizeChanged;
      ((System.ComponentModel.ISupportInitialize)trackBarSeek).EndInit();
      ((System.ComponentModel.ISupportInitialize)trackBarVolume).EndInit();
      panelPlayControls.ResumeLayout(false);
      panelTrackBar.ResumeLayout(false);
      panelTrackBar.PerformLayout();
      panelVolume.ResumeLayout(false);
      panelVolume.PerformLayout();
      ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Timer timerPosition;
    private Label labelNowPlaying;
    private TrackBar trackBarSeek;
    private Label labelTime;
    private Button buttonOpenFiles;
    private Button buttonPrevious;
    private Button buttonPlayPause;
    private Button buttonStop;
    private Button buttonNext;
    private Label label2;
    private TrackBar trackBarVolume;
    private Label label1;
    private Panel panelPlayControls;
    private Panel panelTrackBar;
    private Panel panelVolume;
    private ToolTip toolTip;
    private OpenFileDialog openFileDialog;
    private ListView listViewPlaylist;
    private ColumnHeader columnHeaderSong;
    private ColumnHeader columnHeaderTitle;
  }
}