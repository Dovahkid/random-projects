#include <iostream>

#define print(x) std::cout << x << std::endl;
#define pause std::cin.get();

using namespace std;

template<typename N>
void templateTesting(N value) {

	print(value);

}

int main() {

	templateTesting(10);
	templateTesting(3.1415);
	templateTesting("String");
	templateTesting('C');

	pause;

	return 0;
}