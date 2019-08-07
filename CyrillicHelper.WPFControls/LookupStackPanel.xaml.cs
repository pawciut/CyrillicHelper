using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CyrillicHelper.WPFControls
{
    /// <summary>
    /// Interaction logic for LookupStackPanel.xaml
    /// </summary>
    public partial class LookupStackPanel : UserControl
    {
        public LookupStackPanel()
        {
            InitializeComponent();
        }

        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if(sender != null 
                && sender is System.Windows.Controls.TextBox txt
                &&  txt.DataContext is ILookupRecordViewModel lrvm)
            {
                lrvm.SelectionStart = txt.SelectionStart;
                lrvm.SelectionLength = txt.SelectionLength;
            }
        }
    }
}
