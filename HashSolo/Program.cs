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

            Console.Write("How many students for course A? ");
            int n1 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n1; i++)
            {
                int ID = int.Parse(Console.ReadLine());
                users.Add(new Users(ID));
            }

            Console.Write("How many students for course B? ");
            n1 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n1; i++)
            {
                int ID = int.Parse(Console.ReadLine());
                users.Add(new Users(ID));
            }
            
            Console.Write("How many students for course A? ");
            n1 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n1; i++)
            {
                int ID = int.Parse(Console.ReadLine());
                users.Add(new Users(ID));
            }
            Console.WriteLine("Total students: " + users.Count);
        }
    }
}
