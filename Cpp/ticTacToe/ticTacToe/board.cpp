#include "stdafx.h"
#include <iostream>

using namespace std;

class board {
public:
	char boardData[3][3] = { { '1', '2', '3' }, 
							 { '4', '5', '6' }, 
							 { '7', '8', '9' } };
	
	void displayBoard() {
	
		cout << boardData[0][0] << ' | ' << boardData[0][1] << ' | ' << boardData[0][2] << ' | ' <<
				boardData[1][0] << ' | ' << boardData[1][1] << ' | ' << boardData[1][2] << ' | ' <<
				boardData[2][0] << ' | ' << boardData[2][1] << ' | ' << boardData[2][2] << ' | ' << endl;

	}

};