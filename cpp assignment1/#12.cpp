//to compare two strings are equal or not
#include <iostream>
using namespace std;
void compare(string s1, string s2)
{
 
    if (s1 != s2)
    {
        cout << s1 << " is not equal to " << s2 << endl;
        if (s1 > s2)
            cout << s1 << " is greater than " << s2 << endl;
        else
            cout << s2 << " is greater than " << s1 << endl;
    }
    else
        cout << s1 << " is equal to " << s2 << endl;
}
int main() {
    string s1("comp");
    string s2("iscomp");
    compare(s1, s2);
    string s3("comps");
    string s4("comps");
    compare(s3, s4);

    return 0;
}