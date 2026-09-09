namespace MusicPlayer
{
  public partial class FormMain : Form
  {
    readonly System.Windows.Media.MediaPlayer player;
    bool isPlaying, isDraggingSeekBar, isMediaLoaded;

    int SelectedSongIndex
    {
      get { return listViewPlaylist.SelectedIndices.Count > 0 ? listViewPlaylist.SelectedIndices[0] : -1; }
      set
      {
        if (value < 0 || value >= listViewPlaylist.Items.Count)
          listViewPlaylist.SelectedIndices.Clear();
        else
          listViewPlaylist.Items[value].Selected = true;
      }
    }

    int SongsLoaded => listViewPlaylist.Items.Count;

    public FormMain()
    {
      InitializeComponent();

      player = new();
      player.Volume = trackBarVolume.Value / 100.0;
      player.MediaOpened += Player_MediaOpened;
      player.MediaEnded += Player_MediaEnded;
      player.MediaFailed += Player_MediaFailed;
    }

    void FormMain_SizeChanged(object sender, EventArgs e)
    {
      columnHeaderTitle.Width = -2; // Auto-size last column width
    }

    void ButtonOpenFiles_Click(object sender, EventArgs e)
    {
      if (openFileDialog.ShowDialog() != DialogResult.OK) return;

      listViewPlaylist.Items.Clear();
      int song = 1;
      foreach (var path in openFileDialog.FileNames)
      {
        var lvi = new ListViewItem(song++.ToString());
        lvi.SubItems.Add(System.IO.Path.GetFileNameWithoutExtension(path));
        lvi.Tag = path;
        listViewPlaylist.Items.Add(lvi);
      }
      columnHeaderTitle.Width = -2; // Auto-size last column width
    }

    void ButtonPrevious_Click(object sender, EventArgs e)
    {
      PlayRelative(forward: false);
    }

    void ButtonPlayPause_Click(object sender, EventArgs e)
    {
      if (SongsLoaded == 0) return;

      if (SelectedSongIndex < 0)
        LoadTrack(0, autoPlay: true);
      else
      {
        isPlaying = !isPlaying;
        UpdatePlayPauseState();
      }
    }

    void ButtonStop_Click(object sender, EventArgs e)
    {
      StopPlayback();
    }

    void ButtonNext_Click(object sender, EventArgs e)
    {
      PlayRelative(forward: true);
    }

    void TrackBarSeek_MouseDown(object sender, MouseEventArgs e)
    {
      isDraggingSeekBar = true;
    }

    void TrackBarSeek_MouseUp(object sender, MouseEventArgs e)
    {
      isDraggingSeekBar = false;

      if (isMediaLoaded)
        player.Position = TimeSpan.FromSeconds(trackBarSeek.Value);
    }

    void TrackBarVolume_ValueChanged(object sender, EventArgs e)
    {
      player.Volume = trackBarVolume.Value / 100.0;
    }

    void ListViewPlaylist_DoubleClick(object sender, EventArgs e)
    {
      LoadTrack(SelectedSongIndex, autoPlay: true);
    }

    void Player_MediaOpened(object? sender, EventArgs e)
    {
      isMediaLoaded = true;

      if (player.NaturalDuration.HasTimeSpan)
        trackBarSeek.Maximum = Math.Max(1, (int)player.NaturalDuration.TimeSpan.TotalSeconds);
    }

    void Player_MediaEnded(object? sender, EventArgs e)
    {
      if (SongsLoaded == 0) return;

      if (SelectedSongIndex == SongsLoaded - 1)
        StopPlayback();
      else
        PlayRelative(forward: true);
    }

    void Player_MediaFailed(object? sender, System.Windows.Media.ExceptionEventArgs e)
    {
      MessageBox.Show($"Could not play file:\n{e.ErrorException.Message}", "Playback error",
                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    void TimerPosition_Tick(object sender, EventArgs e)
    {
      if (isDraggingSeekBar || !isMediaLoaded) return;

      var position = player.Position;
      var duration = player.NaturalDuration.HasTimeSpan ? player.NaturalDuration.TimeSpan : TimeSpan.Zero;

      int seconds = (int)position.TotalSeconds;

      if (seconds <= trackBarSeek.Maximum)
        trackBarSeek.Value = seconds;

      labelTime.Text = $"{FormatTime(position)} / {FormatTime(duration)}";
    }

    string FormatTime(TimeSpan time) => time.ToString(@"mm\:ss");

    void LoadTrack(int songIndex, bool autoPlay)
    {
      if (songIndex < 0 || songIndex >= SongsLoaded) return;

      SelectedSongIndex = songIndex;
      isMediaLoaded = true;
      string songFilePath = listViewPlaylist.Items[songIndex].Tag?.ToString() ?? string.Empty;
      player.Open(new Uri(songFilePath));
      labelNowPlaying.Text = System.IO.Path.GetFileNameWithoutExtension(songFilePath);
      SelectedSongIndex = songIndex;

      isPlaying = autoPlay;
      UpdatePlayPauseState();
    }

    void UpdatePlayPauseState()
    {
      if (isPlaying)
      {
        player.Play();
        timerPosition.Start();
        buttonPlayPause.Text = "⏸";

      }
      else
      {
        player.Pause();
        timerPosition.Stop();
        buttonPlayPause.Text = "▶";
      }
    }

    void PlayRelative(bool forward)
    {
      if (SongsLoaded == 0) return;

      int nextIndex;
      nextIndex = SelectedSongIndex + (forward ? 1 : -1);

      if (nextIndex < 0 || nextIndex > SongsLoaded - 1)
        StopPlayback();
      else
        LoadTrack(nextIndex, autoPlay: true);
    }

    void StopPlayback()
    {
      isPlaying = false;
      UpdatePlayPauseState();
      player.Stop();
      isMediaLoaded = false;
      SelectedSongIndex = -1;
      labelNowPlaying.Text = "No track loaded";
      labelTime.Text = "00:00 / 00:00";
      trackBarSeek.Value = 0;
    }
  }
}
