#include <iostream>
using namespace std;

#define print(x) std::cout << x << std::endl;

class arrOfObjTest {

public:
	int a;
	int b;

};


void main() {

	/*
	arrOfObjTest obj[5];
	
	for (int i = 0; i < 5; i++) {
		obj[i].a = i;
		obj[i].b = i;
	}
	for (int i = 0; i < 5; i++) {
		print(obj[i].a);
		print(obj[i].b);
	}
	*/

	// dynamic arrays of objects
	
	arrOfObjTest *obj2;
	int n;
	cin >> n;
	obj2 = new arrOfObjTest[n];


	for (int i = 0; i <= n*2; i++) {
		obj2[i].a = i;
		print(obj2[i].a);
	}

	int thingy = 1;
	int* ptr = &thingy;

cin.get();
cin.get();
}