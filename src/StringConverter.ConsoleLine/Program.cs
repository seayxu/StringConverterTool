using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace StringConverter.ConsoleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to use String Converter");
            
            if (Environment.OSVersion.Platform != PlatformID.Win32NT)
            {
                Console.WriteLine("Sorry to tell you, your system is not supported!");
                return;
            }
            
            string dir = AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.LastIndexOf("tools"));

            string name = "StringConverter.exe";

            string[] files = new string[]
            {
                Path.Combine(dir, "content", name),
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, name)
            };

            string file = files.FirstOrDefault(x => File.Exists(x));

            if (file == null)
            {
                Console.WriteLine("StringConverter.exe is not found, maybe you should uninatall and re-inatall!");
                return;
            }

            Process.Start(file);
        }
    }
}
