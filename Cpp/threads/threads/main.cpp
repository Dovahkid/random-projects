#include <iostream>
#include <string>

#include <thread>

#define print(x) std::cout << x << std::endl; 

static bool is_finished = false;
std::string newWord = "Type a word";

void workLoad() {

	while (!is_finished) {
		system("cls");
		print(newWord);
	}
}

int main() {

	std::thread working(workLoad);


	std::cin >> newWord;
	
	std::cin.get();
	std::cin.get();

	is_finished = true;

	working.join();

	print("Finished");

	std::cin.get();

	return 0;
}
