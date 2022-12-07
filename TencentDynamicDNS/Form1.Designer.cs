namespace TencentDynamicDNS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbx_secretId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_secretKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_domainName = new System.Windows.Forms.TextBox();
            this.tbx_hostName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_localIp = new System.Windows.Forms.Label();
            this.lbl_dnsIp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.tbx_getIpUrl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.nud_interval = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.iconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.normalButton = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nud_interval)).BeginInit();
            this.iconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_secretId
            // 
            this.tbx_secretId.Location = new System.Drawing.Point(86, 12);
            this.tbx_secretId.Name = "tbx_secretId";
            this.tbx_secretId.Size = new System.Drawing.Size(443, 23);
            this.tbx_secretId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "SecretId:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "SecretKey:";
            // 
            // tbx_secretKey
            // 
            this.tbx_secretKey.Location = new System.Drawing.Point(86, 41);
            this.tbx_secretKey.Name = "tbx_secretKey";
            this.tbx_secretKey.PasswordChar = '*';
            this.tbx_secretKey.Size = new System.Drawing.Size(443, 23);
            this.tbx_secretKey.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "主域名：";
            // 
            // tbx_domainName
            // 
            this.tbx_domainName.Location = new System.Drawing.Point(86, 70);
            this.tbx_domainName.Name = "tbx_domainName";
            this.tbx_domainName.Size = new System.Drawing.Size(443, 23);
            this.tbx_domainName.TabIndex = 5;
            // 
            // tbx_hostName
            // 
            this.tbx_hostName.Location = new System.Drawing.Point(86, 99);
            this.tbx_hostName.Name = "tbx_hostName";
            this.tbx_hostName.Size = new System.Drawing.Size(443, 23);
            this.tbx_hostName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "二级域名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "本地IP：";
            // 
            // lbl_localIp
            // 
            this.lbl_localIp.AutoSize = true;
            this.lbl_localIp.Location = new System.Drawing.Point(86, 261);
            this.lbl_localIp.Name = "lbl_localIp";
            this.lbl_localIp.Size = new System.Drawing.Size(32, 17);
            this.lbl_localIp.TabIndex = 9;
            this.lbl_localIp.Text = "未知";
            // 
            // lbl_dnsIp
            // 
            this.lbl_dnsIp.AutoSize = true;
            this.lbl_dnsIp.Location = new System.Drawing.Point(86, 235);
            this.lbl_dnsIp.Name = "lbl_dnsIp";
            this.lbl_dnsIp.Size = new System.Drawing.Size(44, 17);
            this.lbl_dnsIp.TabIndex = 11;
            this.lbl_dnsIp.Text = "未获取";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "当前解析：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 12;
            this.button1.Text = "保存配置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "启动服务";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(238, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "停止服务";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "服务状态：";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(86, 289);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(44, 17);
            this.lbl_status.TabIndex = 16;
            this.lbl_status.Text = "未启动";
            // 
            // tbx_getIpUrl
            // 
            this.tbx_getIpUrl.Location = new System.Drawing.Point(86, 128);
            this.tbx_getIpUrl.Name = "tbx_getIpUrl";
            this.tbx_getIpUrl.Size = new System.Drawing.Size(443, 23);
            this.tbx_getIpUrl.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "IP获取：";
            // 
            // timer1
            // 
            this.timer1.Interval = 600000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "检查间隔：";
            // 
            // nud_interval
            // 
            this.nud_interval.Location = new System.Drawing.Point(86, 157);
            this.nud_interval.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nud_interval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_interval.Name = "nud_interval";
            this.nud_interval.Size = new System.Drawing.Size(120, 23);
            this.nud_interval.TabIndex = 20;
            this.nud_interval.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(212, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "秒";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.iconMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // iconMenu
            // 
            this.iconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalButton,
            this.exitButton});
            this.iconMenu.Name = "iconMenu";
            this.iconMenu.Size = new System.Drawing.Size(125, 48);
            // 
            // normalButton
            // 
            this.normalButton.Name = "normalButton";
            this.normalButton.Size = new System.Drawing.Size(124, 22);
            this.normalButton.Text = "显示窗口";
            this.normalButton.Click += new System.EventHandler(this.normalButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(124, 22);
            this.exitButton.Text = "退出";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 324);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nud_interval);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbx_getIpUrl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_dnsIp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_localIp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_hostName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_domainName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_secretKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_secretId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "腾讯云动态解析更新软件";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.nud_interval)).EndInit();
            this.iconMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbx_secretId;
        private Label label1;
        private Label label2;
        private TextBox tbx_secretKey;
        private Label label3;
        private TextBox tbx_domainName;
        private TextBox tbx_hostName;
        private Label label4;
        private Label label5;
        private Label lbl_localIp;
        private Label lbl_dnsIp;
        private Label label8;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label9;
        private Label lbl_status;
        private TextBox tbx_getIpUrl;
        private Label label6;
        private System.Windows.Forms.Timer timer1;
        private Label label7;
        private NumericUpDown nud_interval;
        private Label label10;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip iconMenu;
        private ToolStripMenuItem normalButton;
        private ToolStripMenuItem exitButton;
    }
}