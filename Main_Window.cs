using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        //联网获取文件
        public static async Task<string> ReadUrlFile(string fileUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(fileUrl);
                    response.EnsureSuccessStatusCode();

                    string content = await response.Content.ReadAsStringAsync();
                    return content;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"读取文件失败: {ex.Message}");
                    return string.Empty;
                }
            }
        }

        //检查更新
        public static void CheckUpdate()
        {

        }
        //构造函数====================================================================================
        public Main_Window()
        {
            InitializeComponent();

            //测试
            Console.WriteLine(ReadUrlFile("https://raw.githubusercontent.com/bilibilihuazi/AutoUpdateTest/refs/heads/master/_AutoUpdate/Version.txt"));
            
        }
        //主代码区======================================================================================
        private void Main_Window_Load(object sender, EventArgs e)
        {

        }
    }
}
