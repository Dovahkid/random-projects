#include "clockType.h"
#include <cmath>
#include <iostream>

void clockType::assign(const double& right) {
    dblRepresentation = right;
    minutes = static_cast<double>(std::modf(dblRepresentation, &hours)*100.00);
}

void clockType::operator=(const double& right) {
    assign(right);
}

void clockType::print() {

    std::cout << hours << ":" << minutes << " - " << dblRepresentation<< std::endl;
}

clockType::clockType(const double& right) {
    assign(right);
}