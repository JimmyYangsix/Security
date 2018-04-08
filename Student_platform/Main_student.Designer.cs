namespace Student_platform
{
    partial class Main_student
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.所在寝室ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.业务办理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Notice = new System.Windows.Forms.ToolStripMenuItem();
            this.MessageTo = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.所在寝室ToolStripMenuItem,
            this.业务办理ToolStripMenuItem1,
            this.Notice,
            this.MessageTo,
            this.Exit,
            this.退出ToolStripMenuItem,
            this.退出ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 所在寝室ToolStripMenuItem
            // 
            this.所在寝室ToolStripMenuItem.Name = "所在寝室ToolStripMenuItem";
            this.所在寝室ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.所在寝室ToolStripMenuItem.Text = "图片隐写";
            this.所在寝室ToolStripMenuItem.Click += new System.EventHandler(this.Slove1_Click);
            // 
            // 业务办理ToolStripMenuItem1
            // 
            this.业务办理ToolStripMenuItem1.Name = "业务办理ToolStripMenuItem1";
            this.业务办理ToolStripMenuItem1.Size = new System.Drawing.Size(56, 21);
            this.业务办理ToolStripMenuItem1.Text = "解隐写";
            this.业务办理ToolStripMenuItem1.Click += new System.EventHandler(this.Slove2_Click);
            // 
            // Notice
            // 
            this.Notice.Name = "Notice";
            this.Notice.Size = new System.Drawing.Size(68, 21);
            this.Notice.Text = "信息隐写";
            this.Notice.Click += new System.EventHandler(this.Slove3_Click);
            // 
            // MessageTo
            // 
            this.MessageTo.Name = "MessageTo";
            this.MessageTo.Size = new System.Drawing.Size(68, 21);
            this.MessageTo.Text = "信息验证";
            this.MessageTo.Click += new System.EventHandler(this.Slove4_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(68, 21);
            this.Exit.Text = "图片生成";
            this.Exit.Click += new System.EventHandler(this.Slove5_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.退出ToolStripMenuItem.Text = "软件授权";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.Slove6_Click);
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem1.Text = "退出";
            this.退出ToolStripMenuItem1.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Main_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 598);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_student";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_student_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 所在寝室ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 业务办理ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Notice;
        private System.Windows.Forms.ToolStripMenuItem MessageTo;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
    }
}