//to find total no. of odd and even numbers
#include <iostream>
using namespace std;
int main() {
    int arr[10], eve=0, odd=0, i;
   cout<<"Enter 10 Array Elements: ";
   for(i=0; i<10; i++)
      cin>>arr[i];
   for(i=0; i<10; i++)
   {
      if(arr[i]%2==0)
         eve++;
      else
         odd++;
   }
   cout<<"Total Number of Even Numbers = "<<eve;
   cout<<"Total Number of Odd Numbers = "<<odd;
   cout<<endl;

    return 0;
}