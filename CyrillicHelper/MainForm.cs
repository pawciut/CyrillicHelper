using CyrillicHelper.WPFControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyrillicHelper
{
    public partial class MainForm : Form
    {
        

        public MainForm()
        {
            InitializeComponent();
            if(alphabetWPFControl.Child is System.Windows.FrameworkElement)
            {
                var wpfControl = alphabetWPFControl.Child as System.Windows.FrameworkElement;
                wpfControl.DataContext = new AlphabetViewModel();
            }

            lookupForm = new LookupForm();
            btnLookupWindow_Click(this, new EventArgs());
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Materials from http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/Alphabet.htm");
        }

        LookupForm lookupForm;

        private void btnLookupWindow_Click(object sender, EventArgs e)
        {
            lookupForm.Show();
        }
    }
}
