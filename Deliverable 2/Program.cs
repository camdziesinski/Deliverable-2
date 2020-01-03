using System;

namespace Deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("what is your message?");
            string input = Console.ReadLine().ToUpper();
            string message = "";
            int checksum = 0;

            foreach (char letter in input)
            {
                message = ((message + ((int)letter - 64)) + "-");
                checksum = (checksum + (int)letter);
            }
            Console.Write("Your message was ");
            Console.WriteLine(input);
            Console.Write("Your encoded message is ");
            Console.WriteLine(message.Remove(message.Length - 1));
            Console.Write("Message checksum is ");
            Console.Write(checksum);

        }
    }
}