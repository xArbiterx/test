using LabTools;
using System.Management;
using System.Xml.Serialization;
using Microsoft.Win32;
using NPOI.XWPF.UserModel;

namespace TestingLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Environment.OSVersion + "," + 
                (Environment.Is64BitOperatingSystem ? "64bit" : "32bit"));
            var WordHelper = new WordHelper("11.docx");
            WordHelper.Save("1.docx");
        }
    }
}
