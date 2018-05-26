namespace Template
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dirView = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.beginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDirsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveJsonResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNodesByDirSysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.create_new_file = new System.Windows.Forms.Button();
            this.treeViewIcon = new System.Windows.Forms.ImageList(this.components);
            this.create_new_dir = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.savePlaceholderBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new Template.MyDataGridView();
            this.placeholder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editTemplateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fileExtBox = new System.Windows.Forms.TextBox();
            this.placeGroupName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dirView
            // 
            this.dirView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dirView.HideSelection = false;
            this.dirView.LabelEdit = true;
            this.dirView.Location = new System.Drawing.Point(42, 0);
            this.dirView.Name = "dirView";
            this.dirView.Size = new System.Drawing.Size(181, 390);
            this.dirView.TabIndex = 0;
            this.dirView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.dirView_AfterSelect_1);
            this.dirView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.dirView_NodeMouseClick);
            this.dirView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.dirView_NodeMouseDoubleClick);
            this.dirView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dirView_KeyUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(769, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // beginToolStripMenuItem
            // 
            this.beginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openResultToolStripMenuItem,
            this.createDirsToolStripMenuItem,
            this.saveJsonResultToolStripMenuItem,
            this.createNodesByDirSysToolStripMenuItem});
            this.beginToolStripMenuItem.Name = "beginToolStripMenuItem";
            this.beginToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.beginToolStripMenuItem.Text = "文件";
            // 
            // openResultToolStripMenuItem
            // 
            this.openResultToolStripMenuItem.Name = "openResultToolStripMenuItem";
            this.openResultToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.openResultToolStripMenuItem.Text = "打开结果文件";
            this.openResultToolStripMenuItem.Click += new System.EventHandler(this.openResultToolStripMenuItem_Click);
            // 
            // createDirsToolStripMenuItem
            // 
            this.createDirsToolStripMenuItem.Name = "createDirsToolStripMenuItem";
            this.createDirsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.createDirsToolStripMenuItem.Text = "生成文件";
            this.createDirsToolStripMenuItem.Click += new System.EventHandler(this.createDirsToolStripMenuItem_Click);
            // 
            // saveJsonResultToolStripMenuItem
            // 
            this.saveJsonResultToolStripMenuItem.Name = "saveJsonResultToolStripMenuItem";
            this.saveJsonResultToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.saveJsonResultToolStripMenuItem.Text = "保存结果文件";
            this.saveJsonResultToolStripMenuItem.Click += new System.EventHandler(this.saveJsonResultToolStripMenuItem_Click);
            // 
            // createNodesByDirSysToolStripMenuItem
            // 
            this.createNodesByDirSysToolStripMenuItem.Name = "createNodesByDirSysToolStripMenuItem";
            this.createNodesByDirSysToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.createNodesByDirSysToolStripMenuItem.Text = "从目录生成模板";
            this.createNodesByDirSysToolStripMenuItem.Click += new System.EventHandler(this.createNodesByDirSysToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(229, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(520, 386);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(757, 412);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.create_new_file);
            this.tabPage1.Controls.Add(this.create_new_dir);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.dirView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(749, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "模板";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // create_new_file
            // 
            this.create_new_file.BackColor = System.Drawing.Color.White;
            this.create_new_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_new_file.FlatAppearance.BorderSize = 0;
            this.create_new_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_new_file.ImageIndex = 3;
            this.create_new_file.ImageList = this.treeViewIcon;
            this.create_new_file.Location = new System.Drawing.Point(0, 38);
            this.create_new_file.Name = "create_new_file";
            this.create_new_file.Size = new System.Drawing.Size(36, 36);
            this.create_new_file.TabIndex = 4;
            this.create_new_file.UseVisualStyleBackColor = true;
            this.create_new_file.Click += new System.EventHandler(this.create_new_file_Click);
            // 
            // treeViewIcon
            // 
            this.treeViewIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeViewIcon.ImageStream")));
            this.treeViewIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.treeViewIcon.Images.SetKeyName(0, "dir.png");
            this.treeViewIcon.Images.SetKeyName(1, "file.png");
            this.treeViewIcon.Images.SetKeyName(2, "new_dir.png");
            this.treeViewIcon.Images.SetKeyName(3, "new_file.png");
            // 
            // create_new_dir
            // 
            this.create_new_dir.BackColor = System.Drawing.Color.White;
            this.create_new_dir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_new_dir.FlatAppearance.BorderSize = 0;
            this.create_new_dir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_new_dir.ImageIndex = 2;
            this.create_new_dir.ImageList = this.treeViewIcon;
            this.create_new_dir.Location = new System.Drawing.Point(0, 0);
            this.create_new_dir.Name = "create_new_dir";
            this.create_new_dir.Size = new System.Drawing.Size(36, 36);
            this.create_new_dir.TabIndex = 3;
            this.create_new_dir.UseVisualStyleBackColor = true;
            this.create_new_dir.Click += new System.EventHandler(this.create_new_dir_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.savePlaceholderBtn);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.editTemplateButton);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.fileExtBox);
            this.tabPage2.Controls.Add(this.placeGroupName);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(743, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "占位符";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // savePlaceholderBtn
            // 
            this.savePlaceholderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePlaceholderBtn.Location = new System.Drawing.Point(212, 6);
            this.savePlaceholderBtn.Name = "savePlaceholderBtn";
            this.savePlaceholderBtn.Size = new System.Drawing.Size(75, 28);
            this.savePlaceholderBtn.TabIndex = 10;
            this.savePlaceholderBtn.Text = "保存";
            this.savePlaceholderBtn.UseVisualStyleBackColor = true;
            this.savePlaceholderBtn.Click += new System.EventHandler(this.savePlaceholderBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placeholder,
            this.content});
            this.dataGridView1.Location = new System.Drawing.Point(0, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(740, 325);
            this.dataGridView1.TabIndex = 8;
            // 
            // placeholder
            // 
            this.placeholder.HeaderText = "占位符";
            this.placeholder.Name = "placeholder";
            // 
            // content
            // 
            this.content.HeaderText = "内容";
            this.content.Name = "content";
            // 
            // editTemplateButton
            // 
            this.editTemplateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTemplateButton.Location = new System.Drawing.Point(380, 6);
            this.editTemplateButton.Name = "editTemplateButton";
            this.editTemplateButton.Size = new System.Drawing.Size(75, 28);
            this.editTemplateButton.TabIndex = 7;
            this.editTemplateButton.Text = "编辑模板";
            this.editTemplateButton.UseVisualStyleBackColor = true;
            this.editTemplateButton.Click += new System.EventHandler(this.editTemplateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "默认扩展名：";
            // 
            // fileExtBox
            // 
            this.fileExtBox.Location = new System.Drawing.Point(640, 31);
            this.fileExtBox.Name = "fileExtBox";
            this.fileExtBox.Size = new System.Drawing.Size(100, 21);
            this.fileExtBox.TabIndex = 5;
            this.fileExtBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // placeGroupName
            // 
            this.placeGroupName.AutoSize = true;
            this.placeGroupName.Location = new System.Drawing.Point(15, 36);
            this.placeGroupName.Name = "placeGroupName";
            this.placeGroupName.Size = new System.Drawing.Size(41, 12);
            this.placeGroupName.TabIndex = 4;
            this.placeGroupName.Text = "什么鬼";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(299, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "新建模板";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "模板：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 441);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView dirView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem beginToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem createDirsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveJsonResultToolStripMenuItem;
        private System.Windows.Forms.ImageList treeViewIcon;
        private System.Windows.Forms.Button create_new_dir;
        private System.Windows.Forms.Button create_new_file;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label placeGroupName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileExtBox;
        private System.Windows.Forms.ToolStripMenuItem createNodesByDirSysToolStripMenuItem;
        private System.Windows.Forms.Button editTemplateButton;
        private MyDataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeholder;
        private System.Windows.Forms.DataGridViewTextBoxColumn content;
        private System.Windows.Forms.Button savePlaceholderBtn;
    }
}

