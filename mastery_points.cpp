#include <iostream>
#include <limits>
using namespace std;

int ceil_div(int a, int b) {
    // apvali i virsu: ceil(a / b)
    return (a <= 0) ? a<=0 : (a+b-1)/b ;

}

int main() {
    cout << "Ivesk kiek TURI mastery tasku: ";
    int turi;
    if (!(cin >> turi)) return 0;

    cout << "Ivesk kiek REIKIA mastery tasku: ";
    int reikia;
    if (!(cin >> reikia)) return 0;

    cout << "Kiek tasku gauni uz viena zaidima?: ";
    int per_game;
    if (!(cin >> per_game)) return 0;

    if (per_game <= 0) {
        cout << "Klaida: tasku uz zaidima turi buti > 0";
        return 0;
    }

    int likutis = reikia - turi;
    if (likutis <= 0) {
        cout << "Tikslas jau pasiektas arba virsytas";
        return 0;
    }

    int zaidimu = ceil_div(likutis, per_game);

    cout << "Tau truksta " << likutis << " tasku"<<endl;
    cout << "Jei uz zaidima gauni " << per_game;
    cout << " tasku, liko suzaisti: " << zaidimu << " zaidimu";
    return 0;
}
