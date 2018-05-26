using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Template
{
    public partial class EditTemplate : Form
    {
        protected Dictionary<string, Dictionary<string, string>> AllPlaceHolders =
            new Dictionary<string, Dictionary<string, string>>();

        public Action<Dictionary<string, Dictionary<string, string>>> Del;

        public EditTemplate(Dictionary<string, Dictionary<string, string>> allPlaceHolders)
        {
            InitializeComponent();

            AllPlaceHolders = allPlaceHolders;
        }

        private void EditTemplate_Load(object sender, EventArgs e)
        {
            foreach (var holder in AllPlaceHolders)
            {
                listBox1.Items.Add(holder.Key);
            }

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedIndex.ToString());
        }

        private void delete_Click(object sender, EventArgs e)
        {
            AllPlaceHolders.Remove(listBox1.SelectedItem.ToString());
            SyncItems();
        }

        protected void SyncItems()
        {
            listBox1.Items.Clear();
            foreach (var holder in AllPlaceHolders)
            {
                listBox1.Items.Add(holder.Key);
            }
        }

        private void renameBtn_Click(object sender, EventArgs e)
        {
            RenamePlaceholder dialog = new RenamePlaceholder(listBox1.SelectedItem.ToString());
            dialog.Del += RenameItem;
            DialogResult result = dialog.ShowDialog();

        }

        protected void RenameItem(string key, string newName)
        {
            AllPlaceHolders = AllPlaceHolders.ToDictionary(k => k.Key == key ? newName : k.Key, k => k.Value);
            SyncItems();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            Del(AllPlaceHolders);

            DialogResult = DialogResult.OK;
        }
    }
}
