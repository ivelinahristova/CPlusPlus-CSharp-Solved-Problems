#include <iostream>
#include<cmath>
#include<stdlib.h>
using namespace std;
int Digits(int number)
{
    int br=0;
    while(number!=0)
    {
        number=number/10;
        br++;
    }
    return br;
}
bool Palindrom(int number)
{
    int br=Digits(number),i=0,numberSafe;
    numberSafe=number;
    char numberTwo[br+1];
    while(number!=0)
    {
        numberTwo[i]='0' + number%10;
        number/=10;
        i++;

    }
    if(numberSafe==atoi(numberTwo))return 1;
    else return 0;
}
int main()
{
    int number;
    cin>>number;
    if(Palindrom(number))cout<<"Chisloto e Palindrom \n";
    else cout<<"Ne e Palindrom \n";
    return 0;
}
