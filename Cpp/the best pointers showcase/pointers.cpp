#include <iostream>
#include <iomanip>
using namespace std;

void ptr_showcase(int test, int& ptr) {
    cout << right << setw(35) << "Copy variables address:\t" << &test << endl;
    cout << right << setw(35) << "Reference variable Address:\t" << &ptr << "<-- Same" <<  endl;
    
}

int main()
{
    int test = 0;
    // this here is a pointer variable. You define a pointer variable with the *
    // it holds a pointer of the defined type
    int *ptr_of_test = &test;
    
    // can see here im passing the exact same variable
    ptr_showcase(test, test);
    cout << "------------------------------------------------------" << endl;
    cout << right << setw(35) << "Original variable Address:\t" << &test << "<-- Same" << endl;
    cout << right << setw(35) << "Pointer variable holding address:\t" << ptr_of_test << "<-- Same" << endl;
    
	cin.get();
	
    return 0;
}
