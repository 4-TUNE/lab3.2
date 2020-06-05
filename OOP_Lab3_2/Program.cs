using System;
using System.IO;
using System.Linq;

namespace OOP_Lab3_2
{
    class Program
    {
        static string fileRead = @"111.txt";
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(fileRead);
            string readNums = reader.ReadToEnd();
            int[] nums = readNums.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            reader.Close();

            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine($"Sum of all nums is : { sum }");
            
        }
    }
}
