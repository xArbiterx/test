using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace LabTools
{
    public class CmdHelper
    {
        Process p;
        public CmdHelper()
        {
            p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            //是否使用操作系统shell启动
            p.StartInfo.UseShellExecute = false;
            //接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardInput = true;
            //由调用程序获取输出信息
            p.StartInfo.RedirectStandardOutput = true;
            //重定向标准错误输出
            p.StartInfo.RedirectStandardError = true;
            //不显示程序窗口
            p.StartInfo.CreateNoWindow = true;
            p.OutputDataReceived += Process_OutputDataReceived;
            p.Start();
        }

        public void Excute(string cmdText)
        {
            p.StandardInput.WriteLine(cmdText);
        }

        public void Start()
        {
            try
            {
                p.Start();
                p.BeginOutputReadLine();
                p.BeginErrorReadLine();
            }
            catch (Exception ee)
            {
                string str = ee.Message;
            }
        }

        public void Close()
        {
            //p.WaitForExit();//等待程序执行完退出进程
            p.Close();
            p.Dispose();
        }


        /// <summary>
        /// 输出结果 目前无效
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e != null && e.Data != null)
                Console.WriteLine("out:" + e.Data.ToString());
        }
    }
}
