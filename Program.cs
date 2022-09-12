using System;
using System.Collections.Generic;
using System.Linq;

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
        
        public class QandA
        {
            public string question {get;set;}
            public string trueAnswer {get;set;}
            public string falseAnswer {get;set;}

            public QandA(string question, string trueAnswer, string falseAnswer)
            {
                this.question = question;
                this.trueAnswer = trueAnswer;
                this.falseAnswer = falseAnswer;
            }
        }

        static void AskQuestion(string randomQuestion)
        {
            QandA canada = new QandA("Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!");
            QandA enthusiastic = new QandA("Are you enthusiastic?", "Yay!", "You should try it!");
            QandA csharp = new QandA("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
            QandA secret = new QandA("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
            
            List<QandA> QandAs = new List<QandA>() {canada,enthusiastic,csharp,secret};

            Console.Write($"{randomQuestion} (Y/N): ");
            string answer = Console.ReadLine().ToLower();

            while (answer != "y" && answer != "n")
            {
                Console.Write($"{randomQuestion} (Y/N): ");
                answer = Console.ReadLine().ToLower();
            }

            QandA foundQuestion = QandAs.First(q => q.question == randomQuestion);

            if(answer == "y") 
            {
                MooseSays($"{foundQuestion.trueAnswer}");
            }
            else if (answer == "n")
            {
                MooseSays($"{foundQuestion.falseAnswer}");
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