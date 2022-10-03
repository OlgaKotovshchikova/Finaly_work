using System;

namespace Final_work
{
    class Program
    {
        static void Main(string[] args)
        {
            
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
