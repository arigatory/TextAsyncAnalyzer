using System;
using System.IO;

namespace TextAsyncAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {   
            var fileName = args[0];
            using (FileStream fs = File.OpenRead(fileName))
            {
                var b = fs.ReadByte();
                Console.WriteLine(b);
            }
        }
    }
}
