#include "clockType.h"
#include <iostream>

int main() {
    double time;

    std::cout << "Enter the time in a double form. (No seconds): ";
    std::cin >> time;
    clockType ct = time; // testing constructor
    ct.print();

    std::cout << "Enter the time in a double form. (No seconds): ";
    std::cin >> time;
    ct = time; // testing regular assignment
    ct.print();

    return 0;
}