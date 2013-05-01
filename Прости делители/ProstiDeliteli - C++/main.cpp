#include <iostream>
#include <ctime>
using namespace std;

int main()
{

    unsigned short number,i,j,br=0;
    bool k=0;
    do{
    cin>>number;
    }while(number<0 || number>10000);
    for(i=1;i<number;i++)
    {
        br=0;k=0;
        if(number%i==0)
        {
            for(j=1;j<i;j++)
            {
            if(i%j==0)br++;
            }
            k=1;
        }
        if(br==1 && k==1)cout<<i<<"\n";

    }
    return 0;
}
