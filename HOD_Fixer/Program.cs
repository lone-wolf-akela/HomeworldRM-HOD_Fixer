using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworld2.HOD;

namespace HOD_Fixer
{
    class Program
    {
        static void Main(string[] args)
        {
            //args =new string[1];
            //args[0] = @"D:\新建文件夹\ship";

            GenericMath.GenericMath.InitializeGenericMath();

            if (args.Length < 1)
            {
                Console.WriteLine("Please drag and drop the folder containing .hod files such as 'ship' and 'subsystem' to this EXE.");
                Console.WriteLine("Press Any Key to Exit...");
                Console.ReadKey();
                Environment.Exit(1);
            }
            string[] files = Directory.GetFiles(args[0], "*.hod", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine($"Fixing{file}...");
                var hod = new HOD();
                hod.UnlockMeshes();
                try
                {
                    using (var s = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        hod.Read(s);
                    }
                    using (var s = new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        hod.Write(s);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e}");
                }
            }
            Console.WriteLine("Finished！");
            Console.WriteLine("Press Any Key to Exit...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
