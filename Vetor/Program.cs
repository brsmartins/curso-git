using System;

namespace Vetor {
    class Program {
        static void Main(string[] args) {

            Pensao[] vect = new Pensao[10];

            Console.WriteLine("how many rooms will be rented?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.Write("Student name:");
                string name = Console.ReadLine();
                Console.Write("Student email:");
                string email = Console.ReadLine();
                Console.Write("Student room:");
                int room = int.Parse(Console.ReadLine());

                vect[room] = new Pensao { Name = name, Email = email, Room = room };

            }

            for (int i = 0; i < 10; i++) {

                if (vect[i] != null) {
                    Console.WriteLine(vect[i].Name);
                    Console.WriteLine(vect[i].Email);
                    Console.WriteLine(vect[i].Room);
                }
            }
        }
    }
}
