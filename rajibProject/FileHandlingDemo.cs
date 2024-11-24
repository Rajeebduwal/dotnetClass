using System;
using System.IO;

// in c# inpu output is done by stream. stream is a sequence of bytes. to write on a file StreamWriter class is used
// to read a file StreamReader class is used

namespace rajibProject
{
     class FileHandlingDemo
    {
        public void writeFile()
        {
            StreamWriter sw = new StreamWriter("D:\\extra\\radib.txt");
            Console.Write("Enter the line of the text: ");
            string data = Console.ReadLine();
            sw.WriteLine(data);
            sw.Flush();
            sw.Close();
        }

        public void readFile()
        {
            StreamReader sr = new StreamReader("D:\\extra\\");
            string ans;
            while ((ans = sr.ReadLine() )!= null)
            {
                Console.Write(ans);
            }
            sr.Close();
        }
    }
}
