using System;

namespace StringsChallenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string here");
            string fromUser = Console.ReadLine();
            Console.WriteLine("Enter the character to search");
            string characterFromUser = Console.ReadLine();
            int theCharacter = fromUser.IndexOf(characterFromUser);
            if (theCharacter == -1)
            {
                Console.WriteLine("The character you inputed does not exist in the given context");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"The first time this character appears is on the index {theCharacter}");
                Console.WriteLine("Press Enter");
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("Enter your first name");
            string userName = Console.ReadLine();
            userName = userName.Trim();
            Console.WriteLine("Enter your last name");
            string userLastName = Console.ReadLine();
            userLastName = userLastName.Trim();
            Console.WriteLine($"Your full name is {userName} {userLastName}");

        }
    }
}
