#include <iostream>
#include <iomanip>
#include <cmath>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
    double a, b, c, d, x, y,z;

    cout<<"ivesite a: ";
    cin >>a;
    cout<<"ivesite b: ";
    cin >>b;
    cout<<"ivesite c: ";
    cin >>c;
    cout<<"ivesite d: ";
    cin >>d;
    cout<<"ivesite x: ";
    cin >>x;
    cout<<"ivesite y: ";
    cin >>y;
    cout<<"ivesite z: ";
    cin >>z;
    b =a * pow(x, 2);
    y =2 * sqrt(a*x-1);
       z= 2* a* x-5;
    d= (b*x+y)/z;
    a= d * pow(x, 2) - 2 * c * sin(x);
       b = (c+d) * cos(x);
           y = a+b+c+d;
    cout << "Rezultatai:" << endl;
    cout << "a = " << a << endl;
    cout << "b = " << b << endl;
    cout << "c = " << c << endl;
    cout << "d = " << d << endl;
    cout << "y = " << y << endl;
    return 0;
}
