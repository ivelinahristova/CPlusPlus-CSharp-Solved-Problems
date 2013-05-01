using System;
using System.Text;
class Letter
{
    static void Main()
    {
        string wordOne, wordTwo;
        char letter=' ';
        
        ushort i, j, count=0, max=0;
        wordOne = Console.ReadLine();
        wordTwo = Console.ReadLine();
        for ( i = 0; i < wordOne.Length; i++)
        {
            count = 0;
            for ( j = 0; j < wordTwo.Length; j++)
            {
                if (wordOne[i] == wordTwo[j]) { count++; }

            }
            if (max==count)
            {
                if ((int)letter>(int)wordOne[i])
                {
                    letter = wordOne[i];
                }
            }
            if (max<count)
            {
                max = count; letter = wordOne[i];
            }
            
        }
        if (letter==' ')
        {
            Console.WriteLine("0");
        }
        else Console.WriteLine(letter);
    }
}
