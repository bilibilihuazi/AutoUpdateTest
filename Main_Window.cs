using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoUpdateTest
{
    public partial class Main_Window: Form
    {
        //变量========================================================================================
        public static string Title = "自动更新测试程序,当前版本:";
        public static string Version = "Release1.0.0.0";
        //函数========================================================================================

        //HTTP读取文件(同步)
        public static string HttpReadFile(string url)
        {
            try
            {
                // 设置安全协议类型（支持TLS 1.2/1.1/1.0）
                ServicePointManager.SecurityProtocol =
                    SecurityProtocolType.Tls12 |
                    SecurityProtocolType.Tls11 |
                    SecurityProtocolType.Tls;

                // 创建带自定义验证的HttpClient
                using (var handler = new HttpClientHandler())
                using (var client = new HttpClient(handler))
                {
                    // 忽略SSL证书验证
                    handler.ServerCertificateCustomValidationCallback =
                        (sender, cert, chain, sslPolicyErrors) => true;

                    // 设置超时时间（10秒）
                    client.Timeout = TimeSpan.FromSeconds(10);

                    // 添加浏览器User-Agent
                    client.DefaultRequestHeaders.UserAgent.ParseAdd(
                        "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 " +
                        "(KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");

                    // 发送GET请求
                    var response = client.GetAsync(url).Result;
                    response.EnsureSuccessStatusCode();

                    // 读取字节内容
                    var bytes = response.Content.ReadAsByteArrayAsync().Result;

                    // 检测编码
                    var encoding = DetectEncoding(response, bytes);

                    // 转换为字符串
                    return encoding.GetString(bytes);
                }
            }
            catch
            {
                return string.Empty;
            }
        }

        //HTTPS读文件(检测编码)
        private static Encoding DetectEncoding(HttpResponseMessage response, byte[] bytes)
        {
            try
            {
                // 从Content-Type头获取编码
                var contentType = response.Content.Headers.ContentType;
                if (contentType?.CharSet != null)
                {
                    return Encoding.GetEncoding(contentType.CharSet);
                }
            }
            catch
            {
                // 忽略编码解析错误
            }

            // 尝试通过BOM检测编码
            if (bytes.Length >= 3 && bytes[0] == 0xEF && bytes[1] == 0xBB && bytes[2] == 0xBF)
                return Encoding.UTF8;
            if (bytes.Length >= 2 && bytes[0] == 0xFE && bytes[1] == 0xFF)
                return Encoding.BigEndianUnicode;
            if (bytes.Length >= 2 && bytes[0] == 0xFF && bytes[1] == 0xFE)
                return Encoding.Unicode;

            // 默认使用UTF-8
            return Encoding.UTF8;
        }

        //检查更新
        public static void CheckUpdate()
        {

        }
        //构造函数====================================================================================
        public Main_Window()
        {
            InitializeComponent();

            //初始化
            this.Text = Title + Version;//窗口标题
            label_MainTitle.Text = $"当前版本为{Version}";
            label_MainTitle.Left = this.Width / 2 - label_MainTitle.Width / 2;//标题居中

            //测试
            Console.WriteLine($"最新版本:{HttpReadFile("http://127.0.0.1:5500/_AutoUpdate/Version.txt")}");
            
        }
        //主代码区======================================================================================
        private void Main_Window_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = HttpReadFile("http://127.0.0.1:5500/_AutoUpdate/Version.txt");
        }
    }
}
