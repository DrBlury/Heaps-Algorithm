using System;

namespace HeapsAlgoritm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4 };
            Generate(values.Length, values);
            string[] words = { "The", "quick", "brown", "fox" };
            Generate(words.Length, words);
        }

        static void Generate(int length, Array array)
        {
            if (length == 1)
            {
                foreach(object o in array)
                {
                    Console.Write(o.ToString());
                }
                Console.WriteLine();
                return;
            }
            for (int i = 0; i < length - 1; i++)
            {
                Generate(length - 1, array);
                if ((length % 2) == 0)
                    swap(array, i, length - 1);
                else
                    swap(array, 0, length - 1);
            }

            Generate(length - 1, array);
        }

        static void swap(Array array, int index1, int index2)
        {
            object temp = array.GetValue(index1);
            array.SetValue(array.GetValue(index2), index1);
            array.SetValue(temp, index2);
        }
    }
}
