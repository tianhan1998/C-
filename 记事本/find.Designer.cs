namespace 记事本
{
    partial class FindForm
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
            this.tip = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.startfind = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tip
            // 
            this.tip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tip.AutoSize = true;
            this.tip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tip.Location = new System.Drawing.Point(3, 17);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(77, 17);
            this.tip.TabIndex = 0;
            this.tip.Text = "查找内容(&N):";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(86, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // startfind
            // 
            this.startfind.Enabled = false;
            this.startfind.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startfind.Location = new System.Drawing.Point(326, 12);
            this.startfind.Name = "startfind";
            this.startfind.Size = new System.Drawing.Size(91, 27);
            this.startfind.TabIndex = 2;
            this.startfind.Text = "查找下一个(&F)";
            this.startfind.UseVisualStyleBackColor = true;
            this.startfind.Click += new System.EventHandler(this.Startfind_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancel.Location = new System.Drawing.Point(326, 45);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(91, 27);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // FindForm
            // 
            this.AcceptButton = this.startfind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 160);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.startfind);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tip);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "查找";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FindForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button startfind;
        private System.Windows.Forms.Button Cancel;
    }
}