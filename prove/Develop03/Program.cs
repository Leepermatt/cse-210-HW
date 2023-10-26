using System;

class Program
{
//     static void Main(string[] args)
//     {
//         do
//         {
//             Scripture.Display();
//             Console.WriteLine ("Press enter to continue, quit to exit.");
//             string input = Console.ReadLine().ToLower();
//             if (input == 'quit')
//             {
//                 break;
//             }
//             else Scripture.hideWord()
//             {

//             }
    

//         } while 
//     }
// }
	    public class Program
    {
        private static List<string> hiddenWords = new List<string>();
 
        public static void Main()
        {
            // Create a list of scriptures.
            List<Scripture> scriptures = new List<Scripture>
            {
                new Scripture("John 3:16", "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life."),
                new Scripture("Romans 8:28", "And we know that for those who love God all things work together for good, for those who are called according to his purpose."),
                new Scripture("Philippians 4:13", "I can do all things through him who strengthens me.")
            };
 
            bool quit = false;
 
            while (!quit)
            {
                Console.Clear();
                DisplayScriptures(scriptures);
 
                Console.WriteLine("\nPress Enter to hide words or type 'quit' to end the program.");
                string input = Console.ReadLine();
 
                if (input.ToLower() == "quit")
                {
                    quit = true;
                }
                else
                {
                    HideRandomWords(scriptures);
                }
            }
        }
    }
}