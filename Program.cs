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

            MooseSays();
        }

        static void MooseSays()
        {
            Console.WriteLine(@"
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
                       |   / \   |    H I, I'M  E N T H U S I A S T I C !
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