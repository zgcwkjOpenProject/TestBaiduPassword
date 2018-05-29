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
            this.txt_url = new System.Windows.Forms.Label();
            this.text_url = new System.Windows.Forms.TextBox();
            this.gb_1 = new System.Windows.Forms.GroupBox();
            this.text_zxsd = new System.Windows.Forms.TextBox();
            this.text_xczs = new System.Windows.Forms.TextBox();
            this.text_jsd = new System.Windows.Forms.TextBox();
            this.text_ksd = new System.Windows.Forms.TextBox();
            this.txt_zxsd = new System.Windows.Forms.Label();
            this.txt_xczs = new System.Windows.Forms.Label();
            this.txt_jsd = new System.Windows.Forms.Label();
            this.txt_ksd = new System.Windows.Forms.Label();
            this.txt_ts = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.fBD = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_status = new System.Windows.Forms.Button();
            this.btn_net = new System.Windows.Forms.Button();
            this.btn_apk = new System.Windows.Forms.Button();
            this.btn_app = new System.Windows.Forms.Button();
            this.btn_blog = new System.Windows.Forms.Button();
            this.gb_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_url
            // 
            this.txt_url.AutoSize = true;
            this.txt_url.Location = new System.Drawing.Point(12, 15);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(65, 12);
            this.txt_url.TabIndex = 0;
            this.txt_url.Text = "目标地址：";
            // 
            // text_url
            // 
            this.text_url.Location = new System.Drawing.Point(83, 11);
            this.text_url.Name = "text_url";
            this.text_url.Size = new System.Drawing.Size(389, 21);
            this.text_url.TabIndex = 1;
            // 
            // gb_1
            // 
            this.gb_1.Controls.Add(this.text_zxsd);
            this.gb_1.Controls.Add(this.text_xczs);
            this.gb_1.Controls.Add(this.text_jsd);
            this.gb_1.Controls.Add(this.text_ksd);
            this.gb_1.Controls.Add(this.txt_zxsd);
            this.gb_1.Controls.Add(this.txt_xczs);
            this.gb_1.Controls.Add(this.txt_jsd);
            this.gb_1.Controls.Add(this.txt_ksd);
            this.gb_1.Location = new System.Drawing.Point(12, 38);
            this.gb_1.Name = "gb_1";
            this.gb_1.Size = new System.Drawing.Size(460, 73);
            this.gb_1.TabIndex = 2;
            this.gb_1.TabStop = false;
            this.gb_1.Text = "相关配置";
            // 
            // text_zxsd
            // 
            this.text_zxsd.Location = new System.Drawing.Point(321, 17);
            this.text_zxsd.MaxLength = 4;
            this.text_zxsd.Name = "text_zxsd";
            this.text_zxsd.Size = new System.Drawing.Size(131, 21);
            this.text_zxsd.TabIndex = 5;
            this.text_zxsd.Text = "200";
            this.text_zxsd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._KeyPress);
            // 
            // text_xczs
            // 
            this.text_xczs.Location = new System.Drawing.Point(93, 17);
            this.text_xczs.MaxLength = 4;
            this.text_xczs.Name = "text_xczs";
            this.text_xczs.Size = new System.Drawing.Size(131, 21);
            this.text_xczs.TabIndex = 4;
            this.text_xczs.Text = "100";
            this.text_xczs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._KeyPress);
            // 
            // text_jsd
            // 
            this.text_jsd.Location = new System.Drawing.Point(321, 43);
            this.text_jsd.MaxLength = 4;
            this.text_jsd.Name = "text_jsd";
            this.text_jsd.Size = new System.Drawing.Size(131, 21);
            this.text_jsd.TabIndex = 7;
            this.text_jsd.Text = "zzzz";
            // 
            // text_ksd
            // 
            this.text_ksd.Location = new System.Drawing.Point(93, 43);
            this.text_ksd.MaxLength = 4;
            this.text_ksd.Name = "text_ksd";
            this.text_ksd.Size = new System.Drawing.Size(131, 21);
            this.text_ksd.TabIndex = 6;
            this.text_ksd.Text = "0000";
            // 
            // txt_zxsd
            // 
            this.txt_zxsd.AutoSize = true;
            this.txt_zxsd.Location = new System.Drawing.Point(232, 20);
            this.txt_zxsd.Name = "txt_zxsd";
            this.txt_zxsd.Size = new System.Drawing.Size(89, 12);
            this.txt_zxsd.TabIndex = 1;
            this.txt_zxsd.Text = "线程执行速度：";
            // 
            // txt_xczs
            // 
            this.txt_xczs.AutoSize = true;
            this.txt_xczs.Location = new System.Drawing.Point(10, 20);
            this.txt_xczs.Name = "txt_xczs";
            this.txt_xczs.Size = new System.Drawing.Size(65, 12);
            this.txt_xczs.TabIndex = 0;
            this.txt_xczs.Text = "线程总数：";
            // 
            // txt_jsd
            // 
            this.txt_jsd.AutoSize = true;
            this.txt_jsd.Location = new System.Drawing.Point(232, 46);
            this.txt_jsd.Name = "txt_jsd";
            this.txt_jsd.Size = new System.Drawing.Size(77, 12);
            this.txt_jsd.TabIndex = 3;
            this.txt_jsd.Text = "密码结束点：";
            // 
            // txt_ksd
            // 
            this.txt_ksd.AutoSize = true;
            this.txt_ksd.Location = new System.Drawing.Point(10, 46);
            this.txt_ksd.Name = "txt_ksd";
            this.txt_ksd.Size = new System.Drawing.Size(77, 12);
            this.txt_ksd.TabIndex = 2;
            this.txt_ksd.Text = "密码开始点：";
            // 
            // txt_ts
            // 
            this.txt_ts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ts.ForeColor = System.Drawing.Color.Red;
            this.txt_ts.Location = new System.Drawing.Point(12, 163);
            this.txt_ts.Name = "txt_ts";
            this.txt_ts.Size = new System.Drawing.Size(379, 69);
            this.txt_ts.TabIndex = 8;
            this.txt_ts.Text = "程序：百度网盘分享文件密码分析器 V 1.8.0.5\r\n\r\n作者：zgcwkj 20180525 更新 (请您著明本程序的出处，谢谢)\r\n\r\n说明：本程序完全免费" +
    "，来自 52pojie 的 MXWXZ 提供数据提交方案\r\n\r\n开源地址：https://github.com/zgcwkj/TestBaiduPassword" +
    "";
            this.txt_ts.Click += new System.EventHandler(this.txt_ts_Click);
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold);
            this.btn_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_start.Location = new System.Drawing.Point(12, 114);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(234, 44);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "打开/生成 解决方案";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_status
            // 
            this.btn_status.Enabled = false;
            this.btn_status.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold);
            this.btn_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_status.Location = new System.Drawing.Point(252, 114);
            this.btn_status.Name = "btn_status";
            this.btn_status.Size = new System.Drawing.Size(94, 44);
            this.btn_status.TabIndex = 4;
            this.btn_status.Text = "启动";
            this.btn_status.UseVisualStyleBackColor = true;
            this.btn_status.Click += new System.EventHandler(this.btn_status_Click);
            // 
            // btn_net
            // 
            this.btn_net.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold);
            this.btn_net.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_net.Location = new System.Drawing.Point(364, 114);
            this.btn_net.Name = "btn_net";
            this.btn_net.Size = new System.Drawing.Size(108, 44);
            this.btn_net.TabIndex = 5;
            this.btn_net.Text = "联网查密";
            this.btn_net.UseVisualStyleBackColor = true;
            this.btn_net.Click += new System.EventHandler(this.btn_net_Click);
            // 
            // btn_apk
            // 
            this.btn_apk.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.btn_apk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_apk.Location = new System.Drawing.Point(397, 161);
            this.btn_apk.Name = "btn_apk";
            this.btn_apk.Size = new System.Drawing.Size(75, 36);
            this.btn_apk.TabIndex = 6;
            this.btn_apk.Text = "安卓版";
            this.btn_apk.UseVisualStyleBackColor = true;
            this.btn_apk.Click += new System.EventHandler(this.btn_apk_Click);
            // 
            // btn_app
            // 
            this.btn_app.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.btn_app.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_app.Location = new System.Drawing.Point(397, 198);
            this.btn_app.Name = "btn_app";
            this.btn_app.Size = new System.Drawing.Size(75, 36);
            this.btn_app.TabIndex = 7;
            this.btn_app.Text = "苹果版";
            this.btn_app.UseVisualStyleBackColor = true;
            this.btn_app.Click += new System.EventHandler(this.btn_app_Click);
            // 
            // btn_blog
            // 
            this.btn_blog.FlatAppearance.BorderSize = 0;
            this.btn_blog.Font = new System.Drawing.Font("宋体", 8F);
            this.btn_blog.Location = new System.Drawing.Point(397, 240);
            this.btn_blog.Margin = new System.Windows.Forms.Padding(0);
            this.btn_blog.Name = "btn_blog";
            this.btn_blog.Size = new System.Drawing.Size(75, 19);
            this.btn_blog.TabIndex = 9;
            this.btn_blog.Text = "关注我";
            this.btn_blog.UseVisualStyleBackColor = true;
            this.btn_blog.Click += new System.EventHandler(this.btn_blog_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 241);
            this.Controls.Add(this.btn_blog);
            this.Controls.Add(this.btn_app);
            this.Controls.Add(this.btn_apk);
            this.Controls.Add(this.btn_net);
            this.Controls.Add(this.btn_status);
            this.Controls.Add(this.txt_ts);
            this.Controls.Add(this.gb_1);
            this.Controls.Add(this.text_url);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.btn_start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 280);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "百度网盘分享文件密码分析器";
            this.gb_1.ResumeLayout(false);
            this.gb_1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.FolderBrowserDialog fBD;
        private System.Windows.Forms.Button btn_status;
        private System.Windows.Forms.Button btn_net;
        private System.Windows.Forms.Button btn_apk;
        private System.Windows.Forms.Button btn_app;
        private System.Windows.Forms.Button btn_blog;
    }
}

