using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyrillicHelper
{
    public interface ILookupRecordViewModel
    {
        int SelectionStart { get; set; }
        int SelectionLength { get; set; }
    }

}
