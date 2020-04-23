using System;
using System.IO;
namespace ConsoleApp1
{
    class BinToChar
    {
        static void Main(string[] args)
        {
            //读
            BinaryReader binaryReader;
            FileStream fs = new FileStream("C:\\Users\\ann_l\\Downloads\\hgrywolf.mid", FileMode.Open);
            binaryReader = new BinaryReader(fs);
            long length = fs.Length;
            byte[] bytes;
            bytes = binaryReader.ReadBytes((int)length);
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0:x2} ", bytes[i]);
            }

            //写
            if (!File.Exists("C:\\Users\\ann_l\\Downloads\\out.txt"))
            {
                File.Create("C:\\Users\\ann_l\\Downloads\\out.txt");
            }

            // FileStream output = new FileStream("C:\\Users\\ann_l\\Downloads\\out.txt", FileMode.Open);
            StreamWriter streamWriter = new StreamWriter("C:\\Users\\ann_l\\Downloads\\out.txt", true);
            for (int i = 0; i < length; i++)
            {
                streamWriter.Write("{0:x2} ", bytes[i]);

            }




        }
    }
}
