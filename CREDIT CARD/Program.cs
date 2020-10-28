using System;

namespace CREDIT_CARD
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Number: ");
            string number = Console.ReadLine();
            Card card;
            try
            {
                card = new Card(number);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: ", e.Message);
                return;
            }
            Console.WriteLine(card);
        }
    }
}