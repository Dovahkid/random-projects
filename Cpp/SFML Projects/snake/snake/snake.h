#pragma once
#include "headers.h"

class snake {

public:
	int y;
	int x;
	int length;
	vector<vector<int>> bodyLoc;
	bool crashed;

	bool collisionCheck() {
		return false;
	}

	char lastKey;
	void direction() {

		switch (lastKey) {

			//snake 1
		case 'w':
			y -= 1;
			break;
		case 'a':
			x -= 1;
			break;
		case 's':
			y += 1;
			break;
		case 'd':
			x += 1;
			break;

			//snake 2
		case '8':
			y -= 1;
			break;
		case '4':
			x -= 1;
			break;
		case '2':
			y += 1;
			break;
		case '6':
			x += 1;
			break;
		default:
			y -= 1;
			break;
		}

	}

};