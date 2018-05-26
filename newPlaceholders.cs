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
    public partial class NewPlaceholders : Form
    {
        public NewPlaceholders()
        {
            InitializeComponent();
        }

        public Action<string> Del;
        public Dictionary<string, Dictionary<string, string>> AllPlaceHolders = new Dictionary<string, Dictionary<string, string>>();


        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            if (AllPlaceHolders.ContainsKey(name))
            {
                Tip tip = new Tip("该名称已存在");
                tip.Show();
                return;
            }

            Del(textBox1.Text);
            Close();
        }
    }
}
