using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class CharToBin
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader("C:\\Users\\ann_l\\Downloads\\souce.txt");
            String input = streamReader.ReadToEnd();
            input = input.Replace("\n", "");
            input = input.Replace("\r", " ");
            string[] inputs = input.Split(" ");
            int len = inputs.Length;
            byte[] bytes = new byte[len];
            for (int i = 0; i < len - 1; i++)
            {
                bytes[i] = Convert.ToByte(inputs[i], 16);
            }

            FileStream fs = new FileStream("C:\\Users\\ann_l\\Downloads\\output.mid", FileMode.OpenOrCreate);
            BinaryWriter binaryWriter = new BinaryWriter(fs);
            fs.Write(bytes, 0, len);
            fs.Close();

        }
    }
}
