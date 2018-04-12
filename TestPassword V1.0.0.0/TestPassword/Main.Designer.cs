namespace zgcwkj
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn = new System.Windows.Forms.Button();
            this.txt_url = new System.Windows.Forms.Label();
            this.text_url = new System.Windows.Forms.TextBox();
            this.gb_1 = new System.Windows.Forms.GroupBox();
            this.text_zxsd = new System.Windows.Forms.TextBox();
            this.text_xczs = new System.Windows.Forms.TextBox();
            this.txt_zxsd = new System.Windows.Forms.Label();
            this.txt_xczs = new System.Windows.Forms.Label();
            this.text_jsd = new System.Windows.Forms.TextBox();
            this.text_ksd = new System.Windows.Forms.TextBox();
            this.txt_jsd = new System.Windows.Forms.Label();
            this.txt_ksd = new System.Windows.Forms.Label();
            this.txt_ts = new System.Windows.Forms.Label();
            this.gb_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn.ForeColor = System.Drawing.Color.Red;
            this.btn.Location = new System.Drawing.Point(333, 48);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(139, 153);
            this.btn.TabIndex = 3;
            this.btn.Text = "进行搜查";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txt_url
            // 
            this.txt_url.AutoSize = true;
            this.txt_url.Location = new System.Drawing.Point(12, 17);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(65, 12);
            this.txt_url.TabIndex = 0;
            this.txt_url.Text = "目标地址：";
            // 
            // text_url
            // 
            this.text_url.Location = new System.Drawing.Point(83, 13);
            this.text_url.Name = "text_url";
            this.text_url.Size = new System.Drawing.Size(389, 21);
            this.text_url.TabIndex = 1;
            // 
            // gb_1
            // 
            this.gb_1.Controls.Add(this.text_zxsd);
            this.gb_1.Controls.Add(this.text_xczs);
            this.gb_1.Controls.Add(this.txt_zxsd);
            this.gb_1.Controls.Add(this.txt_xczs);
            this.gb_1.Controls.Add(this.text_jsd);
            this.gb_1.Controls.Add(this.text_ksd);
            this.gb_1.Controls.Add(this.txt_jsd);
            this.gb_1.Controls.Add(this.txt_ksd);
            this.gb_1.Location = new System.Drawing.Point(12, 40);
            this.gb_1.Name = "gb_1";
            this.gb_1.Size = new System.Drawing.Size(315, 161);
            this.gb_1.TabIndex = 2;
            this.gb_1.TabStop = false;
            this.gb_1.Text = "相关配置";
            // 
            // text_zxsd
            // 
            this.text_zxsd.Location = new System.Drawing.Point(110, 55);
            this.text_zxsd.MaxLength = 4;
            this.text_zxsd.Name = "text_zxsd";
            this.text_zxsd.Size = new System.Drawing.Size(186, 21);
            this.text_zxsd.TabIndex = 5;
            this.text_zxsd.Text = "200";
            this.text_zxsd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._KeyPress);
            // 
            // text_xczs
            // 
            this.text_xczs.Location = new System.Drawing.Point(110, 20);
            this.text_xczs.MaxLength = 3;
            this.text_xczs.Name = "text_xczs";
            this.text_xczs.Size = new System.Drawing.Size(186, 21);
            this.text_xczs.TabIndex = 4;
            this.text_xczs.Text = "100";
            this.text_xczs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._KeyPress);
            // 
            // txt_zxsd
            // 
            this.txt_zxsd.AutoSize = true;
            this.txt_zxsd.Location = new System.Drawing.Point(15, 58);
            this.txt_zxsd.Name = "txt_zxsd";
            this.txt_zxsd.Size = new System.Drawing.Size(89, 12);
            this.txt_zxsd.TabIndex = 1;
            this.txt_zxsd.Text = "线程执行速度：";
            // 
            // txt_xczs
            // 
            this.txt_xczs.AutoSize = true;
            this.txt_xczs.Location = new System.Drawing.Point(15, 23);
            this.txt_xczs.Name = "txt_xczs";
            this.txt_xczs.Size = new System.Drawing.Size(65, 12);
            this.txt_xczs.TabIndex = 0;
            this.txt_xczs.Text = "线程总数：";
            // 
            // text_jsd
            // 
            this.text_jsd.Location = new System.Drawing.Point(110, 125);
            this.text_jsd.MaxLength = 4;
            this.text_jsd.Name = "text_jsd";
            this.text_jsd.Size = new System.Drawing.Size(186, 21);
            this.text_jsd.TabIndex = 7;
            this.text_jsd.Text = "zzzz";
            // 
            // text_ksd
            // 
            this.text_ksd.Location = new System.Drawing.Point(110, 90);
            this.text_ksd.MaxLength = 4;
            this.text_ksd.Name = "text_ksd";
            this.text_ksd.Size = new System.Drawing.Size(186, 21);
            this.text_ksd.TabIndex = 6;
            this.text_ksd.Text = "0000";
            // 
            // txt_jsd
            // 
            this.txt_jsd.AutoSize = true;
            this.txt_jsd.Location = new System.Drawing.Point(15, 128);
            this.txt_jsd.Name = "txt_jsd";
            this.txt_jsd.Size = new System.Drawing.Size(77, 12);
            this.txt_jsd.TabIndex = 3;
            this.txt_jsd.Text = "密码结束点：";
            // 
            // txt_ksd
            // 
            this.txt_ksd.AutoSize = true;
            this.txt_ksd.Location = new System.Drawing.Point(15, 93);
            this.txt_ksd.Name = "txt_ksd";
            this.txt_ksd.Size = new System.Drawing.Size(77, 12);
            this.txt_ksd.TabIndex = 2;
            this.txt_ksd.Text = "密码开始点：";
            // 
            // txt_ts
            // 
            this.txt_ts.ForeColor = System.Drawing.Color.Red;
            this.txt_ts.Location = new System.Drawing.Point(12, 209);
            this.txt_ts.Name = "txt_ts";
            this.txt_ts.Size = new System.Drawing.Size(460, 25);
            this.txt_ts.TabIndex = 4;
            this.txt_ts.Text = "提示文本";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 241);
            this.Controls.Add(this.txt_ts);
            this.Controls.Add(this.gb_1);
            this.Controls.Add(this.text_url);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 280);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "百度网盘分享文件密码测试器 —By：52pojie(zgcwkj)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.gb_1.ResumeLayout(false);
            this.gb_1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label txt_url;
        private System.Windows.Forms.TextBox text_url;
        private System.Windows.Forms.GroupBox gb_1;
        private System.Windows.Forms.Label txt_ksd;
        private System.Windows.Forms.Label txt_jsd;
        private System.Windows.Forms.TextBox text_jsd;
        private System.Windows.Forms.TextBox text_ksd;
        private System.Windows.Forms.TextBox text_zxsd;
        private System.Windows.Forms.TextBox text_xczs;
        private System.Windows.Forms.Label txt_zxsd;
        private System.Windows.Forms.Label txt_xczs;
        private System.Windows.Forms.Label txt_ts;
    }
}

