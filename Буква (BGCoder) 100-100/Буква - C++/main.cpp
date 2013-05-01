#include <iostream>
#include<string>
using namespace std;

int main()
{
    string wordOne, wordTwo;
    short count=0,i,j,max=0;
    char letter;
    cin>>wordOne;
    cin>>wordTwo;
    for(i=0;i<wordOne.length(); i++)
    {
        count=0;
        for (j=0;j<wordTwo.length(); j++)
        {
            if(wordOne[i]==wordTwo[j]){count++;}

        }
        if(max==count)
        {
            if(int(letter)>int(wordOne[i]))
            {
                 letter=wordOne[i];
            }
        }
        if(max<count){max=count;  letter=wordOne[i];}
    }
    if(!letter)cout<<"0\n";
    else cout<<letter<<endl;
    return 0;
}
