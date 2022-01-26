//take two numbers as input and find numbers between them
#include <iostream>
using namespace std;
int main() {
    int x,y; 
    cout << "Enter a number"; 
    cin>>x; 
    cout << "Enter another number"; 
    cin >> y; 
    for(int i = x+1; i < y; i++ ) { 
        cout << i << " "; 
    } 
    return 0;
}