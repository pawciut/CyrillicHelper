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
    public partial class DictionaryForm : Form
    {
        const string ButtonColumnName_ToHandwriting = "btnToHandwriting";

        public LookupForm lookupForm;

        public DictionaryForm()
        {
            InitializeComponent();

            if (AlphabetViewModel.CommonDictionary != null)
            {
                dataGridView1.DataSource = AlphabetViewModel.CommonDictionary;
            }

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = ButtonColumnName_ToHandwriting;
                button.HeaderText = "To Handwriting";
                button.Text = "To Handwriting";
                button.UseColumnTextForButtonValue = true;
                this.dataGridView1.Columns.Add(button);
            }

        }

        private void btnAlwaysOnTop_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
            btnAlwaysOnTop.BackColor = this.TopMost ? SystemColors.ActiveCaption : SystemColors.Control;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns[ButtonColumnName_ToHandwriting].Index)
            {
                var newRecordText = (string) dataGridView1.Rows[e.RowIndex].Cells[2].Value;//TODO: convert to cyrilic?
                lookupForm.AddRecord(newRecordText);


            }
        }
    }
}
