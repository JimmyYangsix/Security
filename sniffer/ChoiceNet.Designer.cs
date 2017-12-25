namespace sniffer
{
    partial class ChoiceNet
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
            this.请选择要监听的网卡 = new System.Windows.Forms.Label();
            this.Allinfo = new System.Windows.Forms.ComboBox();
            this.OK = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 请选择要监听的网卡
            // 
            this.请选择要监听的网卡.AutoSize = true;
            this.请选择要监听的网卡.Location = new System.Drawing.Point(60, 25);
            this.请选择要监听的网卡.Name = "请选择要监听的网卡";
            this.请选择要监听的网卡.Size = new System.Drawing.Size(125, 12);
            this.请选择要监听的网卡.TabIndex = 0;
            this.请选择要监听的网卡.Text = "请选择你要监听的网卡";
            // 
            // Allinfo
            // 
            this.Allinfo.FormattingEnabled = true;
            this.Allinfo.Location = new System.Drawing.Point(62, 51);
            this.Allinfo.Name = "Allinfo";
            this.Allinfo.Size = new System.Drawing.Size(1146, 20);
            this.Allinfo.TabIndex = 1;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(156, 248);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(169, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "确定";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(730, 248);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(169, 23);
            this.exit.TabIndex = 3;
            this.exit.Text = "取消";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // ChoiceNet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 685);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Allinfo);
            this.Controls.Add(this.请选择要监听的网卡);
            this.Name = "ChoiceNet";
            this.Text = "ChoiceNet";
            this.Load += new System.EventHandler(this.ChoiceNet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 请选择要监听的网卡;
        private System.Windows.Forms.ComboBox Allinfo;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button exit;
    }
}