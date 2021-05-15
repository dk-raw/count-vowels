using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            CountVowels("dogecoin");
        }
        private static void CountVowels(string str)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'o' || str[i] == 'u' || str[i] == 'i' || str[i] == 'y' || str[i] == 'e')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
