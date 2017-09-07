using System.Diagnostics;
using System.Windows.Forms;

namespace MobTime
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void HomeLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://kcartlidge.com");
        }
    }
}
