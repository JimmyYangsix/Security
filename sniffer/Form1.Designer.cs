namespace sniffer
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.筛选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repair = new System.Windows.Forms.Timer(this.components);
            this.AllPacketdata = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ahead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mhead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllPacketdata)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem,
            this.停止ToolStripMenuItem,
            this.选项ToolStripMenuItem,
            this.筛选ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1860, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.开始ToolStripMenuItem.Text = "开始";
            this.开始ToolStripMenuItem.Click += new System.EventHandler(this.开始ToolStripMenuItem_Click);
            // 
            // 停止ToolStripMenuItem
            // 
            this.停止ToolStripMenuItem.Name = "停止ToolStripMenuItem";
            this.停止ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.停止ToolStripMenuItem.Text = "停止";
            this.停止ToolStripMenuItem.Click += new System.EventHandler(this.停止ToolStripMenuItem_Click);
            // 
            // 选项ToolStripMenuItem
            // 
            this.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            this.选项ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.选项ToolStripMenuItem.Text = "选项";
            this.选项ToolStripMenuItem.Click += new System.EventHandler(this.选项ToolStripMenuItem_Click);
            // 
            // 筛选ToolStripMenuItem
            // 
            this.筛选ToolStripMenuItem.Name = "筛选ToolStripMenuItem";
            this.筛选ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.筛选ToolStripMenuItem.Text = "筛选";
            this.筛选ToolStripMenuItem.Click += new System.EventHandler(this.筛选ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // repair
            // 
            this.repair.Interval = 2000;
            this.repair.Tick += new System.EventHandler(this.repair_Tick);
            // 
            // AllPacketdata
            // 
            this.AllPacketdata.AllowUserToAddRows = false;
            this.AllPacketdata.AllowUserToDeleteRows = false;
            this.AllPacketdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllPacketdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.type,
            this.sip,
            this.sport,
            this.dip,
            this.dport,
            this.alen,
            this.slen,
            this.ahead,
            this.mhead});
            this.AllPacketdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllPacketdata.Location = new System.Drawing.Point(0, 25);
            this.AllPacketdata.Name = "AllPacketdata";
            this.AllPacketdata.ReadOnly = true;
            this.AllPacketdata.RowTemplate.Height = 23;
            this.AllPacketdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllPacketdata.Size = new System.Drawing.Size(1860, 811);
            this.AllPacketdata.TabIndex = 1;
            this.AllPacketdata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllPacketdata_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 80;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "协议类型";
            this.type.MinimumWidth = 80;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // sip
            // 
            this.sip.DataPropertyName = "sip";
            this.sip.HeaderText = "源IP地址";
            this.sip.MinimumWidth = 120;
            this.sip.Name = "sip";
            this.sip.ReadOnly = true;
            this.sip.Width = 120;
            // 
            // sport
            // 
            this.sport.DataPropertyName = "sport";
            this.sport.HeaderText = "源端口号";
            this.sport.MinimumWidth = 80;
            this.sport.Name = "sport";
            this.sport.ReadOnly = true;
            // 
            // dip
            // 
            this.dip.DataPropertyName = "dip";
            this.dip.HeaderText = "目的Ip地址";
            this.dip.MinimumWidth = 120;
            this.dip.Name = "dip";
            this.dip.ReadOnly = true;
            this.dip.Width = 120;
            // 
            // dport
            // 
            this.dport.DataPropertyName = "dport";
            this.dport.HeaderText = "目的端口号";
            this.dport.MinimumWidth = 80;
            this.dport.Name = "dport";
            this.dport.ReadOnly = true;
            // 
            // alen
            // 
            this.alen.DataPropertyName = "alen";
            this.alen.HeaderText = "消息体长度";
            this.alen.MinimumWidth = 80;
            this.alen.Name = "alen";
            this.alen.ReadOnly = true;
            // 
            // slen
            // 
            this.slen.DataPropertyName = "slen";
            this.slen.HeaderText = "消息长度";
            this.slen.MinimumWidth = 80;
            this.slen.Name = "slen";
            this.slen.ReadOnly = true;
            // 
            // ahead
            // 
            this.ahead.DataPropertyName = "ahead";
            this.ahead.HeaderText = "Ip报文头";
            this.ahead.MinimumWidth = 400;
            this.ahead.Name = "ahead";
            this.ahead.ReadOnly = true;
            this.ahead.Width = 400;
            // 
            // mhead
            // 
            this.mhead.DataPropertyName = "mhead";
            this.mhead.HeaderText = "消息头";
            this.mhead.MinimumWidth = 600;
            this.mhead.Name = "mhead";
            this.mhead.ReadOnly = true;
            this.mhead.Width = 600;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1860, 836);
            this.Controls.Add(this.AllPacketdata);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllPacketdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 筛选ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Timer repair;
        private System.Windows.Forms.DataGridView AllPacketdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn sip;
        private System.Windows.Forms.DataGridViewTextBoxColumn sport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dip;
        private System.Windows.Forms.DataGridViewTextBoxColumn dport;
        private System.Windows.Forms.DataGridViewTextBoxColumn alen;
        private System.Windows.Forms.DataGridViewTextBoxColumn slen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ahead;
        private System.Windows.Forms.DataGridViewTextBoxColumn mhead;
    }
}

