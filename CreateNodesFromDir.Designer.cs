namespace Template
{
    partial class CreateNodesFromDir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.path = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.fileExtBox = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.openDir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Location = new System.Drawing.Point(45, 27);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(41, 12);
            this.path.TabIndex = 0;
            this.path.Text = "路径：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "扩展名：";
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(92, 24);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(244, 21);
            this.pathBox.TabIndex = 2;
            // 
            // fileExtBox
            // 
            this.fileExtBox.Location = new System.Drawing.Point(92, 66);
            this.fileExtBox.Name = "fileExtBox";
            this.fileExtBox.Size = new System.Drawing.Size(244, 21);
            this.fileExtBox.TabIndex = 3;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(179, 125);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(261, 125);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 5;
            this.ok.Text = "确定";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // openDir
            // 
            this.openDir.Location = new System.Drawing.Point(342, 24);
            this.openDir.Name = "openDir";
            this.openDir.Size = new System.Drawing.Size(29, 21);
            this.openDir.TabIndex = 6;
            this.openDir.Text = "…";
            this.openDir.UseVisualStyleBackColor = true;
            this.openDir.Click += new System.EventHandler(this.openDir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "多个扩展名用英文逗号分开";
            // 
            // CreateNodesFromDir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 172);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openDir);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.fileExtBox);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.path);
            this.Name = "CreateNodesFromDir";
            this.Text = "CreateNodesFromDir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.TextBox fileExtBox;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button openDir;
        private System.Windows.Forms.Label label1;
    }
}