using System;

namespace _3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Har du gått ut gymnasiet? (j/n): ");
            string godkänd = Console.ReadLine();

            Console.Write("Hur gammal är du? ");
            int ålder = int.Parse(Console.ReadLine());

            if (godkänd == "j" && ålder < 22)
            {
                Console.WriteLine("Vi vill gärna anställa dig");
            }
            else
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu");
            }
        }
    }
}