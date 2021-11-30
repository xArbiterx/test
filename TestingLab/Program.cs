using LabTools;
using System.Management;
using System.Xml.Serialization;
using Microsoft.Win32;

namespace TestingLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var a = System.Environment.OSVersion;
            var b = System.Environment.Is64BitOperatingSystem;

            Console.WriteLine(a + " " + (b ? "64bit" : "32bit"));

        }
    }
}
