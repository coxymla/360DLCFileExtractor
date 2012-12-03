using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using wxPirs;

namespace SongsDotDtaExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("usage: SongsDotDtaExtractor arg1 arg2");
                Console.WriteLine("arg1: dir to read with RB dlc files in it");
                Console.WriteLine("arg2: dir to output files to. Make sure it's empty.");
                Console.WriteLine("Press the ANY key to end.");
                Console.ReadLine();
                return;
            }

            var mf = new MainForm(args);
            foreach (var file in Directory.GetFiles(args[0]))
            {
                mf.ProcessFiles(file, args[1]);
            }

            foreach (var file in Directory.GetFiles(args[1]))
            {
                string newName = null;
                using (var sr = new StreamReader(file))
                {
                    var firstLine = sr.ReadLine();
                    if (firstLine != null)
                    {
                        newName = firstLine.Replace("(", "");
                    }
                }

                if (newName != null)
                {
                    File.Move(file, Path.Combine(args[1], newName));
                }
            }

            Console.WriteLine("Press the ANY key to end.");
            Console.ReadLine();
        }
    }
}
