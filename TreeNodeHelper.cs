using System.Collections.Generic;
using System.Windows.Forms;

namespace Template
{
    public static class TreeNodeHelper
    {
        public static void Edit(TreeNode node, string key, object value)
        {
            if (!(node.Tag is Dictionary<string, object>))
            {
                Dictionary<string, object> data = new Dictionary<string, object> {{key, value}};
                node.Tag = data;
            }
            else
            {
                Dictionary<string, object> data = (Dictionary<string, object>) node.Tag;
                data[key] = value;
                node.Tag = data;
            }
        }

        public static T Get<T>(TreeNode node, string key)
        {
            if (!(node.Tag is Dictionary<string, object> data))
            {
                return default(T);
            }

            if (data.ContainsKey(key))
            {
                return (T) data[key];
            }
            else
            {
                return default(T);
            }
        }
    }
}