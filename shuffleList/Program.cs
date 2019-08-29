using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Esta función hara que se creen una lista de indices randomizados.

namespace shuffleList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] shuffle_list = new string []{ "emmanuel", "oscar", "fa", "fabian" };
            int max_number = shuffle_list.Length;
            int[] shuffled_index = new int[max_number];
            shuffled_index = shuffle(max_number);

            
            int count = 0;
            foreach (int element in shuffled_index)
            {
                Console.WriteLine(shuffle_list[element]);
                count += 1;
            }

            aks_for_answer();
            aks_for_answer_two();

        }

        public static int[] shuffle(int max_number)
        {
            int[] shuffle_list = new int[max_number];
            Random rand = new Random();
            int current_random_number;
            int count = 0;
          
            while (count < max_number -1)
            {
                current_random_number = rand.Next(0, max_number);               
                if (!shuffle_list.Contains(current_random_number))
                {
                    shuffle_list[count] = current_random_number;
                }
                else
                {
                    continue;
                }
                count += 1;
            }
           
            return shuffle_list;
     
        }

        public static void aks_for_answer()
        {
            bool game_status = true;
            string respuesta = "";

            while (game_status)
            {
                Console.WriteLine("Dame una respuesta: ");
                respuesta = Console.ReadLine();
                if (respuesta != "exit") {
                    Console.WriteLine("Zzzz...");
                    continue;
                }
                else {
                    return;
                }

            }


        }
        public static void aks_for_answer_two()
        {
            bool game_status = true;
            string respuesta = "";

            while (game_status)
            {
                Console.WriteLine("Dame una segunda respuesta: ");
                respuesta = Console.ReadLine();
                if (respuesta != "exit")
                {
                    Console.WriteLine("Zzzz...");
                    continue;
                }
                else
                {
                    return;
                }

            }
        }


        }



}
