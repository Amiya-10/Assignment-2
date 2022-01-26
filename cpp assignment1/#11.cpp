//to find numbers divisible by 7 between 200 and 300
#include <iostream>
using namespace std;
int main() {
    int i;
    for(i=200;i<=300;i++)
    {
        if(i%7==0)
        {
            cout<<i<<" "<<endl;
        }
    }
    return 0;
}