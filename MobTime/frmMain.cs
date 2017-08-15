using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MobTime
{
    public partial class frmMain : Form
    {
        private enum States
        {
            Stopped,
            Running,
            Paused
        }

        private States State = States.Stopped;
        private int Duration = 10;
        private Timer UITimer;
        private Stopwatch CounterStopwatch;

        public frmMain()
        {
            InitializeComponent();

            // From: https://www.medo64.com/2014/01/scaling-toolstrip-with-dpi/
            using (var g = this.CreateGraphics())
            {
                var scale = Math.Max(g.DpiX, g.DpiY) / 96.0;
                var newScale = ((int)Math.Floor(scale * 100) / 50 * 50) / 100.0;
                if (newScale > 1)
                {
                    var newWidth = (int)(toolMain.ImageScalingSize.Width * newScale);
                    var newHeight = (int)(toolMain.ImageScalingSize.Height * newScale);
                    toolMain.ImageScalingSize = new Size(newWidth, newHeight);
                    toolMain.AutoSize = false;
                }
            }

            Duration = Config.Load(Duration);
            var ok = false;
            foreach (var itemObj in mnuMinutes.DropDownItems)
            {
                if (itemObj is ToolStripMenuItem)
                {
                    var item = (ToolStripMenuItem)itemObj;
                    var minsArr = item.Text.Split(" ".ToCharArray(), 2);
                    if (minsArr.Length > 0)
                    {
                        var minsText = minsArr[0];
                        if (int.TryParse(minsText, out int mins))
                        {
                            if (mins == Duration)
                            {
                                ok = true;
                                Text = $"Mob Time ({item.Text})";
                                break;
                            }
                        }
                    }
                }
            }
            if (!ok)
            {
                Duration = 10;
            }
            Config.Save(Duration);

            UITimer = new Timer();
            UITimer.Tick += UITimer_Tick;
            UITimer.Interval = 250;

            CounterStopwatch = new Stopwatch();
            UpdateElapsed();
        }

        private void UpdateElapsed()
        {
            var over = CounterStopwatch.Elapsed.TotalMinutes > Duration;
            var mins = CounterStopwatch.Elapsed.Minutes;
            var secs = CounterStopwatch.Elapsed.Seconds;
            if (!(directionToolStripMenuItem.Checked || over))
            {
                var expected = Duration * 60;
                var elapsedSeconds = CounterStopwatch.Elapsed.TotalSeconds;
                var remains = expected - Convert.ToInt32(elapsedSeconds);
                mins = remains / 60;
                secs = remains % 60;
            }
            lblTimer.Text = $"{mins:D2}:{secs:D2}";
            if (State == States.Stopped)
            {
                lblTimer.ForeColor = Color.Black;
            }
            else
            {
                lblTimer.ForeColor = over ? Color.Red : Color.Green;
            }
            Application.DoEvents();
        }

        private void ChooseMinutes(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            var minsText = item.Text.Split(" ".ToCharArray(), 2)[0];
            Duration = int.Parse(minsText);
            Text = $"Mob Time ({item.Text})";
            Config.Save(Duration);
        }

        private void UITimer_Tick(object sender, EventArgs e)
        {
            UpdateElapsed();
        }

        private void Start(object sender, EventArgs e)
        {
            if (State == States.Stopped)
            {
                CounterStopwatch.Reset();
            }
            State = States.Running;
            mnuStart.Enabled = false;
            mnuPause.Enabled = true;
            mnuStop.Enabled = true;
            UpdateElapsed();
            UITimer.Start();
            CounterStopwatch.Start();
        }

        private void Pause(object sender, EventArgs e)
        {
            State = States.Paused;
            mnuStart.Enabled = true;
            mnuPause.Enabled = false;
            mnuStop.Enabled = true;
            UITimer.Stop();
            CounterStopwatch.Stop();
            UpdateElapsed();
        }

        private void Stop(object sender, EventArgs e)
        {
            State = States.Stopped;
            mnuStart.Enabled = true;
            mnuPause.Enabled = false;
            mnuStop.Enabled = false;
            UITimer.Stop();
            CounterStopwatch.Stop();
            UpdateElapsed();
        }

        private void About(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright K Cartlidge, 2017.", "Mob Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChangeDirection(object sender, EventArgs e)
        {
            UpdateElapsed();
        }
    }
}
