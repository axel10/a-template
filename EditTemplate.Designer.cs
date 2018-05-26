namespace Template
{
    partial class EditTemplate
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
            this.delete = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.renameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.Window;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Location = new System.Drawing.Point(12, 12);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 28);
            this.delete.TabIndex = 11;
            this.delete.Text = "删除";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(104, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(183, 256);
            this.listBox1.TabIndex = 12;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.SystemColors.Window;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.Location = new System.Drawing.Point(212, 274);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 28);
            this.okBtn.TabIndex = 13;
            this.okBtn.Text = "确定";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // renameBtn
            // 
            this.renameBtn.BackColor = System.Drawing.SystemColors.Window;
            this.renameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.renameBtn.Location = new System.Drawing.Point(12, 46);
            this.renameBtn.Name = "renameBtn";
            this.renameBtn.Size = new System.Drawing.Size(75, 28);
            this.renameBtn.TabIndex = 14;
            this.renameBtn.Text = "重命名";
            this.renameBtn.UseVisualStyleBackColor = false;
            this.renameBtn.Click += new System.EventHandler(this.renameBtn_Click);
            // 
            // EditTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 323);
            this.Controls.Add(this.renameBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.delete);
            this.Name = "EditTemplate";
            this.Text = "EditTemplate";
            this.Load += new System.EventHandler(this.EditTemplate_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button renameBtn;
    }
}