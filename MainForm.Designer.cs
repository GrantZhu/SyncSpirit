namespace SyncSpirit.View
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.fromPath = new System.Windows.Forms.TextBox();
            this.fromBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.from = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fmt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tmt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.toPath = new System.Windows.Forms.TextBox();
            this.toBtn = new System.Windows.Forms.Button();
            this.syncBtn = new System.Windows.Forms.Button();
            this.syncActionType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.to = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // fromPath
            // 
            this.fromPath.Location = new System.Drawing.Point(79, 34);
            this.fromPath.Name = "fromPath";
            this.fromPath.Size = new System.Drawing.Size(241, 21);
            this.fromPath.TabIndex = 1;
            // 
            // fromBtn
            // 
            this.fromBtn.Location = new System.Drawing.Point(337, 32);
            this.fromBtn.Name = "fromBtn";
            this.fromBtn.Size = new System.Drawing.Size(112, 23);
            this.fromBtn.TabIndex = 2;
            this.fromBtn.Text = "Choose Folder";
            this.fromBtn.UseVisualStyleBackColor = true;
            this.fromBtn.Click += new System.EventHandler(this.fromBtn_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.from,
            this.to,
            this.fmt,
            this.tmt,
            this.syncActionType});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 136);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(732, 207);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // from
            // 
            this.from.Text = "From";
            this.from.Width = 194;
            // 
            // fmt
            // 
            this.fmt.Text = "From Modified";
            this.fmt.Width = 105;
            // 
            // tmt
            // 
            this.tmt.Text = "To Modified";
            this.tmt.Width = 105;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(25, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "To:";
            // 
            // toPath
            // 
            this.toPath.Location = new System.Drawing.Point(79, 65);
            this.toPath.Name = "toPath";
            this.toPath.Size = new System.Drawing.Size(241, 21);
            this.toPath.TabIndex = 5;
            // 
            // toBtn
            // 
            this.toBtn.Location = new System.Drawing.Point(337, 63);
            this.toBtn.Name = "toBtn";
            this.toBtn.Size = new System.Drawing.Size(112, 23);
            this.toBtn.TabIndex = 6;
            this.toBtn.Text = "Choose Folder";
            this.toBtn.UseVisualStyleBackColor = true;
            this.toBtn.Click += new System.EventHandler(this.toBtn_Click);
            // 
            // syncBtn
            // 
            this.syncBtn.Location = new System.Drawing.Point(168, 98);
            this.syncBtn.Name = "syncBtn";
            this.syncBtn.Size = new System.Drawing.Size(129, 23);
            this.syncBtn.TabIndex = 7;
            this.syncBtn.Text = "Start Sync";
            this.syncBtn.UseVisualStyleBackColor = true;
            this.syncBtn.Click += new System.EventHandler(this.syncBtn_Click);
            // 
            // syncActionType
            // 
            this.syncActionType.Text = "Action";
            // 
            // to
            // 
            this.to.Text = "To";
            this.to.Width = 195;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(767, 365);
            this.Controls.Add(this.syncBtn);
            this.Controls.Add(this.toBtn);
            this.Controls.Add(this.toPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.fromBtn);
            this.Controls.Add(this.fromPath);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fromPath;
        private System.Windows.Forms.Button fromBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox toPath;
        private System.Windows.Forms.Button toBtn;
        private System.Windows.Forms.Button syncBtn;
        private System.Windows.Forms.ColumnHeader from;
        private System.Windows.Forms.ColumnHeader fmt;
        private System.Windows.Forms.ColumnHeader tmt;
        private System.Windows.Forms.ColumnHeader syncActionType;
        private System.Windows.Forms.ColumnHeader to;
    }
}

