using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    // Let the moose speak!
    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");

    // As a question
    CanadaQuestion();
    EnthusiasticQuestion();
    LoveCSharpQuestion();
    SecretQuestion();
    Console.WriteLine("Thanks for playing!");
}


void MooseSays(string message)
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
};

void MooseResponds1(string message)
{
    Console.WriteLine($@"
  
   ___            ___
/   \          /   \
\_   \        /  __/
 _\   \      /  /__
 \___  \____/   __/
     \_       _/
       | @ @  \_            {message}
       |
     _/     /\
    /o)  (o/\ \_
    \_____/ /
      \____/

    ");
};

void MooseResponds2(string message)
{
    Console.WriteLine($@"
  
\|/    \|/
  \    /
   \_/  ___   ___
   o o-'   '''   '
    O -.         |\     {message}
        | |'''| |
         ||   | |
         ||    ||
         *     *    

    ");
};

void MooseResponds3(string message)
{
    Console.WriteLine($@"
  
  (             )
 `--(_   _)--'
      Y-Y
     /@@ \
    /     \         {message}
    `--'.  \             ,
        |   `.__________/)

    ");
};

void MooseResponds4(string message)
{
    Console.WriteLine($@"
       /)/)/) /).-')
    ////((.'_.--'   .(\(\(\                   n/(/.')_         .
   ((((_/ .'      .-`)))))))                  `-._ ('.'        \`(\
  (_._ ` (         `.   (/ |                      \ (           `-.\
      `-. \          `-.  /                        `.`.           \ \
         `.`.          | /                /)         \ \           | L
           `.`._.      ||_               (()          `.\          ) F
   (`._      `. <    .'.-'                \`-._____    ||        .' /
    `(\`._.._(\(\)_.'.'-------------.___   `-.(`._ `-./ /     _.' .'
      (.-.| \_`.__.-<     `.    . .-'   `-.   _> `-._((`.__.-'_.-'
          (.--'   ' |    \ \     /| \.-./ |\ `-.   _.'>.___,-'`.
             (  o  <      |     |  `o   o'  |  /(`'.-'   --.    \
           .'     /      .'   _ |   |   |   |  ( .'/  o .-'   \  |
           (__.-.`-._  -'    '   \  \   /  /    ' /    _/      | J  {message}
                 \_  `.      _.__.L |   | J      (  .'\`.    _/-./
                   `-<  .-L|'`-|  ||\\V/ ||       `'   L \  /   /
                      |J  ||    \ ||||  |||            |  |_|  )
                      ||  ||     )||||  |||            || / ||J
                      (|  (|    / |||)  (||            |||  |||
                      ||  ||   / /||||  |||            |(|  |||
                      ||  ||  / / ||||  |||            |||  |||
_______.------.______/ |_/ |_/_|_/// |__| \\__________// |--( \\---------
                    '-' '-'       '-'    `-`           '-'   `-`

    ");
};

bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}


void CanadaQuestion()
{
    bool isTrue = MooseAsks("Is Canada real?");
    if (isTrue)
    {
        MooseResponds1("Really? It seems very unlikely.");
    }
    else
    {
        MooseResponds1("I  K N E W  I T !!!");
    }
}

void EnthusiasticQuestion()
{
    bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
    if (isEnthusiastic)
    {
        MooseResponds2("Yay!");
    }
    else
    {
        MooseResponds2("You should try it!");
    }
}

void LoveCSharpQuestion()
{
    bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
    if (doesLoveCSharp)
    {
        MooseResponds3("Good job sucking up to your instructor!");
    }
    else
    {
        MooseResponds3("You will...oh, yes, you will...");
    }
}

void SecretQuestion()
{
    bool wantsSecret = MooseAsks("Do you want to know a secret?");
    if (wantsSecret)
    {
        MooseResponds4("ME TOO!!!! I love secrets...tell me one!");
    }
    else
    {
        MooseResponds4("Oh, no...secrets are the best, I love to share them!");
    }
}
