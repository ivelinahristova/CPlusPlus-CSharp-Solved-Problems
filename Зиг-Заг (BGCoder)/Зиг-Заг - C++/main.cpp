#include <iostream>
using namespace std;
int main()
{
    short int N,count=0,max=0,i,j;
    int a[50];
    bool k=0;
    do{cin>>N;}while(N<0 || N>50);

    for(i=0;i<N;i++)
    {cin>>a[i];}
    for(i=0;i<N;i++)
    {if(a[0]!=a[i]){k=1; break;}}
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
    if(k==0)cout<<0<<endl;
    else
    {if(N==0)cout<<0<<endl;
    else
    if(N==1)cout<<1<<endl;
    else
    cout<<max+2<<endl;}
    return 0;
}
