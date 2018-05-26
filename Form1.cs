using Microsoft.WindowsAPICodePack.Taskbar;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Template
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        protected readonly string rootPath = @"D:\templateTest";
        protected string FileExt = "txt";
        protected dynamic dirData;

        protected TreeNode SelectedNode;
        protected TreeNode EditingNode;

        protected Dictionary<string, Dictionary<string, string>> AllPlaceHolders =
            new Dictionary<string, Dictionary<string, string>>();

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            TreeNode rootNode = new TreeNode()
            {
                Text = Path.GetFileName(rootPath)
            };

            TreeNodeHelper.Edit(rootNode, "isDir", "1");

            dirView.Nodes.Add(rootNode);

/*            string allText = File.ReadAllText("Test_Data/demo.json");
            dynamic dirsObj = JsonConvert.DeserializeObject(allText);
            CreateTreeNodes(dirsObj, dirView.Nodes[0]);*/

            dirView.Nodes[0].Expand();

            comboBox1.Items.Add("默认组");
            AllPlaceHolders.Add("默认组", new Dictionary<string, string>());
            comboBox1.SelectedIndex = comboBox1.Items.Count - 1;

//            Placeholders.Add("123", "$$$");
//            Placeholders.Add("1231", "$$$1");

            dirView.ImageList = treeViewIcon;

            //declaration of our list, windowHandle is the handle of the window 
            //you want the JumpList to be attached to
            JumpList list = JumpList.CreateJumpListForIndividualWindow
                (TaskbarManager.Instance.ApplicationId,this.Handle);

            //defining a new Custom Category called Actions
            JumpListCustomCategory userActionsCategory = new JumpListCustomCategory("Actions");

            //defining the JumpListLink "Clear History"
            JumpListLink userActionLink = new JumpListLink
                (Assembly.GetEntryAssembly().Location, "Clear History");
            userActionLink.Arguments = "-1";

            //add this link to the Actions Category
            userActionsCategory.AddJumpListItems(userActionLink);

            //finally add the category to the JumpList
            list.AddCustomCategories(userActionsCategory);

            list.Refresh();

        }

        protected void DGKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyData.ToString());
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            Console.WriteLine(m.ToString());
            ;
        }

        /// <summary>
        /// 将字典对象添加到表格
        /// </summary>
        public void InitPlaceholders(Dictionary<string, string> nPlaceholders)
        {
            dataGridView1.Rows.Clear();
            foreach (var pair in nPlaceholders)
            {
                var row = new DataGridViewRow();
                int i = dataGridView1.Rows.Add(row);
                dataGridView1.Rows[i].Cells[0].Value = pair.Key;
                dataGridView1.Rows[i].Cells[1].Value = pair.Value;
            }
        }

        /// <summary>
        /// 打开结果文件
        /// </summary>
        public void OpenResult()
        {
            OpenFileDialog pathDialog = new OpenFileDialog();
            pathDialog.Filter = "json文件|*.json";
            pathDialog.ShowDialog();
            string path = pathDialog.FileName;
//            string path = @"d:/test.json";
            if (!string.IsNullOrEmpty(path))
            {
                string resultTxt = File.ReadAllText(path);
                dynamic result = JsonConvert.DeserializeObject(resultTxt);
                string rootName = result.rootName;
                dynamic oPlaceholders = result.placeholders;
                dynamic main = result.main;
                FileExt = result.fileExt;
                fileExtBox.Text = FileExt;

                comboBox1.Items.Clear();
                string currentPlaceholder = result.currentPlaceholder;
                placeGroupName.Text = currentPlaceholder;

                var allPlaceHolders = new Dictionary<string, Dictionary<string, string>>();

                //添加所有结果文件中的placeholder到allPlaceHolders
                int i = 0;
                int j = 0;
                foreach (JProperty o in oPlaceholders)
                {
                    string pName = o.Name;
                    var pContent = new Dictionary<string, string>();
                    foreach (JProperty property in o.Value)
                    {
                        pContent.Add(property.Name, property.Value.ToString());
                    }

                    allPlaceHolders.Add(pName, pContent);
                    comboBox1.Items.Add(pName);

                    if (pName.Equals(currentPlaceholder))
                    {
                        j = i;
                    }

                    i++;
                }

                AllPlaceHolders = allPlaceHolders;
                comboBox1.SelectedIndex = j;
                dirView.Nodes.Clear();
                dirView.Nodes.Add(rootName);
                CreateTreeNodes(main, dirView.Nodes[0]);
                InitPlaceholders(AllPlaceHolders[comboBox1.SelectedItem.ToString()]);

                
            }
        }


        public void CreateTreeNodeFromDirSys(string path, string fileExt)
        {
            string[] exts = fileExt.Split(',');

            if (Directory.Exists(path))
            {
                dirView.Nodes.Clear();

                TreeNode rootNode = new TreeNode() {Text = Path.GetFileName(path)};

                CreateTreeNodesDo(path, rootNode, exts);

                dirView.Nodes.Add(rootNode);
            }
        }

        public void CreateTreeNodesDo(string path, TreeNode node, string[] exts)
        {
            string[] files = Directory.GetFiles(path).Concat(Directory.GetDirectories(path)).ToArray();


            foreach (string file in files)
            {
                if (File.Exists(file))
                {
                    if (exts.Contains(Path.GetExtension(file).Substring(1)))
                    {
                        TreeNode newNode = new TreeNode()
                        {
                            Text = Path.GetFileName(file),
                            ImageIndex = 1,
                            SelectedImageIndex = 1
                        };
                        TreeNodeHelper.Edit(newNode, "isDir", "0");
                        string content = File.ReadAllText(file);
                        TreeNodeHelper.Edit(newNode, "template", content);

                        node.Nodes.Add(newNode);
                    }
                }
                else if (Directory.Exists(file))
                {
                    TreeNode newNode = new TreeNode()
                    {
                        Text = Path.GetFileName(file),
                        ImageIndex = 0,
                        SelectedImageIndex = 0
                    };
                    TreeNodeHelper.Edit(newNode, "isDir", "1");
                    node.Nodes.Add(newNode);
                    CreateTreeNodesDo(file, newNode, exts);
                }
            }
        }


        /// <summary>
        /// 生成树节点
        /// </summary>
        /// <param name="dirsObjs"></param>
        /// <param name="node"></param>
        public void CreateTreeNodes(dynamic dirsObjs, TreeNode node)
        {
            foreach (JObject dirsObj in dirsObjs)
            {
                bool flag = dirsObj.ContainsKey("children");

                if (flag)
                {
                    TreeNode newNode = new TreeNode
                    {
                        Text = dirsObj.GetValue("name").ToString(),
                        ImageIndex = 0,
                        SelectedImageIndex = 0,
                    };

                    TreeNodeHelper.Edit(newNode, "isDir", "1");

                    node.Nodes.Add(newNode);
                    var children = dirsObj.GetValue("children");
                    if (children != null)
                    {
                        CreateTreeNodes(children, newNode);
                    }
                }
                else
                {
                    TreeNode newNode = new TreeNode()
                    {
                        Text = dirsObj.GetValue("name").ToString()
                    };
                    if (!string.IsNullOrEmpty(dirsObj.GetValue("template")?.ToString()))
                    {
                        //                        newNode.Tag = dirsObj.GetValue("template").ToString();
                        TreeNodeHelper.Edit(newNode, "template", dirsObj.GetValue("template").ToString());
                        TreeNodeHelper.Edit(newNode, "isDir", 0);
                    }

                    if (dirsObj.GetValue("isDir")?.ToString() == "1")
                    {
                        newNode.ImageIndex = 0;
                        newNode.SelectedImageIndex = 0;
                        TreeNodeHelper.Edit(newNode, "isDir", "1");
                    }
                    else
                    {
                        newNode.ImageIndex = 1;
                        newNode.SelectedImageIndex = 1;
                        TreeNodeHelper.Edit(newNode, "isDir", "0");
                    }

                    node.Nodes.Add(newNode);
                }
            }
        }


        /// <summary>
        /// treeView选中后事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dirView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
        }


        /// <summary>
        /// 保存节点名修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dirView_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            //            bool isDir = e.Node.Nodes.Count != 0;
            if (dirView.SelectedNode != null)
            {
                bool isDir = TreeNodeHelper.Get<string>(dirView.SelectedNode, "isDir") == "1";

                if (isDir)
                {
                    textBox1.Enabled = false;
                    return;
                }
                else
                {
                    textBox1.Enabled = true;
                    SelectedNode = e.Node;
                    //this.textBox1.Text = e.Node.Tag == null ? "" : e.Node.Tag.ToString();

                    textBox1.Text = TreeNodeHelper.Get<string>(e.Node, "template");

                    Console.WriteLine(1);
                }
            }


            if (EditingNode == null)
            {
                return;
            }
            else
            {
                EditingNode.EndEdit(false);
                EditingNode = null;
            }
        }


        /// <summary>
        /// 双击后开始修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dirView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            e.Node.BeginEdit();
            e.Node.Expand();
            EditingNode = e.Node;
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        /// <summary>
        /// 文本改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            TreeNodeHelper.Edit(dirView.SelectedNode, "template", textBox1.Text);
        }


        /// <summary>
        /// 保存json编辑结果
        /// </summary>
        /// <param name="node"></param>
        protected void SaveResult(TreeNode node)
        {

            SaveFileDialog folder = new SaveFileDialog();
            folder.RestoreDirectory = true;
            folder.Filter = "json文件|*.json";

            folder.ShowDialog();

            if (!string.IsNullOrEmpty(folder.FileName))
            {
                List<dynamic> children = AddChildren(dirView.Nodes[0]);

                dynamic result = new
                {
                    placeholders = AllPlaceHolders,
                    main = children,
                    rootName = dirView.Nodes[0].Text,
                    currentPlaceholder = comboBox1.SelectedItem.ToString(),
                    fileExt = FileExt
                };

                var o = JsonConvert.SerializeObject(result);

                File.WriteAllText(folder.FileName, o);
                new Tip("保存成功").Show();
            }
        }


        /// <summary>
        /// 递归生成treeView的json数据
        /// </summary>
        /// <param name="tr"></param>
        /// <returns></returns>
        public List<dynamic> AddChildren(TreeNode tr)
        {
            List<dynamic> list = new List<dynamic>();

            if (tr.Nodes.Count > 0)
            {
                foreach (TreeNode treeNode in tr.Nodes)
                {
                    if (treeNode.Nodes.Count > 0)
                    {
                        List<dynamic> children = AddChildren(treeNode);
                        dynamic item = new {children = children, name = treeNode.Text, isDir = "1"};
                        list.Add(item);
                    }
                    else
                    {
                        //if (string.IsNullOrEmpty(treeNode.Tag?.ToString()))
                        if (string.IsNullOrEmpty(TreeNodeHelper.Get<string>(treeNode, "template")))
                        {
                            if (TreeNodeHelper.Get<string>(treeNode, "isDir") == "1")
                            {
                                list.Add(new {name = treeNode.Text, isDir = "1"});
                            }
                            else
                            {
                                list.Add(new {name = treeNode.Text});
                            }
                        }
                        else
                        {
                            //list.Add(new {name = treeNode.Text, template = treeNode.Tag.ToString()});
                            list.Add(new
                            {
                                name = treeNode.Text,
                                template = TreeNodeHelper.Get<string>(treeNode, "template"),
                                isDir = "0"
                            });
                        }
                    }
                }
            }
            else
            {
                list.Add(new {name = tr.Text});
            }

            return list;
        }


        /// <summary>
        /// 在硬盘上创建文件及文件夹
        /// </summary>
        /// <param name="node"></param>
        /// <param name="pathList"></param>
        protected void CreateFiles(TreeNode node, List<string> pathList, string path)
        {
            string parentPath = Path.Combine(Path.GetFullPath(path), string.Join("/", pathList.ToArray()));

            var finalName = ReplaceToken(node.Text);

            if (node.Nodes.Count > 0)
            {
                Directory.CreateDirectory(Path.Combine(parentPath, finalName));
                pathList.Add(finalName);
                foreach (TreeNode treeNode in node.Nodes)
                {
                    List<string> list = DeepCopyByBin(pathList);
                    CreateFiles(treeNode, list, path);
                }
            }

            else
            {
                if (node.Text.Split('.').Length > 1)
                {
                    //File.WriteAllText(Path.Combine(parentPath, node.Text), ReplaceToken(node.Tag?.ToString()));
                    File.WriteAllText(Path.Combine(parentPath, finalName),
                        ReplaceToken(TreeNodeHelper.Get<string>(node, "template")));
                }
                else
                {
                    if (TreeNodeHelper.Get<string>(node, "isDir") == "1")
                    {
                        Directory.CreateDirectory(Path.Combine(parentPath, finalName));
                        //ReplaceToken(node.Tag?.ToString()));
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(FileExt))
                        {
                            File.WriteAllText(Path.Combine(parentPath, $"{finalName}.{FileExt}"),
                                //ReplaceToken(node.Tag?.ToString()));
                                ReplaceToken(TreeNodeHelper.Get<string>(node, "template")));
                        }
                    }
                }
            }
        }


        /// <summary>
        /// 替换文本中的占位符
        /// </summary>
        /// <param name="template"></param>
        /// <returns></returns>
        public string ReplaceToken(string template)
        {
            if (string.IsNullOrEmpty(template))
            {
                return "";
            }

            foreach (KeyValuePair<string, string> pair in AllPlaceHolders[comboBox1.SelectedItem.ToString()])

            {
                template = template.Replace(pair.Key, pair.Value);
            }

            return template;
        }

        public static T DeepCopyByBin<T>(T obj)
        {
            object retval;
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                //序列化成流
                bf.Serialize(ms, obj);
                ms.Seek(0, SeekOrigin.Begin);
                //反序列化成对象
                retval = bf.Deserialize(ms);
                ms.Close();
            }

            return (T) retval;
        }


        private void createDirsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            if (Directory.Exists(path.SelectedPath))
            {
                CreateFiles(dirView.Nodes[0], new List<string>(), path.SelectedPath);
                new Tip("创建成功").Show();
            }
        }



        /// <summary>
        /// 占位符组表格被修改后事件
        /// </summary>
        /// <param name="keyData"></param>
        private void SyncPlaceholder()
        {
            MessageBox.Show("1");

            if (AllPlaceHolders[comboBox1.SelectedItem.ToString()] == null)
            {
                return;
            }

            AllPlaceHolders[comboBox1.SelectedItem.ToString()].Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null || row.Cells[1].Value == null)
                {
                    continue;
                }

                AllPlaceHolders[comboBox1.SelectedItem.ToString()]
                    .Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
            }
        }

        private void openResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenResult();
        }

        private void saveJsonResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveResult(dirView.Nodes[0]);
        }

        private void create_new_dir_Click(object sender, EventArgs e)
        {
            createDirOrFile(true);
        }

        protected void createDirOrFile(bool isDir)
        {
            if (dirView.SelectedNode == null)
            {
                Tip tip = new Tip();
                tip.Show();
            }
            else if (TreeNodeHelper.Get<string>(dirView.SelectedNode, "isDir") == "0")
            {
                Tip tip = new Tip("请选择文件夹");
                tip.Show();
            }
            else
            {
                bool isFirst = true;
                dirView.SelectedNode.Expand();
                int i = 0;
                while (true)
                {
                    bool b = false;
                    foreach (TreeNode node in dirView.SelectedNode.Nodes)
                    {
                        if (isDir)
                        {
                            b = node.Text.Equals(isFirst ? $"新建文件夹" : $"新建文件夹（{i}）");
                        }
                        else
                        {
                            b = node.Text.Equals(isFirst ? $"新建文件" : $"新建文件（{i}）");
                        }

                        if (b)
                        {
                            break;
                        }
                    }

                    if (b)
                    {
                        isFirst = false;
                        i++;
                    }
                    else
                    {
                        if (isDir)
                        {
                            TreeNode newNode = isFirst
                                ? new TreeNode()
                                {
                                    Text = $"新建文件夹",
                                    ImageIndex = 0,
                                    SelectedImageIndex = 0
                                }
                                : new TreeNode()
                                {
                                    Text = $"新建文件夹（{i}）",
                                    ImageIndex = 0,
                                    SelectedImageIndex = 0
                                };
                            newNode.BeginEdit();

                            TreeNodeHelper.Edit(newNode, "isDir", "1");

                            dirView.SelectedNode.Nodes.Add(newNode);
                            dirView.SelectedNode = newNode;
                            newNode.BeginEdit();
                        }
                        else
                        {
                            TreeNode newNode = isFirst
                                ? new TreeNode()
                                {
                                    Text = $"新建文件",
                                    ImageIndex = 1,
                                    SelectedImageIndex = 1
                                }
                                : new TreeNode()
                                {
                                    Text = $"新建文件（{i}）",
                                    ImageIndex = 1,
                                    SelectedImageIndex = 1
                                };
                            newNode.BeginEdit();

                            TreeNodeHelper.Edit(newNode, "isDir", "0");

                            dirView.SelectedNode.Nodes.Add(newNode);
                            dirView.SelectedNode = newNode;
                            newNode.BeginEdit();
                        }

                        break;
                    }
                }
            }
        }

        private void create_new_file_Click(object sender, EventArgs e)
        {
            createDirOrFile(false);
        }


        /// <summary>
        /// 弹出创建新标识符组的窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            NewPlaceholders newPlaceholders = new NewPlaceholders();
            newPlaceholders.Del += AddNewPlaceholders;
            newPlaceholders.AllPlaceHolders = AllPlaceHolders;
            newPlaceholders.ShowDialog();
        }

        /// <summary>
        /// 添加占位符组事件
        /// </summary>
        /// <param name="name"></param>
        protected void AddNewPlaceholders(string name)
        {
            AllPlaceHolders.Add(name, new Dictionary<string, string>());
//            comboBox1.Items.Add(name);
            SyncPhComboBox();
            comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
            InitPlaceholders(new Dictionary<string, string>());
        }

        /// <summary>
        /// 同步AllPlaceholder和ComboBox
        /// </summary>
        protected void SyncPhComboBox()
        {
            comboBox1.Items.Clear();
            foreach (var holder in AllPlaceHolders)
            {
                comboBox1.Items.Add(holder.Key);
            }
        }


        /// <summary>
        /// combobox选项改变后事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string s = comboBox1.SelectedItem.ToString();

            Dictionary<string, string> holder = AllPlaceHolders[s];
            InitPlaceholders(holder);
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Del键删除节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dirView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                if (dirView.SelectedNode.Parent != null)
                {
                    dirView.SelectedNode.Remove();
                }
            }
        }


        /// <summary>
        /// 文本框同步扩展名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            FileExt = fileExtBox.Text;
        }

        private void createNodesByDirSysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNodesFromDir fromDir = new CreateNodesFromDir();
            fromDir.Del += CreateTreeNodeFromDirSys;
            fromDir.Show();
        }

        private void editTemplateButton_Click(object sender, EventArgs e)
        {
            EditTemplate editTemplate = new EditTemplate(AllPlaceHolders);
            editTemplate.Del += DealNewAllPlaceholder;
            editTemplate.ShowDialog();
        }

        /// <summary>
        /// 处理模板编辑对话框确认
        /// </summary>
        /// <param name="allPlaceholder"></param>
        private void DealNewAllPlaceholder(Dictionary<string, Dictionary<string, string>> allPlaceholder)
        {
            AllPlaceHolders = allPlaceholder;
            SyncPhComboBox();
            comboBox1.SelectedIndex = 0;
            InitPlaceholders(AllPlaceHolders[comboBox1.SelectedItem.ToString()]);
        }

        private void savePlaceholderBtn_Click(object sender, EventArgs e)
        {
            SyncPlaceholder();
        }
    }
}