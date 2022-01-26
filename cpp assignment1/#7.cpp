//to print multiplication table
#include <iostream>
using namespace std;
int main() {
    int n = 5; 
    for (int i = 1; i <= 20; ++i)
        cout << n << " * " << i << " = " 
             << n * i << endl;;

    return 0;
}