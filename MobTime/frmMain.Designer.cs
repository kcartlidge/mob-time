namespace MobTime
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolMain = new System.Windows.Forms.ToolStrip();
            this.mnuStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPause = new System.Windows.Forms.ToolStripButton();
            this.mnuStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMinutes = new System.Windows.Forms.ToolStripDropDownButton();
            this.directionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPeople = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAbout = new System.Windows.Forms.ToolStripButton();
            this.lblTimer = new System.Windows.Forms.Label();
            this.toolMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolMain
            // 
            this.toolMain.AllowMerge = false;
            this.toolMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolMain.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStart,
            this.toolStripSeparator3,
            this.mnuPause,
            this.mnuStop,
            this.toolStripSeparator2,
            this.mnuMinutes,
            this.mnuPeople,
            this.toolStripSeparator1,
            this.mnuAbout});
            this.toolMain.Location = new System.Drawing.Point(0, 0);
            this.toolMain.Name = "toolMain";
            this.toolMain.Padding = new System.Windows.Forms.Padding(4, 0, 1, 0);
            this.toolMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolMain.Size = new System.Drawing.Size(196, 25);
            this.toolMain.TabIndex = 0;
            // 
            // mnuStart
            // 
            this.mnuStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuStart.Image = ((System.Drawing.Image)(resources.GetObject("mnuStart.Image")));
            this.mnuStart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuStart.Name = "mnuStart";
            this.mnuStart.Size = new System.Drawing.Size(23, 22);
            this.mnuStart.Text = "Start the timer";
            this.mnuStart.Click += new System.EventHandler(this.Start);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // mnuPause
            // 
            this.mnuPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuPause.Enabled = false;
            this.mnuPause.Image = ((System.Drawing.Image)(resources.GetObject("mnuPause.Image")));
            this.mnuPause.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuPause.Name = "mnuPause";
            this.mnuPause.Size = new System.Drawing.Size(23, 22);
            this.mnuPause.Text = "Pause the timer";
            this.mnuPause.Click += new System.EventHandler(this.Pause);
            // 
            // mnuStop
            // 
            this.mnuStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuStop.Enabled = false;
            this.mnuStop.Image = ((System.Drawing.Image)(resources.GetObject("mnuStop.Image")));
            this.mnuStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuStop.Name = "mnuStop";
            this.mnuStop.Size = new System.Drawing.Size(23, 22);
            this.mnuStop.Text = "Stop the timer";
            this.mnuStop.Click += new System.EventHandler(this.Stop);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // mnuMinutes
            // 
            this.mnuMinutes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuMinutes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.directionToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14,
            this.toolStripMenuItem15,
            this.toolStripMenuItem16,
            this.toolStripMenuItem17,
            this.toolStripMenuItem18,
            this.toolStripMenuItem19});
            this.mnuMinutes.Image = ((System.Drawing.Image)(resources.GetObject("mnuMinutes.Image")));
            this.mnuMinutes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuMinutes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuMinutes.Name = "mnuMinutes";
            this.mnuMinutes.ShowDropDownArrow = false;
            this.mnuMinutes.Size = new System.Drawing.Size(20, 22);
            this.mnuMinutes.Text = "Options";
            // 
            // directionToolStripMenuItem
            // 
            this.directionToolStripMenuItem.Checked = true;
            this.directionToolStripMenuItem.CheckOnClick = true;
            this.directionToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.directionToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directionToolStripMenuItem.Name = "directionToolStripMenuItem";
            this.directionToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.directionToolStripMenuItem.Text = "Count &Up";
            this.directionToolStripMenuItem.Click += new System.EventHandler(this.ChangeDirection);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(164, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(167, 26);
            this.toolStripMenuItem2.Text = "1 minute";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ChooseMinutes);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(167, 26);
            this.toolStripMenuItem3.Text = "2 minutes";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.ChooseMinutes);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(167, 26);
            this.toolStripMenuItem4.Text = "3 minutes";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.ChooseMinutes);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(167, 26);
            this.toolStripMenuItem5.Text = "4 minutes";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.ChooseMinutes);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(167, 26);
            this.toolStripMenuItem6.Text = "5 minutes";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.ChooseMinutes);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(167, 26);
            this.toolStripMenuItem7.Text = "6 minutes";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.ChooseMinutes);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(167, 26);
            this.toolStripMenuItem8.Text = "7 minutes";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.ChooseMinutes);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(167, 26);
            this.toolStripMenuItem9.Text = "8 minutes";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.ChooseMinutes);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(167, 26);
            this.toolStripMenuItem10.Text = "9 minutes";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.ChooseMinutes);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(167, 26);
            this.toolStripMenuItem11.Text = "10 minutes";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.ChooseMinutes);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(167, 26);
            this.toolStripMenuItem13.Text = "15 minutes";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.ChooseMinutes);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(167, 26);
            this.toolStripMenuItem14.Text = "20 minutes";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.ChooseMinutes);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(167, 26);
            this.toolStripMenuItem15.Text = "25 minutes";
            this.toolStripMenuItem15.Click += new System.EventHandler(this.ChooseMinutes);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(167, 26);
            this.toolStripMenuItem16.Text = "30 minutes";
            this.toolStripMenuItem16.Click += new System.EventHandler(this.ChooseMinutes);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(167, 26);
            this.toolStripMenuItem17.Text = "45 minutes";
            this.toolStripMenuItem17.Click += new System.EventHandler(this.ChooseMinutes);
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(167, 26);
            this.toolStripMenuItem18.Text = "60 minutes";
            this.toolStripMenuItem18.Click += new System.EventHandler(this.ChooseMinutes);
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(167, 26);
            this.toolStripMenuItem19.Text = "90 minutes";
            this.toolStripMenuItem19.Click += new System.EventHandler(this.ChooseMinutes);
            // 
            // mnuPeople
            // 
            this.mnuPeople.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuPeople.Image = ((System.Drawing.Image)(resources.GetObject("mnuPeople.Image")));
            this.mnuPeople.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuPeople.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuPeople.Name = "mnuPeople";
            this.mnuPeople.Size = new System.Drawing.Size(23, 22);
            this.mnuPeople.Text = "People";
            this.mnuPeople.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // mnuAbout
            // 
            this.mnuAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuAbout.Image = ((System.Drawing.Image)(resources.GetObject("mnuAbout.Image")));
            this.mnuAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(23, 22);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.About);
            // 
            // lblTimer
            // 
            this.lblTimer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTimer.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(0, 30);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(196, 48);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(196, 78);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.toolMain);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mob Time (10 minutes)";
            this.TopMost = true;
            this.toolMain.ResumeLayout(false);
            this.toolMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolMain;
        private System.Windows.Forms.ToolStripDropDownButton mnuMinutes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19;
        private System.Windows.Forms.ToolStripButton mnuStart;
        private System.Windows.Forms.ToolStripButton mnuPause;
        private System.Windows.Forms.ToolStripButton mnuStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton mnuAbout;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem directionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton mnuPeople;
    }
}

