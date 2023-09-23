using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Streams
{
    internal class StreamLesson
    {
        public static void TestOne()
        {
            char ch;
            Console.WriteLine("Press the key followed by enetr");
            int x = Console.Read();
            ch = (char)x;
            Console.WriteLine("\n"+x+ "your key is:" +ch);

        }
        public static void TestTwo()
        {
            char ch = ' ';
            Console.WriteLine("Press a key q to exit:");
            while(ch != 'q ')
            {
                ch = (char)Console.Read();
                Console.WriteLine("Your key is :" + ch);
            }
        }
        public static void TestThree()
        {
            Console.Out.WriteLine("Enter a sentance");
            string? str = Console.ReadLine();
            Console.Out.WriteLine(" "+str);
           
        }
        public static void TesNullableTypes()
        {
            int? x = 0;
            x = null;
            if (x.HasValue)
            {
                Console.WriteLine(x.HasValue);
            }
            else
            {
                Console.WriteLine(x.GetValueOrDefault());
            }


                    

            
        }
        public partial class DemoB
        {
            static MemoryStream memoryStream = new MemoryStream();
            public static void WriteBytesToMemoryStream()
            {
                Console.WriteLine("MemoryStream Length " + memoryStream.Length);
                int arrayLength = 10;
                byte[] dataArray = new byte[arrayLength];

                // Create random numbers and fill the dataArray
                Random r1 = new Random();
                r1.NextBytes(dataArray);
                StringBuilder str = new StringBuilder(arrayLength);
                for (int i = 0; i < arrayLength; i++)
                {
                    str.Append(dataArray[i]);
                    str.Append(";");
                }
                Console.WriteLine(str);



                //bool flag = true;
                //byte[] data = BitConverter.GetBytes(flag);
                BinaryWriter binWriter = new BinaryWriter(memoryStream);
                // read data (the random numbers) from dataArray and write to MemoryStream
                binWriter.Write(dataArray);
                Console.WriteLine("Write Completed " + memoryStream.Length);
            }
            //Using BinaryReader
            public static void ReadBytesFromMemoryStream()
            {
                if (memoryStream.Length == 0)
                {
                    Console.WriteLine("Memory Stream is Empty");
                    return;
                }
                // Create the reader using the stream from the writer.
                BinaryReader binReader = new BinaryReader(memoryStream);
                // Set Position to the beginning of the stream.
                binReader.BaseStream.Position = 0;
                // Read and verify the data.
                int arrayLength = (int)memoryStream.Length;
                byte[] verifyArray = binReader.ReadBytes(arrayLength);
                StringBuilder str = new StringBuilder(arrayLength);
                for (int i = 0; i < arrayLength; i++)
                {
                    str.Append(verifyArray[i]);
                    str.Append(";");
                }
                Console.WriteLine(str);
            }
        }
           
    }
}
