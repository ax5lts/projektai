#include <iostream>
#include <fstream>
#include <cmath>
using namespace std;

int main() {
    int n;
    int m;
    cout<< "iveskite n skaiciu: ";
    cin >>n;
    cout<< "iveskite m skaiciu: ";
    cin >>m;
    int suma=0;
    //1. uzduotis nuo n iki m suma
    for(int i=n; i<=m; i++){
        suma += i; //sudedi kiekviena 1 pvz 1+2+3.....=...
    }
    cout<<"nuo "<<n<<" iki " <<m<<" suma = "<<suma<<endl;
    //2. uzduotis kiek yra skaiciu dalijamu is 3
    int kiek=0;
    for(int i=n; i<=m; i++)
    {
        if(i % 3 == 0) //jiegu dalijasi is 3
        {
            kiek++;//pridedi +1
        }
    }
        cout << "Skaiciu dalijamu is 3 kiekis intervale [" << n << ";" << m << "] = " << kiek << endl;
     return 0;
}
