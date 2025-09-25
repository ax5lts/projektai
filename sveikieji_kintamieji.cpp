#include <iostream>
#include <fstream>
#include <cmath>
using namespace std;

int main() {
    int x;
    int y;
//1
  x = 5;
if (x > 4) y = x + 3;
else y = x - 3;
cout<<"a. "<<"x = "<<x<< " "<<"y = "<< y<<endl;
//2
x = 3;
if (x != 3) y = x + 3;
x = x + 2;
y = x + 2;
cout<<"b. "<<"x = "<<x<< " "<<"y = "<< y<<endl;
//3
x = 6;
if (x <= -8) {
    x = x + 2;
    y = x + 3;
}
else y = x - 3;
cout<<"c. "<<"x = "<<x<< " "<<"y = "<< y<<endl;
//4
x = 2;
if (x < 0) y = x - 3;
else {
    x = x + 2;
    y = x + 3;
}
cout<<"d. "<<"x = "<<x<< " "<<"y = "<< y<<endl;
//5
x = 1;
if (x > 0) {
    y = x - 3;
    x = x + 2;
    y = x + 2;
}
else {
    x = x + 2;
    y = x + 3;
}
cout<<"e. "<<"x = "<<x<< " "<<"y = "<< y<<endl;
//6
x = 1;
if (x == 0) {
    y = x - 3;
    x = x + 2;
}
else {
    x = x + 2;
    y = x + 3;
}
cout<<"f. "<<"x = "<<x<< " "<<"y = "<< y<<endl;

    return 0;
}
