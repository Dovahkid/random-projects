#include <iostream>

#define print(x) std::cout << x << std::endl; 
#define pause std::cin.get();


int main(){

	auto autoVar = 10; // the compiler decided that this variable "autoVar" is an int because of its initializer value
	autoVar = 'a'; // Here we set the variable "autoVar" to a char, so the value of "autoVar" becomes the ASCII value of 'a'
	print(autoVar);

	char charVar = 'a';
	charVar = 109; // Here we set the char variable "charVar" to an int, so it uses the int as an ASCII code
	print(charVar);
	

	pause;

	return 0;
}