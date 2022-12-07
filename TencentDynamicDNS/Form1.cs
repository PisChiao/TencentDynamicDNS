using System.Net;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;
using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Dnspod.V20210323;
using TencentCloud.Dnspod.V20210323.Models;


namespace TencentDynamicDNS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DomainConfig config = new DomainConfig();
        private void button1_Click(object sender, EventArgs e)
        {
            config.secretId = tbx_secretId.Text;
            config.domainName = tbx_domainName.Text;
            config.secretKey = tbx_secretKey.Text;
            config.hostName = tbx_hostName.Text;
            config.getIpUrl = tbx_getIpUrl.Text;
            config.interval = nud_interval.Value;
            config.Write();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Start(sender, e);
        }

        private bool checkIp(object sender, EventArgs e)
        {
            string localIp = GetIP();
            if (localIp != null)
            {
                lbl_localIp.Text = localIp;
            }
            else
            {
                lbl_localIp.Text = "�޷���ȡ";
                return false;
            }
            DescribeRecordListResponse dnsIpResponse = GetDnsIp();
            if (dnsIpResponse != null)
            {
                lbl_dnsIp.Text = dnsIpResponse.RecordList[0].Value;
            }
            else
            {
                lbl_dnsIp.Text = "�޷���ȡ";
                return false;
            }
            if (lbl_localIp.Text != lbl_dnsIp.Text)
            {
                SetDnsIp(dnsIpResponse.RecordList[0].RecordId, lbl_localIp.Text);
                dnsIpResponse = GetDnsIp();
                if (dnsIpResponse != null)
                {
                    lbl_dnsIp.Text = dnsIpResponse.RecordList[0].Value;
                }
                else
                {
                    lbl_dnsIp.Text = "�޷���ȡ";
                    return false;
                }
            }
            return true;
        }

        //��ȡʵʱ�ı��ع���IP
        public string GetIP()
        {
            HttpClient httpClient = new HttpClient();
            string url = "https://ifconfig.me/";
            HttpResponseMessage response = httpClient.GetAsync(url).Result;
            string responseBodystr = response.Content.ReadAsStringAsync().Result;
            return responseBodystr;
        }
        //��ȡ��ǰDNS������IP��ַ
        public DescribeRecordListResponse GetDnsIp()
        {
            try
            {
                // ʵ����һ����֤���������Ҫ������Ѷ���˻�secretId��secretKey,�˴�����ע����Կ�Եı���
                // ��Կ��ǰ��https://console.cloud.tencent.com/cam/capi��վ���л�ȡ
                Credential cred = new Credential
                {
                    SecretId = tbx_secretId.Text,
                    SecretKey = tbx_secretKey.Text
                };
                // ʵ����Ҫ�����Ʒ��client����
                DnspodClient client = new DnspodClient(cred, "");
                // ʵ����һ���������,�������������¼�б�
                DescribeRecordListRequest req = new DescribeRecordListRequest();
                req.Domain = tbx_domainName.Text;
                req.Subdomain = tbx_hostName.Text;
                // ���ص�resp��һ��DescribeRecordListResponse��ʵ��������������Ӧ
                DescribeRecordListResponse resp = client.DescribeRecordListSync(req);
                return resp;
            }
            catch (Exception e)
            {
                lbl_status.Text = e.Message;
                return null;
            }
        }

        public void SetDnsIp(ulong? recordId,string newIp)
        {
            try
            {
                if(recordId == null)
                {
                    lbl_status.Text = "��DNS����";
                    return;
                }
                Credential cred = new Credential
                {
                    SecretId = tbx_secretId.Text,
                    SecretKey = tbx_secretKey.Text
                };

                DnspodClient client = new DnspodClient(cred, "");
                ModifyDynamicDNSRequest req = new ModifyDynamicDNSRequest();
                req.Domain = tbx_domainName.Text;
                req.SubDomain = tbx_hostName.Text;
                req.RecordId = recordId;
                req.RecordLine = "Ĭ��";
                req.Value = newIp;
                ModifyDynamicDNSResponse resp = client.ModifyDynamicDNSSync(req);
                lbl_status.Text = DateTime.Now.ToString() + "  IP���³ɹ�";
            }
            catch (Exception e)
            {
                lbl_status.Text = e.Message;
            }

        }

        public bool LoadConfig()
        {
            config.Read();
            tbx_secretId.Text = config.secretId;
            tbx_secretKey.Text = config.secretKey;
            tbx_domainName.Text = config.domainName;
            tbx_hostName.Text = config.hostName;
            tbx_getIpUrl.Text = config.getIpUrl;
            nud_interval.Value = config.interval;
            if(tbx_secretId.Text == ""|
                tbx_secretKey.Text == ""|
                tbx_domainName.Text =="" |
                tbx_hostName.Text ==""|
                tbx_getIpUrl.Text == ""|
                nud_interval.Value <= 0
                )
            {
                return false;
            }else
            {
                return true;
            }
        }

        public void Start(object sender,EventArgs e)
        {
            if(LoadConfig() && checkIp(sender, e))
            {
                timer1.Interval = ((int)config.interval * 1000);
                timer1.Start();
                lbl_status.Text = "������";
            }
            else
            {
                MessageBox.Show("������д����������Ϣ�����档");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lbl_status.Text = "��ֹͣ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Start(sender, e);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible=false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            checkIp(sender, e);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void normalButton_Click(object sender, EventArgs e)
        {
            notifyIcon1_DoubleClick(sender, e);
        }
    }
}