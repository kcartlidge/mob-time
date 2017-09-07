namespace MobTime
{
    partial class frmAbout
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lnkHome = new System.Windows.Forms.LinkLabel();
            this.lblBy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(349, 73);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Mob Time";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lnkHome
            // 
            this.lnkHome.Cursor = System.Windows.Forms.Cursors.Default;
            this.lnkHome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lnkHome.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkHome.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkHome.Location = new System.Drawing.Point(0, 124);
            this.lnkHome.Name = "lnkHome";
            this.lnkHome.Size = new System.Drawing.Size(349, 41);
            this.lnkHome.TabIndex = 3;
            this.lnkHome.TabStop = true;
            this.lnkHome.Text = "Click here to visit my site";
            this.lnkHome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkHome.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lnkHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HomeLinkClicked);
            // 
            // lblBy
            // 
            this.lblBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBy.Location = new System.Drawing.Point(0, 73);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(349, 51);
            this.lblBy.TabIndex = 4;
            this.lblBy.Text = "Copyright K Cartlidge, 2017";
            this.lblBy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmAbout
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(349, 165);
            this.Controls.Add(this.lblBy);
            this.Controls.Add(this.lnkHome);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.LinkLabel lnkHome;
        private System.Windows.Forms.Label lblBy;
    }
}