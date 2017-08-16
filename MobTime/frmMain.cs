using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MobTime
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// Possible states for the form/stopwatch.
        /// </summary>
        private enum States
        {
            Stopped,
            Running,
            Paused,
            Closing
        }

        /// <summary>
        /// All configuration options.
        /// </summary>
        private Options Options;

        /// <summary>
        /// Current state of the form/stopwatch.
        /// </summary>
        private States State = States.Stopped;

        /// <summary>
        /// Runs to provide regular UI updates.
        /// </summary>
        private Timer UITimer;

        /// <summary>
        /// Runs to measure elapsed time.
        /// </summary>
        private Stopwatch CounterStopwatch;

        public frmMain()
        {
            InitializeComponent();

            // Attempt to handle high DPI screens a little better.
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

            // Check whether the saved duration is a valid one.
            Options = Config.Load(new Options { CountUpwards = false, Duration = 10 });
            var ok = false;
            foreach (var itemObj in mnuMinutes.DropDownItems)
            {
                if (itemObj is ToolStripMenuItem)
                {
                    // Check each duration menu option.
                    var item = (ToolStripMenuItem)itemObj;
                    var minsArr = item.Text.Split(" ".ToCharArray(), 2);
                    if (minsArr.Length > 0)
                    {
                        // Check if the first 'word' of the menu item is a number.
                        var minsText = minsArr[0];
                        if (int.TryParse(minsText, out int mins))
                        {
                            // If it is, and it matches the saved value, use it.
                            if (mins == Options.Duration)
                            {
                                ok = true;
                                ChooseMinutes(itemObj, null);
                                break;
                            }
                        }
                    }
                }
            }

            // Default for where there is no usable saved value.
            if (!ok)
            {
                Options.Duration = 10;
            }
            SaveOptions();

            // Set up the UI update timer and the stopwatch.
            CounterStopwatch = new Stopwatch();
            UITimer = new Timer();
            UITimer.Tick += UITimer_Tick;
            UITimer.Interval = 250;
            UpdateElapsed();
        }

        /// <summary>
        /// Maintains a consistent and updated UI.
        /// </summary>
        private void UpdateElapsed()
        {
            // Calculate the basics of time passed.
            var over = CounterStopwatch.Elapsed.TotalMinutes > Options.Duration;
            var mins = CounterStopwatch.Elapsed.Minutes;
            var secs = CounterStopwatch.Elapsed.Seconds;

            // If enough time elapsed or counting down selected, switch to time remaining.
            if (!(Options.CountUpwards || over))
            {
                var expected = Options.Duration * 60;
                var elapsedSeconds = CounterStopwatch.Elapsed.TotalSeconds;
                var remains = expected - Convert.ToInt32(elapsedSeconds);
                mins = remains / 60;
                secs = remains % 60;
            }

            // Set the display text and colour.
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

        /// <summary>
        /// Extracts and uses the selected Duration Menu option's minutes value.
        /// </summary>
        private void ChooseMinutes(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            var minsText = item.Text.Split(" ".ToCharArray(), 2)[0];
            Options.Duration = int.Parse(minsText);
            Text = $"{item.Text}";
            SaveOptions();
        }

        /// <summary>
        /// UpdateElapsed proxy method for timer-tick UI updates.
        /// </summary>
        private void UITimer_Tick(object sender, EventArgs e)
        {
            UpdateElapsed();
        }

        /// <summary>
        /// The Play button has been clicked.
        /// </summary>
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

        /// <summary>
        /// The Pause button has been clicked.
        /// </summary>
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

        /// <summary>
        /// The Stop button has been clicked.
        /// </summary>
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

        /// <summary>
        /// The About button has been clicked.
        /// </summary>
        private void About(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright K Cartlidge, 2017.", "Mob Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// The count direction (up/down) has been changed.
        /// </summary>
        private void ChangeDirection(object sender, EventArgs e)
        {
            Options.CountUpwards = !Options.CountUpwards;
            SaveOptions();
            UpdateElapsed();
        }

        /// <summary>
        /// The form has gained focus.
        /// </summary>
        private void FormActivated(object sender, EventArgs e)
        {
            FormBright(sender, e);
        }

        /// <summary>
        /// The form has lost focus.
        /// </summary>
        private void FormDeactivated(object sender, EventArgs e)
        {
            if (State == States.Closing)
            {
                return;
            }
            FormDim(sender, e);
        }

        /// <summary>
        /// The form is now being closed.
        /// </summary>
        private void ClosingForm(object sender, FormClosingEventArgs e)
        {
            State = States.Closing;
        }

        /// <summary>
        /// Set the form to full opacity.
        /// </summary>
        private void FormBright(object sender, EventArgs e)
        {
            this.Opacity = 1;
            this.Focus();
        }

        /// <summary>
        /// Lower the form opacity.
        /// </summary>
        private void FormDim(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        /// <summary>
        /// Stores the current options and updates any related UI.
        /// </summary>
        private void SaveOptions()
        {
            Config.Save(Options);
            var direction = Options.CountUpwards ? "Down" : "Up";
            directionToolStripMenuItem.Text = "Count &" + direction;
            Application.DoEvents();
        }
    }
}
