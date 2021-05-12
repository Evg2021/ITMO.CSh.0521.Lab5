
using System;                // Console
using System.IO;             // FileStream, FileReader

class FileDetails
{
    static void Main(string[] args)
    {
        string fileName = args[0];
        FileStream stream = new FileStream(fileName, FileMode.Open);
        StreamReader reader = new StreamReader(stream);
        int size = (int)stream.Length;
        char[] contents = new char[size];
        for (int i = 0; i < size; i++)
        {
            contents[i] = (char)reader.Read();
        }
        foreach (char ch in contents)
        {
            Console.Write(ch);

        }

    }
}