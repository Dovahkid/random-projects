#include <iostream>

using namespace std;

struct test
{
    public:
        int num1 = 1;
    private: 
        int num = 10;
    public:
        int *num3 = &num;

};

int main()
{

    test test2;

    int *ptr = &test2.num1 + 1; // gets private value through janky means
    cout << *ptr << endl; // displays private var
    cout << &test2.num1 << endl; // memory address of var that comes before the private var
    cout << &test2.num1 + 1 << endl; // calculated memory address of private var
    cout << test2.num3 << endl; // double check the value

    *ptr += 1; // changes private variable value through janky means
    cout << *ptr << endl;

    *test2.num3 = 12; // changes private var without janky means
    cout << *ptr;

    cin.get();

    return 0;
}