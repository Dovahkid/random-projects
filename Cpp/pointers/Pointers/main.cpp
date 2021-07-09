#include <iostream>

#define print(x) std::cout << x << std::endl;
#define pause std::cin.get();

class testing {
public:

	int* ptr = &x;
	char* charPtr = &y;

	void testingt() {
	
		print(x);
	
	}

private:

	int x = 2;

	char y;

};

int main() {

	testing tt;

	print(*tt.ptr);
	*tt.ptr = 1; // changes the value of the private 'x'
	print(*tt.ptr);
	tt.testingt();


	*tt.charPtr = 'a';
	print(*tt.charPtr);

	char aChar = 65;
	print(aChar);

	/*
	int c = 9;
	int* ptr = &c;

	print(c);
	print(ptr);

	*ptr = 11;

	print(c);
	print(*ptr);
	*/

	pause;


	return 0;
}