namespace Contact
{
    partial class Form_Main
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("计算机科学与技术");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("信息安全");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("电子信息科学与技术");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("专业", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("男");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("女");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("性别", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("全部", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7});
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip_add = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_Edit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_search = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_backup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_recovery = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_add,
            this.toolStripSeparator1,
            this.toolStrip_Edit,
            this.toolStripSeparator2,
            this.toolStrip_delete,
            this.toolStripSeparator3,
            this.toolStrip_search,
            this.toolStripSeparator4,
            this.toolStrip_backup,
            this.toolStripSeparator5,
            this.toolStrip_recovery});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(863, 90);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStrip_add
            // 
            this.toolStrip_add.AutoSize = false;
            this.toolStrip_add.Image = global::Contact.Properties.Resources._1082298;
            this.toolStrip_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_add.Name = "toolStrip_add";
            this.toolStrip_add.Size = new System.Drawing.Size(80, 80);
            this.toolStrip_add.Text = "添加";
            this.toolStrip_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrip_add.Click += new System.EventHandler(this.toolStrip_add_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 90);
            // 
            // toolStrip_Edit
            // 
            this.toolStrip_Edit.AutoSize = false;
            this.toolStrip_Edit.Image = global::Contact.Properties.Resources._1082309;
            this.toolStrip_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Edit.Name = "toolStrip_Edit";
            this.toolStrip_Edit.Size = new System.Drawing.Size(80, 80);
            this.toolStrip_Edit.Text = "编辑 ";
            this.toolStrip_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrip_Edit.Click += new System.EventHandler(this.toolStrip_Edit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 90);
            // 
            // toolStrip_delete
            // 
            this.toolStrip_delete.AutoSize = false;
            this.toolStrip_delete.Image = global::Contact.Properties.Resources._1082308;
            this.toolStrip_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_delete.Name = "toolStrip_delete";
            this.toolStrip_delete.Size = new System.Drawing.Size(80, 80);
            this.toolStrip_delete.Text = "删除";
            this.toolStrip_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrip_delete.Click += new System.EventHandler(this.toolStrip_delete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 90);
            // 
            // toolStrip_search
            // 
            this.toolStrip_search.AutoSize = false;
            this.toolStrip_search.Image = global::Contact.Properties.Resources._1082303;
            this.toolStrip_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_search.Name = "toolStrip_search";
            this.toolStrip_search.Size = new System.Drawing.Size(80, 80);
            this.toolStrip_search.Text = "查找";
            this.toolStrip_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrip_search.Click += new System.EventHandler(this.toolStrip_search_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 90);
            // 
            // toolStrip_backup
            // 
            this.toolStrip_backup.AutoSize = false;
            this.toolStrip_backup.Image = global::Contact.Properties.Resources._1082300;
            this.toolStrip_backup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_backup.Name = "toolStrip_backup";
            this.toolStrip_backup.Size = new System.Drawing.Size(80, 80);
            this.toolStrip_backup.Text = "备份";
            this.toolStrip_backup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrip_backup.Click += new System.EventHandler(this.toolStrip_backup_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 90);
            // 
            // toolStrip_recovery
            // 
            this.toolStrip_recovery.AutoSize = false;
            this.toolStrip_recovery.Image = global::Contact.Properties.Resources._1082307;
            this.toolStrip_recovery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_recovery.Name = "toolStrip_recovery";
            this.toolStrip_recovery.Size = new System.Drawing.Size(80, 80);
            this.toolStrip_recovery.Text = "恢复";
            this.toolStrip_recovery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrip_recovery.Click += new System.EventHandler(this.toolStrip_recovery_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 90);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(863, 384);
            this.splitContainer1.SplitterDistance = 287;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点3";
            treeNode1.Text = "计算机科学与技术";
            treeNode2.Name = "节点5";
            treeNode2.Text = "信息安全";
            treeNode3.Name = "节点6";
            treeNode3.Text = "电子信息科学与技术";
            treeNode4.Name = "Profession";
            treeNode4.Text = "专业";
            treeNode5.Name = "节点8";
            treeNode5.Text = "男";
            treeNode6.Name = "节点9";
            treeNode6.Text = "女";
            treeNode7.Name = "节点7";
            treeNode7.Text = "性别";
            treeNode8.Name = "节点1";
            treeNode8.Text = "全部";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(287, 384);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect_1);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(572, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(863, 474);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myContracts";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStrip_add;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStrip_Edit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStrip_delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStrip_search;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton toolStrip_backup;
        private System.Windows.Forms.ToolStripButton toolStrip_recovery;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.TreeView treeView1;
    }
}

