# C# viope course

## Exercises that are not included in the program
8.1 Reading from file
using System;
using System.IO;
using System.Linq;

namespace ReadingFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Any())
            {
                var path = args[0];
                if (File.Exists(path))
                {
                    var content = File.ReadAllText(path);
                    Console.WriteLine(content);
                }
                else
                {
                    Console.WriteLine("File does not exist!");
                }
            }
            else
            {
                Console.WriteLine("No filename provided!");
            }
        }
    }
}
8.2 Write file
using System;
using System.IO;

namespace WriteFile
{
    class Program
    {
        static void Main()
        {
            Console.Write("Filename to create: ");
            string fileName = Console.ReadLine();
            Console.WriteLine("Provide the content for {0}:",fileName);
            string content = Console.ReadLine();

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.Write(content);
            }
        }
    }
}
8.3 Append to file 
using System;
using System.IO;

namespace Append
{
    class Append
    {
        static void Main()
        {
            string FileName;
            string Content;
            Console.Write("Append to file: ");
            FileName = Console.ReadLine();
            Console.WriteLine("Provide the content for {0}:",FileName);
            Content = Console.ReadLine();
            using (StreamWriter sw = new StreamWriter(FileName,true))
            {
                sw.WriteLine(Content);
                sw.Close();
            }
        }
    }
}

## Author 
**DigiKris** 
<a href="https://kkristjan.com/" target="_blank">kkristjan.com</a> 