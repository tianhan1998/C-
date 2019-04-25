namespace 记事本
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.页面设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤销ZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.前进ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PastePToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.使用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查找FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查找下一个ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.替换RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自动换行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.缩放ZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.放大ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.缩小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.恢复默认缩放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZTLMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.关于记事本AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.格式ToolStripMenuItem,
            this.查看VToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(0, 20);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(1008, 20);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.另存为ToolStripMenuItem,
            this.toolStripSeparator1,
            this.页面设置ToolStripMenuItem,
            this.打印ToolStripMenuItem,
            this.toolStripSeparator2,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.文件ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            this.文件ToolStripMenuItem.Click += new System.EventHandler(this.文件ToolStripMenuItem_Click);
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.新建ToolStripMenuItem.Text = "新建(&N)       ";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.保存ToolStripMenuItem.Text = "保存(&S)       ";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.打开ToolStripMenuItem.Text = "打开(&O)...       ";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.另存为ToolStripMenuItem.Text = "另存为(&A)...        ";
            this.另存为ToolStripMenuItem.Click += new System.EventHandler(this.另存为ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // 页面设置ToolStripMenuItem
            // 
            this.页面设置ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.页面设置ToolStripMenuItem.Name = "页面设置ToolStripMenuItem";
            this.页面设置ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.页面设置ToolStripMenuItem.Text = "页面设置(&U)...        ";
            this.页面设置ToolStripMenuItem.Click += new System.EventHandler(this.页面设置ToolStripMenuItem_Click);
            // 
            // 打印ToolStripMenuItem
            // 
            this.打印ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.打印ToolStripMenuItem.Name = "打印ToolStripMenuItem";
            this.打印ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.打印ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.打印ToolStripMenuItem.Text = "打印(&P)...        ";
            this.打印ToolStripMenuItem.Click += new System.EventHandler(this.打印ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(199, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.退出ToolStripMenuItem.Text = "退出(&X)        ";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.撤销ZToolStripMenuItem,
            this.前进ToolStripMenuItem,
            this.toolStripSeparator6,
            this.CutToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.PastePToolStripMenuItem,
            this.DelToolStripMenuItem,
            this.toolStripSeparator7,
            this.使用ToolStripMenuItem,
            this.查找FToolStripMenuItem,
            this.查找下一个ToolStripMenuItem,
            this.替换RToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.编辑ToolStripMenuItem.Text = "编辑(&E)";
            // 
            // 撤销ZToolStripMenuItem
            // 
            this.撤销ZToolStripMenuItem.Enabled = false;
            this.撤销ZToolStripMenuItem.Name = "撤销ZToolStripMenuItem";
            this.撤销ZToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.撤销ZToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.撤销ZToolStripMenuItem.Text = "撤消(&U)              ";
            this.撤销ZToolStripMenuItem.Click += new System.EventHandler(this.撤销ZToolStripMenuItem_Click);
            // 
            // 前进ToolStripMenuItem
            // 
            this.前进ToolStripMenuItem.Name = "前进ToolStripMenuItem";
            this.前进ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.前进ToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.前进ToolStripMenuItem.Text = "前进(&Y)";
            this.前进ToolStripMenuItem.Click += new System.EventHandler(this.前进ToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(214, 6);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Enabled = false;
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.CutToolStripMenuItem.Text = "剪切(&T)";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Enabled = false;
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.CopyToolStripMenuItem.Text = "复制(&C)";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // PastePToolStripMenuItem
            // 
            this.PastePToolStripMenuItem.Name = "PastePToolStripMenuItem";
            this.PastePToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PastePToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.PastePToolStripMenuItem.Text = "粘贴(&P)";
            this.PastePToolStripMenuItem.Click += new System.EventHandler(this.PastePToolStripMenuItem_Click);
            // 
            // DelToolStripMenuItem
            // 
            this.DelToolStripMenuItem.Enabled = false;
            this.DelToolStripMenuItem.Name = "DelToolStripMenuItem";
            this.DelToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DelToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.DelToolStripMenuItem.Text = "删除(&L)";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(214, 6);
            // 
            // 使用ToolStripMenuItem
            // 
            this.使用ToolStripMenuItem.Name = "使用ToolStripMenuItem";
            this.使用ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.使用ToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.使用ToolStripMenuItem.Text = "使用 Bing 搜索...";
            this.使用ToolStripMenuItem.Click += new System.EventHandler(this.使用ToolStripMenuItem_Click);
            // 
            // 查找FToolStripMenuItem
            // 
            this.查找FToolStripMenuItem.Name = "查找FToolStripMenuItem";
            this.查找FToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.查找FToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.查找FToolStripMenuItem.Text = "查找(&F)";
            this.查找FToolStripMenuItem.Click += new System.EventHandler(this.查找FToolStripMenuItem_Click);
            // 
            // 查找下一个ToolStripMenuItem
            // 
            this.查找下一个ToolStripMenuItem.Name = "查找下一个ToolStripMenuItem";
            this.查找下一个ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.查找下一个ToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.查找下一个ToolStripMenuItem.Text = "查找下一个(&N)";
            this.查找下一个ToolStripMenuItem.Click += new System.EventHandler(this.查找下一个ToolStripMenuItem_Click);
            // 
            // 替换RToolStripMenuItem
            // 
            this.替换RToolStripMenuItem.Name = "替换RToolStripMenuItem";
            this.替换RToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.替换RToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.替换RToolStripMenuItem.Text = "替换(&R)";
            this.替换RToolStripMenuItem.Click += new System.EventHandler(this.替换RToolStripMenuItem_Click);
            // 
            // 格式ToolStripMenuItem
            // 
            this.格式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自动换行ToolStripMenuItem,
            this.字体ToolStripMenuItem});
            this.格式ToolStripMenuItem.Name = "格式ToolStripMenuItem";
            this.格式ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.格式ToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.格式ToolStripMenuItem.Text = "格式(&O)";
            this.格式ToolStripMenuItem.Click += new System.EventHandler(this.格式ToolStripMenuItem_Click);
            // 
            // 自动换行ToolStripMenuItem
            // 
            this.自动换行ToolStripMenuItem.CheckOnClick = true;
            this.自动换行ToolStripMenuItem.Name = "自动换行ToolStripMenuItem";
            this.自动换行ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.自动换行ToolStripMenuItem.Text = "自动换行(&W)";
            this.自动换行ToolStripMenuItem.Click += new System.EventHandler(this.自动换行ToolStripMenuItem_Click);
            // 
            // 字体ToolStripMenuItem
            // 
            this.字体ToolStripMenuItem.Name = "字体ToolStripMenuItem";
            this.字体ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.字体ToolStripMenuItem.Text = "字体(&F)...";
            this.字体ToolStripMenuItem.Click += new System.EventHandler(this.字体ToolStripMenuItem_Click_1);
            // 
            // 查看VToolStripMenuItem
            // 
            this.查看VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.缩放ZToolStripMenuItem,
            this.ZTLMenu});
            this.查看VToolStripMenuItem.Name = "查看VToolStripMenuItem";
            this.查看VToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.查看VToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.查看VToolStripMenuItem.Text = "查看(&V)";
            // 
            // 缩放ZToolStripMenuItem
            // 
            this.缩放ZToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.放大ToolStripMenuItem,
            this.缩小ToolStripMenuItem,
            this.恢复默认缩放ToolStripMenuItem});
            this.缩放ZToolStripMenuItem.Name = "缩放ZToolStripMenuItem";
            this.缩放ZToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.缩放ZToolStripMenuItem.Text = "缩放(&Z)";
            // 
            // 放大ToolStripMenuItem
            // 
            this.放大ToolStripMenuItem.Name = "放大ToolStripMenuItem";
            this.放大ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.放大ToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.放大ToolStripMenuItem.Text = "放大";
            this.放大ToolStripMenuItem.Click += new System.EventHandler(this.放大ToolStripMenuItem_Click);
            // 
            // 缩小ToolStripMenuItem
            // 
            this.缩小ToolStripMenuItem.Name = "缩小ToolStripMenuItem";
            this.缩小ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.缩小ToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.缩小ToolStripMenuItem.Text = "缩小";
            this.缩小ToolStripMenuItem.Click += new System.EventHandler(this.缩小ToolStripMenuItem_Click);
            // 
            // 恢复默认缩放ToolStripMenuItem
            // 
            this.恢复默认缩放ToolStripMenuItem.Name = "恢复默认缩放ToolStripMenuItem";
            this.恢复默认缩放ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.恢复默认缩放ToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.恢复默认缩放ToolStripMenuItem.Text = "恢复默认缩放";
            this.恢复默认缩放ToolStripMenuItem.Click += new System.EventHandler(this.恢复默认缩放ToolStripMenuItem_Click);
            // 
            // ZTLMenu
            // 
            this.ZTLMenu.Checked = true;
            this.ZTLMenu.CheckOnClick = true;
            this.ZTLMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ZTLMenu.Name = "ZTLMenu";
            this.ZTLMenu.Size = new System.Drawing.Size(180, 22);
            this.ZTLMenu.Text = "状态栏(&S)";
            this.ZTLMenu.CheckedChanged += new System.EventHandler(this.ZTLMenu_CheckedChanged);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看帮助HToolStripMenuItem,
            this.toolStripSeparator8,
            this.关于记事本AToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 查看帮助HToolStripMenuItem
            // 
            this.查看帮助HToolStripMenuItem.Name = "查看帮助HToolStripMenuItem";
            this.查看帮助HToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.查看帮助HToolStripMenuItem.Text = "查看帮助(&H)";
            this.查看帮助HToolStripMenuItem.Click += new System.EventHandler(this.查看帮助HToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.Location = new System.Drawing.Point(0, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1008, 709);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.IndexChanged);
            this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.FontDialog1_Apply);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripSeparator3,
            this.toolStripStatusLabel2,
            this.toolStripSeparator4,
            this.toolStripStatusLabel3,
            this.toolStripSeparator5,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 706);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 23);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(502, 18);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Padding = new System.Windows.Forms.Padding(0, 0, 52, 0);
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(161, 18);
            this.toolStripStatusLabel2.Text = "  Windows (CRLF)";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(160, 18);
            this.toolStripStatusLabel3.Text = "  第 1 行，第 1 列";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.AutoSize = false;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(152, 18);
            this.toolStripStatusLabel4.Text = "100%                            ";
            this.toolStripStatusLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(177, 6);
            // 
            // 关于记事本AToolStripMenuItem
            // 
            this.关于记事本AToolStripMenuItem.Name = "关于记事本AToolStripMenuItem";
            this.关于记事本AToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.关于记事本AToolStripMenuItem.Text = "关于记事本(&A)";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "无标题 - 记事本";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 页面设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 打印ToolStripMenuItem;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 格式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自动换行ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripMenuItem 撤销ZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 前进ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PastePToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem 使用ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查找FToolStripMenuItem;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem 查找下一个ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 替换RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZTLMenu;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 缩放ZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 放大ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 缩小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 恢复默认缩放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem 关于记事本AToolStripMenuItem;
    }
}

