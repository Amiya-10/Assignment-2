//to print series 1,4,9,..625
#include <iostream>
using namespace std;
int main() {
    int n, i = 1;
    cout<<"Enter the range of number(Limit):";
    cin>> n;
    while (i <= n)
    {
        cout<< i * i<<" "<<endl;
        i++;
    }
    return 0;
}