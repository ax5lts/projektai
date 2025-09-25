#include <iostream>
#include <fstream>
#include <cmath>
using namespace std;

int main() {
    ifstream fd("kvadratineslygtis.txt");//atidarom faila
    ofstream fr("atsakymai.txt");//rasom i faila

    int a, b, c; //kintamieji
    while (fd >> a >> b >> c) {
        int d = (b*b) - 4*a*c; // diskriminantas
        fr << "Lygtis: " << a << "x^2 + " << b << "x + " << c << " = 0" << endl;
        fr << "d = " << d << endl;

        if (d < 0) {
            fr << "Sprendinio nera" << endl;
        } else if (d == 0) {
            double x = -b / (2.0*a);
            fr << "Vienas sprendinys: x = " << x << endl;
        } else {
            double x1 = (-b - sqrt(d)) / (2.0*a);
            double x2 = (-b + sqrt(d)) / (2.0*a);
            fr << "Du sprendiniai: x1 = " << x1 << ", x2 = " << x2 << endl;
        }

    }

    fd.close();
    fr.close();
    return 0;
}
