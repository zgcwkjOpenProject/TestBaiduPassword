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
            this.cB_ktwo = new System.Windows.Forms.CheckBox();
            this.cB_mxwxz = new System.Windows.Forms.CheckBox();
            this.CB_zgcwkj = new System.Windows.Forms.CheckBox();
            this.cB_ypsuperkey = new System.Windows.Forms.CheckBox();
            this.gb_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_url
            // 
            this.txt_url.AutoSize = true;
            this.txt_url.Location = new System.Drawing.Point(12, 14);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(65, 12);
            this.txt_url.TabIndex = 0;
            this.txt_url.Text = "目标地址：";
            // 
            // text_url
            // 
            this.text_url.Location = new System.Drawing.Point(83, 10);
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
            this.gb_1.Location = new System.Drawing.Point(12, 37);
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
            this.txt_ts.ForeColor = System.Drawing.Color.Red;
            this.txt_ts.Location = new System.Drawing.Point(12, 163);
            this.txt_ts.Name = "txt_ts";
            this.txt_ts.Size = new System.Drawing.Size(460, 45);
            this.txt_ts.TabIndex = 8;
            this.txt_ts.Text = "程序：百度网盘分享文件密码分析器 V 1.8.1.0\r\n\r\n开源地址：https://github.com/zgcwkj/TestBaiduPassword";
            this.txt_ts.Click += new System.EventHandler(this.txt_ts_Click);
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold);
            this.btn_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_start.Location = new System.Drawing.Point(12, 113);
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
            this.btn_status.Location = new System.Drawing.Point(252, 113);
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
            this.btn_net.Location = new System.Drawing.Point(364, 113);
            this.btn_net.Name = "btn_net";
            this.btn_net.Size = new System.Drawing.Size(108, 44);
            this.btn_net.TabIndex = 5;
            this.btn_net.Text = "联网查密";
            this.btn_net.UseVisualStyleBackColor = true;
            this.btn_net.Click += new System.EventHandler(this.btn_net_Click);
            // 
            // cB_ktwo
            // 
            this.cB_ktwo.AutoSize = true;
            this.cB_ktwo.Location = new System.Drawing.Point(263, 216);
            this.cB_ktwo.Name = "cB_ktwo";
            this.cB_ktwo.Size = new System.Drawing.Size(192, 16);
            this.cB_ktwo.TabIndex = 10;
            this.cB_ktwo.Text = "使用 kTWO 提供的自动代理服务";
            this.cB_ktwo.UseVisualStyleBackColor = true;
            this.cB_ktwo.CheckedChanged += new System.EventHandler(this.cB_ktwo_CheckedChanged);
            // 
            // cB_mxwxz
            // 
            this.cB_mxwxz.AutoSize = true;
            this.cB_mxwxz.Checked = true;
            this.cB_mxwxz.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cB_mxwxz.Location = new System.Drawing.Point(10, 216);
            this.cB_mxwxz.Name = "cB_mxwxz";
            this.cB_mxwxz.Size = new System.Drawing.Size(240, 16);
            this.cB_mxwxz.TabIndex = 10;
            this.cB_mxwxz.Text = "使用 MXWXZ 的数据提交和哈希排序 方案";
            this.cB_mxwxz.UseVisualStyleBackColor = true;
            // 
            // CB_zgcwkj
            // 
            this.CB_zgcwkj.AutoSize = true;
            this.CB_zgcwkj.Checked = true;
            this.CB_zgcwkj.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_zgcwkj.Enabled = false;
            this.CB_zgcwkj.Location = new System.Drawing.Point(10, 243);
            this.CB_zgcwkj.Name = "CB_zgcwkj";
            this.CB_zgcwkj.Size = new System.Drawing.Size(210, 16);
            this.CB_zgcwkj.TabIndex = 11;
            this.CB_zgcwkj.Text = "使用 zgcwkj 提供的多线程等 方案";
            this.CB_zgcwkj.UseVisualStyleBackColor = true;
            // 
            // cB_ypsuperkey
            // 
            this.cB_ypsuperkey.AutoSize = true;
            this.cB_ypsuperkey.Checked = true;
            this.cB_ypsuperkey.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cB_ypsuperkey.Location = new System.Drawing.Point(263, 243);
            this.cB_ypsuperkey.Name = "cB_ypsuperkey";
            this.cB_ypsuperkey.Size = new System.Drawing.Size(216, 16);
            this.cB_ypsuperkey.TabIndex = 12;
            this.cB_ypsuperkey.Text = "使用 云盘万能钥匙 提供放接口服务";
            this.cB_ypsuperkey.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 241);
            this.Controls.Add(this.cB_ypsuperkey);
            this.Controls.Add(this.CB_zgcwkj);
            this.Controls.Add(this.cB_mxwxz);
            this.Controls.Add(this.cB_ktwo);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
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
        private System.Windows.Forms.CheckBox cB_ktwo;
        private System.Windows.Forms.CheckBox cB_mxwxz;
        private System.Windows.Forms.CheckBox CB_zgcwkj;
        private System.Windows.Forms.CheckBox cB_ypsuperkey;
    }
}

