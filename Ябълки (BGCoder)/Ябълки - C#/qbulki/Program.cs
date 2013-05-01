using System;

class Apples
{
    static void Main()
    {
        int n, k, x=1, y;
        bool g = false;
        do
        {
            y = int.Parse(Console.ReadLine());
        } while (y<=0 || y>1000000000);
        do
        {
            k = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());  
        } while (n<=0 || n>1000000000 || k<=0 || k>1000000000 || n/k>100000);
        while ((x+y)<=n)
        {
            if ((y+x)%k==0)
            {
                g = true;

                Console.Write(" {0} ",x);
                
            }
            x++;
        }
        if (g==false)
        {
            Console.WriteLine(-1);
        }
    }
}
