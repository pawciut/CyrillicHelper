using CyrillicHelper.WPFControls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyrillicHelper
{
    public partial class LookupForm : Form
    {
        LookupStackPanelViewModel lookupStackPanelViewModel;
        public LookupForm()
        {
            InitializeComponent();

            if (wpfControlHost.Child is System.Windows.FrameworkElement)
            {
                var wpfControl = wpfControlHost.Child as System.Windows.FrameworkElement;
                wpfControl.DataContext = lookupStackPanelViewModel = new LookupStackPanelViewModel();
            }
        }

        private void btnAlwaysOnTop_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
            btnAlwaysOnTop.BackColor = this.TopMost? SystemColors.ActiveCaption : SystemColors.Control;
        }

        private void LookupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            Letter.MuteSounds = !Letter.MuteSounds;
            btnSound.BackColor = Letter.MuteSounds ? SystemColors.ActiveCaption : SystemColors.Control;
        }

        private void LookupForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.M)
                btnSound_Click(this, new EventArgs());
            if (e.KeyChar == (char)Keys.T)
                btnAlwaysOnTop_Click(this, new EventArgs());
        }

        private void LookupForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(true)
            {

            }
        }
    }
}
