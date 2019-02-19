using System;
using System.IO;
using System.Text;

namespace Encoding_Changer
{
    class Program
    {
        static void Main(string[] arguments)
        {
            if (arguments.Length >0)
            {
                String filePath = arguments[0];
                String filePathTemp = filePath+"temp";
                if (File.Exists(filePath))
                {
                    String[] fileContent = File.ReadAllLines(filePath,Encoding.Default);
                    File.WriteAllLines(filePathTemp, fileContent, Encoding.Unicode);

                    File.Delete(filePath);
                    File.Move(filePathTemp, filePath);

                }



                Environment.Exit(0);
            }
        }
    }
}
