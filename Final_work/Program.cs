using System;

namespace Final_work
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new string[6] { "dsafsdf", "123", "4fes", "fdsafds", "", "4fd" };
            var result = GetArr(arr);
            Console.Write("[");
            foreach (var item in result)
            {

                if (Array.IndexOf(result, item) == result.Length - 1)
                    Console.Write($"\"{item}\"");
                else
                    Console.Write($"\"{item}\", ");
            }
            Console.Write("]");
            Console.WriteLine();
        }

        static public string[] GetArr(string[] arr)
        {
            var arrLenght = 0;
            var indexes = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length <= 3)
                {
                    arrLenght++;
                    indexes += i;
                }
            }

            var result = new string[arrLenght];

            for (int i = 0; i < result.Length; i++)
            {
                var index = Convert.ToInt32(indexes[i].ToString());
                result[i] = arr[index];
            }
            return result;
        }
    }
}
