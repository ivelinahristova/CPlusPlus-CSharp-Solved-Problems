using System;

class ProstiDeliteli
{
    static void Main()
    {
        ushort i, j, number, count=0;
        bool k = false;
        number = ushort.Parse(Console.ReadLine());
        for ( i = 1; i < number ; i++)
        {
            count = 0;
            k = false;
            if (number % i == 0)
            {
                k = true;
                for ( j = 1; j < i; j++)
                {
                    if (i % j == 0) count++;
                }
                if (k == true && count == 1) Console.WriteLine(i);
            }
        }
    }
}
