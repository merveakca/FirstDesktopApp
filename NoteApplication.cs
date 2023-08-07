using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstDesktopApp
{
    public partial class NoteApplication : Form
    {
        public NoteApplication()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var title = txtTitle.Text;
            var date = dtNoteDate.Value;
            var category = cbchose.SelectedItem;
            var note = txtNote.Text;
            string result = date + " " + title + " " + category + " " + note;
            lbNotes.Items.Add(result);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedItem = lbNotes.SelectedItem;
            lbNotes.Items.Remove(selectedItem);
        }
    }
}
