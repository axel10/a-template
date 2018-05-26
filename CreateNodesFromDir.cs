using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Template
{
    public partial class CreateNodesFromDir : Form
    {
        public CreateNodesFromDir()
        {
            InitializeComponent();
        }

        public Action<string, string> Del;

        private void ok_Click(object sender, EventArgs e)
        {
            Del(pathBox.Text,fileExtBox.Text);
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();

            if (!string.IsNullOrEmpty(dialog.SelectedPath))
            {
                pathBox.Text = dialog.SelectedPath;
            }
        }
    }
}
