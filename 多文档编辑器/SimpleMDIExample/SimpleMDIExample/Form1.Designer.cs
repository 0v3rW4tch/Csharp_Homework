namespace SimpleMDIExample
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.页面设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口层叠ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水平平铺ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.垂直平铺ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.恢复ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.全选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查找和替换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.时间日期ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自动换行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隐藏菜单栏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.新建NToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.打开OToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.保存SToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.撤销toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.恢复toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.剪切UToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.复制CToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.粘贴PToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tSCbBoxFontName = new System.Windows.Forms.ToolStripComboBox();
            this.tSCbBoxFontSizeName = new System.Windows.Forms.ToolStripComboBox();
            this.粗体toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.斜体toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.下划线toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.左对齐toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.居中toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.右对齐toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.窗口ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.文本ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建NToolStripMenuItem,
            this.打开OToolStripMenuItem,
            this.关闭CToolStripMenuItem,
            this.toolStripSeparator3,
            this.保存SToolStripMenuItem,
            this.另存为AToolStripMenuItem,
            this.toolStripMenuItem1,
            this.退出EToolStripMenuItem,
            this.打印ToolStripMenuItem,
            this.页面设置ToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文件FToolStripMenuItem.Text = "文件";
            // 
            // 新建NToolStripMenuItem
            // 
            this.新建NToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("新建NToolStripMenuItem.Image")));
            this.新建NToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新建NToolStripMenuItem.Name = "新建NToolStripMenuItem";
            this.新建NToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新建NToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.新建NToolStripMenuItem.Text = "新建(&N)";
            // 
            // 打开OToolStripMenuItem
            // 
            this.打开OToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("打开OToolStripMenuItem.Image")));
            this.打开OToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem";
            this.打开OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.打开OToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.打开OToolStripMenuItem.Text = "打开(&O)";
            this.打开OToolStripMenuItem.Click += new System.EventHandler(this.打开OToolStripMenuItem_Click);
            // 
            // 关闭CToolStripMenuItem
            // 
            this.关闭CToolStripMenuItem.Name = "关闭CToolStripMenuItem";
            this.关闭CToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.关闭CToolStripMenuItem.Text = "关闭";
            this.关闭CToolStripMenuItem.Click += new System.EventHandler(this.关闭CToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(191, 6);
            // 
            // 保存SToolStripMenuItem
            // 
            this.保存SToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("保存SToolStripMenuItem.Image")));
            this.保存SToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem";
            this.保存SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存SToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.保存SToolStripMenuItem.Text = "保存(&S)";
            this.保存SToolStripMenuItem.Click += new System.EventHandler(this.保存SToolStripMenuItem_Click);
            // 
            // 另存为AToolStripMenuItem
            // 
            this.另存为AToolStripMenuItem.Name = "另存为AToolStripMenuItem";
            this.另存为AToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.另存为AToolStripMenuItem.Text = "另存为(&A)";
            this.另存为AToolStripMenuItem.Click += new System.EventHandler(this.另存为AToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(191, 6);
            // 
            // 退出EToolStripMenuItem
            // 
            this.退出EToolStripMenuItem.Name = "退出EToolStripMenuItem";
            this.退出EToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.退出EToolStripMenuItem.Text = "退出(&X)";
            this.退出EToolStripMenuItem.Click += new System.EventHandler(this.退出EToolStripMenuItem_Click);
            // 
            // 打印ToolStripMenuItem
            // 
            this.打印ToolStripMenuItem.Name = "打印ToolStripMenuItem";
            this.打印ToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.打印ToolStripMenuItem.Text = "打印";
            this.打印ToolStripMenuItem.Click += new System.EventHandler(this.打印ToolStripMenuItem_Click);
            // 
            // 页面设置ToolStripMenuItem
            // 
            this.页面设置ToolStripMenuItem.Name = "页面设置ToolStripMenuItem";
            this.页面设置ToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.页面设置ToolStripMenuItem.Text = "页面设置";
            this.页面设置ToolStripMenuItem.Click += new System.EventHandler(this.页面设置ToolStripMenuItem_Click);
            // 
            // 窗口ToolStripMenuItem
            // 
            this.窗口ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.窗口层叠ToolStripMenuItem,
            this.水平平铺ToolStripMenuItem,
            this.垂直平铺ToolStripMenuItem});
            this.窗口ToolStripMenuItem.Name = "窗口ToolStripMenuItem";
            this.窗口ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.窗口ToolStripMenuItem.Text = "窗口";
            // 
            // 窗口层叠ToolStripMenuItem
            // 
            this.窗口层叠ToolStripMenuItem.Name = "窗口层叠ToolStripMenuItem";
            this.窗口层叠ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.窗口层叠ToolStripMenuItem.Text = "窗口层叠";
            this.窗口层叠ToolStripMenuItem.Click += new System.EventHandler(this.窗口层叠ToolStripMenuItem_Click);
            // 
            // 水平平铺ToolStripMenuItem
            // 
            this.水平平铺ToolStripMenuItem.Name = "水平平铺ToolStripMenuItem";
            this.水平平铺ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.水平平铺ToolStripMenuItem.Text = "水平平铺";
            this.水平平铺ToolStripMenuItem.Click += new System.EventHandler(this.水平平铺ToolStripMenuItem_Click);
            // 
            // 垂直平铺ToolStripMenuItem
            // 
            this.垂直平铺ToolStripMenuItem.Name = "垂直平铺ToolStripMenuItem";
            this.垂直平铺ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.垂直平铺ToolStripMenuItem.Text = "垂直平铺";
            this.垂直平铺ToolStripMenuItem.Click += new System.EventHandler(this.垂直平铺ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.撤销ToolStripMenuItem,
            this.恢复ToolStripMenuItem,
            this.toolStripSeparator5,
            this.剪切ToolStripMenuItem,
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.toolStripSeparator6,
            this.全选ToolStripMenuItem,
            this.查找和替换ToolStripMenuItem,
            this.时间日期ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 撤销ToolStripMenuItem
            // 
            this.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem";
            this.撤销ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.撤销ToolStripMenuItem.Text = "撤销";
            this.撤销ToolStripMenuItem.Click += new System.EventHandler(this.撤销ToolStripMenuItem_Click);
            // 
            // 恢复ToolStripMenuItem
            // 
            this.恢复ToolStripMenuItem.Name = "恢复ToolStripMenuItem";
            this.恢复ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.恢复ToolStripMenuItem.Text = "恢复";
            this.恢复ToolStripMenuItem.Click += new System.EventHandler(this.恢复ToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(156, 6);
            // 
            // 剪切ToolStripMenuItem
            // 
            this.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
            this.剪切ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.剪切ToolStripMenuItem.Text = "剪切";
            this.剪切ToolStripMenuItem.Click += new System.EventHandler(this.剪切ToolStripMenuItem_Click);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            this.粘贴ToolStripMenuItem.Click += new System.EventHandler(this.粘贴ToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(156, 6);
            // 
            // 全选ToolStripMenuItem
            // 
            this.全选ToolStripMenuItem.Name = "全选ToolStripMenuItem";
            this.全选ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.全选ToolStripMenuItem.Text = "全选";
            this.全选ToolStripMenuItem.Click += new System.EventHandler(this.全选ToolStripMenuItem_Click);
            // 
            // 查找和替换ToolStripMenuItem
            // 
            this.查找和替换ToolStripMenuItem.Name = "查找和替换ToolStripMenuItem";
            this.查找和替换ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.查找和替换ToolStripMenuItem.Text = "查找和替换";
            this.查找和替换ToolStripMenuItem.Click += new System.EventHandler(this.查找ToolStripMenuItem_Click);
            // 
            // 时间日期ToolStripMenuItem
            // 
            this.时间日期ToolStripMenuItem.Name = "时间日期ToolStripMenuItem";
            this.时间日期ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.时间日期ToolStripMenuItem.Text = "时间/日期";
            this.时间日期ToolStripMenuItem.Click += new System.EventHandler(this.时间日期ToolStripMenuItem_Click);
            // 
            // 文本ToolStripMenuItem
            // 
            this.文本ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.字体ToolStripMenuItem,
            this.颜色ToolStripMenuItem,
            this.自动换行ToolStripMenuItem});
            this.文本ToolStripMenuItem.Name = "文本ToolStripMenuItem";
            this.文本ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文本ToolStripMenuItem.Text = "文本";
            // 
            // 字体ToolStripMenuItem
            // 
            this.字体ToolStripMenuItem.Name = "字体ToolStripMenuItem";
            this.字体ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.字体ToolStripMenuItem.Text = "字体";
            this.字体ToolStripMenuItem.Click += new System.EventHandler(this.字体ToolStripMenuItem_Click);
            // 
            // 颜色ToolStripMenuItem
            // 
            this.颜色ToolStripMenuItem.Name = "颜色ToolStripMenuItem";
            this.颜色ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.颜色ToolStripMenuItem.Text = "颜色";
            this.颜色ToolStripMenuItem.Click += new System.EventHandler(this.颜色ToolStripMenuItem_Click);
            // 
            // 自动换行ToolStripMenuItem
            // 
            this.自动换行ToolStripMenuItem.Checked = true;
            this.自动换行ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.自动换行ToolStripMenuItem.Name = "自动换行ToolStripMenuItem";
            this.自动换行ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.自动换行ToolStripMenuItem.Text = "自动换行";
            this.自动换行ToolStripMenuItem.Click += new System.EventHandler(this.自动换行ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem,
            this.隐藏菜单栏ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.关于ToolStripMenuItem.Text = "关于记事本";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 隐藏菜单栏ToolStripMenuItem
            // 
            this.隐藏菜单栏ToolStripMenuItem.Name = "隐藏菜单栏ToolStripMenuItem";
            this.隐藏菜单栏ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.隐藏菜单栏ToolStripMenuItem.Text = "隐藏菜单栏";
            this.隐藏菜单栏ToolStripMenuItem.Click += new System.EventHandler(this.隐藏菜单栏ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建NToolStripButton,
            this.打开OToolStripButton,
            this.保存SToolStripButton,
            this.toolStripSeparator1,
            this.撤销toolStripButton,
            this.恢复toolStripButton,
            this.剪切UToolStripButton,
            this.复制CToolStripButton,
            this.粘贴PToolStripButton,
            this.toolStripSeparator2,
            this.tSCbBoxFontName,
            this.tSCbBoxFontSizeName,
            this.粗体toolStripButton,
            this.斜体toolStripButton,
            this.下划线toolStripButton,
            this.toolStripSeparator4,
            this.左对齐toolStripButton1,
            this.居中toolStripButton1,
            this.右对齐toolStripButton1,
            this.toolStripSeparator7,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(782, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // 新建NToolStripButton
            // 
            this.新建NToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.新建NToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("新建NToolStripButton.Image")));
            this.新建NToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新建NToolStripButton.Name = "新建NToolStripButton";
            this.新建NToolStripButton.Size = new System.Drawing.Size(24, 25);
            this.新建NToolStripButton.Text = "新建(&N)";
            this.新建NToolStripButton.Click += new System.EventHandler(this.新建NToolStripButton_Click);
            // 
            // 打开OToolStripButton
            // 
            this.打开OToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.打开OToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("打开OToolStripButton.Image")));
            this.打开OToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打开OToolStripButton.Name = "打开OToolStripButton";
            this.打开OToolStripButton.Size = new System.Drawing.Size(24, 25);
            this.打开OToolStripButton.Text = "打开(&O)";
            this.打开OToolStripButton.Click += new System.EventHandler(this.打开OToolStripButton_Click);
            // 
            // 保存SToolStripButton
            // 
            this.保存SToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.保存SToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("保存SToolStripButton.Image")));
            this.保存SToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.保存SToolStripButton.Name = "保存SToolStripButton";
            this.保存SToolStripButton.Size = new System.Drawing.Size(24, 25);
            this.保存SToolStripButton.Text = "保存(&S)";
            this.保存SToolStripButton.Click += new System.EventHandler(this.保存SToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // 撤销toolStripButton
            // 
            this.撤销toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.撤销toolStripButton.Image = global::SimpleMDIExample.Properties.Resources.Undo;
            this.撤销toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.撤销toolStripButton.Name = "撤销toolStripButton";
            this.撤销toolStripButton.Size = new System.Drawing.Size(24, 25);
            this.撤销toolStripButton.Text = "toolStripButton1";
            this.撤销toolStripButton.Click += new System.EventHandler(this.撤销toolStripButton_Click);
            // 
            // 恢复toolStripButton
            // 
            this.恢复toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.恢复toolStripButton.Image = global::SimpleMDIExample.Properties.Resources.Redo;
            this.恢复toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.恢复toolStripButton.Name = "恢复toolStripButton";
            this.恢复toolStripButton.Size = new System.Drawing.Size(24, 25);
            this.恢复toolStripButton.Text = "toolStripButton2";
            this.恢复toolStripButton.Click += new System.EventHandler(this.恢复toolStripButton_Click);
            // 
            // 剪切UToolStripButton
            // 
            this.剪切UToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.剪切UToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("剪切UToolStripButton.Image")));
            this.剪切UToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.剪切UToolStripButton.Name = "剪切UToolStripButton";
            this.剪切UToolStripButton.Size = new System.Drawing.Size(24, 25);
            this.剪切UToolStripButton.Text = "剪切(&U)";
            this.剪切UToolStripButton.Click += new System.EventHandler(this.剪切UToolStripButton_Click);
            // 
            // 复制CToolStripButton
            // 
            this.复制CToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.复制CToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("复制CToolStripButton.Image")));
            this.复制CToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.复制CToolStripButton.Name = "复制CToolStripButton";
            this.复制CToolStripButton.Size = new System.Drawing.Size(24, 25);
            this.复制CToolStripButton.Text = "复制(&C)";
            this.复制CToolStripButton.Click += new System.EventHandler(this.复制CToolStripButton_Click);
            // 
            // 粘贴PToolStripButton
            // 
            this.粘贴PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.粘贴PToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("粘贴PToolStripButton.Image")));
            this.粘贴PToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.粘贴PToolStripButton.Name = "粘贴PToolStripButton";
            this.粘贴PToolStripButton.Size = new System.Drawing.Size(24, 25);
            this.粘贴PToolStripButton.Text = "粘贴(&P)";
            this.粘贴PToolStripButton.Click += new System.EventHandler(this.粘贴PToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // tSCbBoxFontName
            // 
            this.tSCbBoxFontName.Name = "tSCbBoxFontName";
            this.tSCbBoxFontName.Size = new System.Drawing.Size(120, 28);
            this.tSCbBoxFontName.Click += new System.EventHandler(this.tSCbBoxFontName_Click);
            this.tSCbBoxFontName.TextChanged += new System.EventHandler(this.tSCbBoxFontName_TextChanged);
            // 
            // tSCbBoxFontSizeName
            // 
            this.tSCbBoxFontSizeName.AutoSize = false;
            this.tSCbBoxFontSizeName.Name = "tSCbBoxFontSizeName";
            this.tSCbBoxFontSizeName.Size = new System.Drawing.Size(60, 28);
            this.tSCbBoxFontSizeName.SelectedIndexChanged += new System.EventHandler(this.tSCbBoxFontSizeName_SelectedIndexChanged);
            this.tSCbBoxFontSizeName.Click += new System.EventHandler(this.tSCbBoxFontSizeName_Click);
            this.tSCbBoxFontSizeName.TextChanged += new System.EventHandler(this.tSCbBoxFontSizeName_TextChanged);
            // 
            // 粗体toolStripButton
            // 
            this.粗体toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.粗体toolStripButton.Image = global::SimpleMDIExample.Properties.Resources.Bold;
            this.粗体toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.粗体toolStripButton.Name = "粗体toolStripButton";
            this.粗体toolStripButton.Size = new System.Drawing.Size(24, 25);
            this.粗体toolStripButton.Text = "toolStripButton1";
            this.粗体toolStripButton.Click += new System.EventHandler(this.粗体toolStripButton_Click);
            // 
            // 斜体toolStripButton
            // 
            this.斜体toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.斜体toolStripButton.Image = global::SimpleMDIExample.Properties.Resources.Italic;
            this.斜体toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.斜体toolStripButton.Name = "斜体toolStripButton";
            this.斜体toolStripButton.Size = new System.Drawing.Size(24, 25);
            this.斜体toolStripButton.Text = "toolStripButton2";
            this.斜体toolStripButton.Click += new System.EventHandler(this.斜体toolStripButton_Click);
            // 
            // 下划线toolStripButton
            // 
            this.下划线toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.下划线toolStripButton.Image = global::SimpleMDIExample.Properties.Resources.Underline;
            this.下划线toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.下划线toolStripButton.Name = "下划线toolStripButton";
            this.下划线toolStripButton.Size = new System.Drawing.Size(24, 25);
            this.下划线toolStripButton.Text = "toolStripButton3";
            this.下划线toolStripButton.Click += new System.EventHandler(this.下划线toolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // 左对齐toolStripButton1
            // 
            this.左对齐toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.左对齐toolStripButton1.Image = global::SimpleMDIExample.Properties.Resources.AlignLeft;
            this.左对齐toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.左对齐toolStripButton1.Name = "左对齐toolStripButton1";
            this.左对齐toolStripButton1.Size = new System.Drawing.Size(24, 25);
            this.左对齐toolStripButton1.Text = "toolStripButton1";
            this.左对齐toolStripButton1.Click += new System.EventHandler(this.左对齐toolStripButton1_Click);
            // 
            // 居中toolStripButton1
            // 
            this.居中toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.居中toolStripButton1.Image = global::SimpleMDIExample.Properties.Resources.AlignCenter;
            this.居中toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.居中toolStripButton1.Name = "居中toolStripButton1";
            this.居中toolStripButton1.Size = new System.Drawing.Size(24, 25);
            this.居中toolStripButton1.Text = "toolStripButton1";
            this.居中toolStripButton1.Click += new System.EventHandler(this.居中toolStripButton1_Click);
            // 
            // 右对齐toolStripButton1
            // 
            this.右对齐toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.右对齐toolStripButton1.Image = global::SimpleMDIExample.Properties.Resources.AlignRight;
            this.右对齐toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.右对齐toolStripButton1.Name = "右对齐toolStripButton1";
            this.右对齐toolStripButton1.Size = new System.Drawing.Size(24, 25);
            this.右对齐toolStripButton1.Text = "toolStripButton1";
            this.右对齐toolStripButton1.Click += new System.EventHandler(this.右对齐toolStripButton1_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::SimpleMDIExample.Properties.Resources.ZoomDialog1;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 25);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 531);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(782, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timeLabel
            // 
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.timeLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "                                                                                 " +
    "                                               ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出EToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton 新建NToolStripButton;
        private System.Windows.Forms.ToolStripButton 打开OToolStripButton;
        private System.Windows.Forms.ToolStripButton 保存SToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 关闭CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口层叠ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水平平铺ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 垂直平铺ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton 粗体toolStripButton;
        private System.Windows.Forms.ToolStripButton 斜体toolStripButton;
        private System.Windows.Forms.ToolStripButton 下划线toolStripButton;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton 剪切UToolStripButton;
        private System.Windows.Forms.ToolStripButton 复制CToolStripButton;
        private System.Windows.Forms.ToolStripButton 粘贴PToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton 左对齐toolStripButton1;
        private System.Windows.Forms.ToolStripButton 居中toolStripButton1;
        private System.Windows.Forms.ToolStripButton 右对齐toolStripButton1;
        private System.Windows.Forms.ToolStripButton 撤销toolStripButton;
        private System.Windows.Forms.ToolStripButton 恢复toolStripButton;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 撤销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 恢复ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 剪切ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem 全选ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox tSCbBoxFontName;
        private System.Windows.Forms.ToolStripMenuItem 自动换行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查找和替换ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox tSCbBoxFontSizeName;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem 打印ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隐藏菜单栏ToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.ToolStripMenuItem 时间日期ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 页面设置ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel timeLabel;
        private System.Windows.Forms.Timer timer;
    }
}

