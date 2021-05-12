
using System;                // Console
using System.IO;             // FileStream, FileReader
    
class FileDetails 
{
    static void Main(string[] args)
    {
        Console.WriteLine(args.Length);
        foreach (string arg in args)
        {
            Console.WriteLine(arg);
        }
    }

}
