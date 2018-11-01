namespace zgcwkj
{
    partial class Proxy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proxy));
            this.txt_1 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_1
            // 
            this.txt_1.Font = new System.Drawing.Font("宋体", 13F);
            this.txt_1.Location = new System.Drawing.Point(14, 57);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(183, 23);
            this.txt_1.TabIndex = 0;
            this.txt_1.Text = "000.000.000.000:0000";
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("宋体", 14F);
            this.txt.Location = new System.Drawing.Point(12, 28);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(143, 19);
            this.txt.TabIndex = 1;
            this.txt.Text = "当前尝试的IP：";
            // 
            // Proxy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 111);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txt_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(220, 150);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(220, 150);
            this.Name = "Proxy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自动代理服务";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_1;
        private System.Windows.Forms.Label txt;
    }
}