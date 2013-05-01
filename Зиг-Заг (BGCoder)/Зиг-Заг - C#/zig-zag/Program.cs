using System;

class ZigZag
{
    static void Main()
    {
    byte N,count=0,max=0,i,j;
        do 
        {
            N = byte.Parse(Console.ReadLine());
        } while (N < 0 || N > 50);
    int[] a=new int[N];
    bool k=false;
    

    for(i=0;i<N;i++)
    { a[i] = int.Parse(Console.ReadLine()); }
    for(i=0;i<N;i++)
    {if(a[0]!=a[i]){k=true; break;}}
    for(j=1;j<N-1;j++)
    {   count=0;
        for(i=j;i<N-1;i++)
    {


        if((a[i]-a[i-1])*(a[i+1]-a[i])<0){count++;}

            else
                {
                    if(max<count)max=count;
                    count=0;

                }
    }
    }
    if (k == false) Console.WriteLine(0);
    else
    {
        if (N == 0) Console.WriteLine(0);
    else
            if (N == 1) Console.WriteLine(1);
    else
                Console.WriteLine(max+2);
    }
    }
}
