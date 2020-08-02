using System;
using System.Collections.Generic;
using HashSolo.Entities;

namespace HashSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Users> users = new HashSet<Users>();
            char[] letra = { 'A', 'B', 'C' };

            //Roda pelas letras
            for (int i = 0; i < 3; i++)
            {
                //Pergunta as classes
                Console.Write($"How many students for course {letra[i]}? ");
                int n1 = int.Parse(Console.ReadLine());

                for (int k = 0; k < n1; k++)
                {
                    int ID = int.Parse(Console.ReadLine());
                    users.Add(new Users(ID));
                }
            }
            Console.WriteLine("Total students: " + users.Count);
        }
    }
}
