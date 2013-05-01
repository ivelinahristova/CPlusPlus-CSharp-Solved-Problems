#include <iostream>

using namespace std;

int main()
{
    int k,n,x=1,y;
    bool g=0;
    do{cin>>y>>k>>n;}
    while(n>1000000 || n<=0 || k<=0 || k>1000000000 || y<=0 || y>1000000000 || n/k>100000 );

    while((x+y)<=n)
    {
        if((x+y)%k==0){g=1; cout<<x<<" ";}
        x++;
    }
    if(g==0)cout<<"-1"<<endl;
    cout<<endl;
    return 0;
}
