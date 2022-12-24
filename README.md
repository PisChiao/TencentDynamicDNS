# TencentDynamicDNS

用于定时检查本地的公网IP地址并及时修改DNSPod的解析记录，实现动态域名

C#.NET 6.0
VS2022

首次使用时需要填写配置信息，其中secretId和secretKey可以在腾讯云后台生成。

配置信息保存后，每次启动会自动开始监控，默认间隔600秒检查一次。
