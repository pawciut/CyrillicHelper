using CyrillicHelper.WPFControls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyrillicHelper
{
    public class LookupStackPanelViewModel : ViewModelBase
    {

        ObservableCollection<LookupRecordViewModel> records;
        public ObservableCollection<LookupRecordViewModel> Records {
            get { return records; }
            set { SetProperty(ref records, value); }
        }

        public LookupStackPanelViewModel()
        {
            Records = new ObservableCollection<LookupRecordViewModel>();
            Records.Add(new LookupRecordViewModel());
        }


    }
}
