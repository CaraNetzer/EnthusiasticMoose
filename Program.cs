using System;

namespace EnthusiasticMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Environment.NewLine: Welcome to the Enthusiastic Moose Simulator!" + Environment.NewLine + "--------------------------------------------");
            Console.WriteLine("Escape Characters: Welcome to the Enthusiastic Moose Simulator!\n--------------------------------------------\n");
            Console.WriteLine(@"@ multi-line string: Welcome to the Enthusiastic Moose Simulator!
--------------------------------------------");

            //MooseSays("H I, I'M  E N T H U S I A S T I C !");
            //MooseSays("I really am enthusiastic");

            AskQuestion("Is Canada real?");
            AskQuestion("Are you enthusiastic?");
            AskQuestion("Do you love C# yet?");
            AskQuestion("Do you want to know a secret?");
        }

        static void AskQuestion(string question)
        {
            Console.Write($"{question} (Y/N): ");
            string answer = Console.ReadLine().ToLower();

            while (answer != "y" && answer != "n")
            {
                Console.Write($"{question} (Y/N): ");
                answer = Console.ReadLine().ToLower();
            }

            if (answer == "y" && question.Contains("Canada"))
            {
                MooseSays("Really? It seems very unlikely.");
            }
            else if (answer == "y" && question.Contains("enthusiastic"))
            {
                MooseSays("Yay!");
            }
            else if (answer == "y" && question.Contains("C#"))
            {
                MooseSays("Good job sucking up to your instructor!");
            }
            else if (answer == "y" && question.Contains("secret"))
            {
                MooseSays("ME TOO!!!! I love secrets...tell me one!");
            }
            else if (answer == "n" && question.Contains("Canada"))
            {
                MooseSays("I  K N E W  I T !!!");
            }
            else if (answer == "n" && question.Contains("enthusiastic"))
            {
                MooseSays("Yay!");
            }
            else if (answer == "n" && question.Contains("C#"))
            {
                MooseSays("You will...oh, yes, you will...");
            }
            else if (answer == "n" && question.Contains("secret"))
            {
                MooseSays("Oh, no...secrets are the best, I love to share them!");
            }
            else
            {
                MooseSays("I don't know that one");
            }
        }

        static void MooseSays(string message)
        {
            Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
            ");
        }
    }
}