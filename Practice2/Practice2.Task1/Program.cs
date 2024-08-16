using System;

namespace Practice2.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(i);
            }

            int j = 0;
            while (j < 25)
            {
                Console.WriteLine(j);
                j++;
            }

            int k = 0;
            do
            {
                Console.WriteLine(k);
                k++;
            }while(k < 25);

            List<string> phrase = new List<string>();
            Console.WriteLine("Для выхода из цикла нажмите 'q'");
            for (; ; )
            {
                string word = Console.ReadLine();
                if (word.ToLower() == "q")
                {
                    break;
                }
                phrase.Add(word);
            }
            Console.WriteLine(String.Join(" ", phrase.ToArray()));

            List<string> phrase2 = new List<string>();
            Console.WriteLine("Для выхода из цикла нажмите 'q'");
            while(true)
            {
                string word = Console.ReadLine();
                if (word.ToLower() == "q")
                {
                    break;
                }
                phrase2.Add(word);
            }
            Console.WriteLine(String.Join(" ", phrase2.ToArray()));

            List<string> phrase3 = new List<string>();
            Console.WriteLine("Для выхода из цикла нажмите 'q'");
            do 
            {
                string word = Console.ReadLine();
                if (word.ToLower() == "q")
                {
                    break;
                }
                phrase3.Add(word);
            }while(true);
            Console.WriteLine(String.Join(" ", phrase3.ToArray()));
        }
    }
}