using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TencentDynamicDNS
{
    internal class DomainConfig
    {
        public string? secretId { get; set; }
        public string? domainName { get; set; }
        public string? secretKey { get; set; }
        public string? hostName { get; set; }
        public string getIpUrl { get; set; } = "https://ifconfig.me/";
        public string iniPath { get;} = System.Environment.CurrentDirectory + "\\DomainConfit.ini";
        public decimal interval { get; set; } = 600;
        private string section = "Config";
        public DomainConfig(string secretId, string domainName, string secretKey, string hostName,string getIpUrl ,int interval)
        {
            this.secretId = secretId;
            this.domainName = domainName;
            this.secretKey = secretKey;
            this.hostName = hostName;
            this.getIpUrl = getIpUrl;
            this.interval = interval;
        }
        public DomainConfig()
        {
            this.secretId = null;
            this.domainName = null;
            this.secretKey = null;
            this.hostName = null;
        }


        public void Read()
        {
            this.secretId = IniFile.ReadValue(iniPath, section, "secretId");
            this.secretKey = IniFile.ReadValue(iniPath, section, "secretKey");
            this.domainName = IniFile.ReadValue(iniPath, section, "domainName");
            this.hostName = IniFile.ReadValue(iniPath, section, "hostName");
            this.getIpUrl = IniFile.ReadValue(iniPath, section, "getIpUrl");
            string _interval = IniFile.ReadValue(iniPath, section, "interval");
            if(_interval != "")
            {
                this.interval = decimal.Parse(IniFile.ReadValue(iniPath, section, "interval"));
            }            
        }
        public void Write()
        {
            IniFile.Write(iniPath, section, "secretId", secretId);
            IniFile.Write(iniPath, section, "secretKey", secretKey);
            IniFile.Write(iniPath, section, "domainName", domainName);
            IniFile.Write(iniPath, section, "hostName", hostName);
            IniFile.Write(iniPath, section, "getIpUrl", getIpUrl);
            IniFile.Write(iniPath, section, "interval", interval.ToString());
        }
    }
}
