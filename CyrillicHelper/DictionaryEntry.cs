using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyrillicHelper
{
    public class DictionaryEntry
    {
        public DictionaryEntry(string meaning, string russian, string category)
        {
            Meaning = meaning;
            Russian = russian;
            Category = category;
        }

        public string Meaning { get; set; }
        public string Russian { get; set; }
        public string Category { get; set; }
    }
}
