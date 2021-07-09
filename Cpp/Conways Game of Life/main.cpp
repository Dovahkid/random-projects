#include <iostream>
#include "conway.cpp"

using namespace std;

int main()
{
    Conway cw(10);

    cw.mainLoop();

    //delete &cw;

    cin.get();

    return 0;
}