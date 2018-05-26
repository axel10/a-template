using System;
using System.Windows.Forms;

namespace Template
{
    public partial class RenamePlaceholder : Form
    {

        public Action<string,string> Del;
        private readonly string OName;

        public RenamePlaceholder(string oName)
        {
            InitializeComponent();
            OName = oName;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            Del(OName, textBox1.Text);
            DialogResult = DialogResult.OK;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.Cancel;
        }
    }
}
